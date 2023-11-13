using Application.Features.SaledImages.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Pipelines.Caching;
using MediatR;
using Core.Security.Entities;
using Org.BouncyCastle.Math;
using Npgsql.PostgresTypes;
using Application.Features.Images.Constants;
using Core.CrossCuttingConcerns.Exceptions.Types;

namespace Application.Features.SaledImages.Commands.Create;

public class CreateSaledImageCommand : IRequest<CreatedSaledImageResponse>, ICacheRemoverRequest
{
    public int UserId { get; set; }
    public Guid ImageId { get; set; }

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string CacheGroupKey => "GetSaledImages";

    public class CreateSaledImageCommandHandler : IRequestHandler<CreateSaledImageCommand, CreatedSaledImageResponse>
    {
        private readonly IMapper _mapper;
        private readonly ISaledImageRepository _saledImageRepository;
        private readonly SaledImageBusinessRules _saledImageBusinessRules;
        private readonly IImageRepository _imageRepository;
        private readonly IUserRepository _userRepository;

        public CreateSaledImageCommandHandler(IMapper mapper, ISaledImageRepository saledImageRepository,
                                         SaledImageBusinessRules saledImageBusinessRules, IImageRepository imageRepository, IUserRepository userRepository)
        {
            _mapper = mapper;
            _saledImageRepository = saledImageRepository;
            _saledImageBusinessRules = saledImageBusinessRules;
            _imageRepository = imageRepository;
            _userRepository = userRepository;
        }

        public async Task<CreatedSaledImageResponse> Handle(CreateSaledImageCommand request, CancellationToken cancellationToken)
        {
            Image image = await _imageRepository.GetAsync(x => x.Id == request.ImageId);
            User sellerUser=  await _userRepository.GetAsync(x => x.Id == image.UserId);
            User buyyerUser = await _userRepository.GetAsync(x => x.Id == request.UserId);
            if (buyyerUser.Token < image.SalePrice)
            {
                throw new BusinessException(ImagesBusinessMessages.HasNotEnoughToken);

            }

            sellerUser.Token += (int)(image.SalePrice * 0.8);
            buyyerUser.Token -=image.SalePrice;
            await _userRepository.UpdateAsync(sellerUser);
            await _userRepository.UpdateAsync(buyyerUser);
           
            SaledImage saledImage = _mapper.Map<SaledImage>(request);

            await _saledImageRepository.AddAsync(saledImage);

            CreatedSaledImageResponse response = _mapper.Map<CreatedSaledImageResponse>(saledImage);
            return response;
        }
    }
}