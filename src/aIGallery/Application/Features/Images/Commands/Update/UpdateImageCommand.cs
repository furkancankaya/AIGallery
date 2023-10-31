using Application.Features.Images.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Pipelines.Caching;
using MediatR;
using Application.Features.Images.Constants;
using Core.CrossCuttingConcerns.Exceptions.Types;

namespace Application.Features.Images.Commands.Update;

public class UpdateImageCommand : IRequest<UpdatedImageResponse>, ICacheRemoverRequest
{
    public Guid Id { get; set; }
    public Guid? ArtStyleId { get; set; }
    public Guid? CategoryId { get; set; }
    public string? ImgToImg { get; set; }
    public bool Discover { get; set; }
    public bool SaleStatus { get; set; }
    public int SalePrice { get; set; }

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string CacheGroupKey => "GetImages";

    public class UpdateImageCommandHandler : IRequestHandler<UpdateImageCommand, UpdatedImageResponse>
    {
        private readonly IMapper _mapper;
        private readonly IImageRepository _imageRepository;
        private readonly ImageBusinessRules _imageBusinessRules;
        private readonly IBannedPromptRepository _bannedPromptRepository;

        public UpdateImageCommandHandler(IMapper mapper, IImageRepository imageRepository,
                                         ImageBusinessRules imageBusinessRules, IBannedPromptRepository bannedPromptRepository)
        {
            _mapper = mapper;
            _imageRepository = imageRepository;
            _imageBusinessRules = imageBusinessRules;
            _bannedPromptRepository = bannedPromptRepository;
        }

        public async Task<UpdatedImageResponse> Handle(UpdateImageCommand request, CancellationToken cancellationToken)
        {
            // yasaklý kelimeler check
            // sales status true olyuor ise sale price girilmeli (bunu frontentte banla)
            // prompt,image,UserId,Blocked uppdate edilemez  update edilemez 



            Image? image = await _imageRepository.GetAsync(predicate: i => i.Id == request.Id, cancellationToken: cancellationToken);
            await _imageBusinessRules.ImageShouldExistWhenSelected(image);

            //içeriyo mu kontrolü
            if (request.SaleStatus && request.Discover)
                await _imageBusinessRules.IncludeBannedPrompt(image.Prompt);
            if (request.SaleStatus && request.SalePrice <= 0)
            {
                throw new BusinessException(ImagesBusinessMessages.HasSalePrice);
            }
            
            
            image = _mapper.Map(request, image);

            await _imageRepository.UpdateAsync(image!);

            UpdatedImageResponse response = _mapper.Map<UpdatedImageResponse>(image);
            return response;


        }
    }
}