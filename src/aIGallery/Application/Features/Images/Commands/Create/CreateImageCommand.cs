using Application.Features.Images.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Pipelines.Caching;
using MediatR;
using Application.Features.Images.Constants;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Security.Entities;

namespace Application.Features.Images.Commands.Create;

public class CreateImageCommand : IRequest<CreatedImageResponse>, ICacheRemoverRequest
{
    public string ImageUrl { get; set; }
    public string Prompt { get; set; }
    public Guid? ArtStyleId { get; set; }
    public int UserId { get; set; }
    public Guid? CategoryId { get; set; }
    public string? ImgToImg { get; set; }
    public bool Discover { get; set; }
    public bool SaleStatus { get; set; }
    public int SalePrice { get; set; }
    public bool Blocked { get; set; }
    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string CacheGroupKey => "GetImages";

    public class CreateImageCommandHandler : IRequestHandler<CreateImageCommand, CreatedImageResponse>
    {
        private readonly IMapper _mapper;
        private readonly IImageRepository _imageRepository;
        private readonly ImageBusinessRules _imageBusinessRules;
        private readonly IUserRepository _userRepository;
        public CreateImageCommandHandler(IMapper mapper, IImageRepository imageRepository,
                                         ImageBusinessRules imageBusinessRules, IUserRepository userRepository)
        {
            _mapper = mapper;
            _imageRepository = imageRepository;
            _imageBusinessRules = imageBusinessRules;
            _userRepository = userRepository;
        }

        public async Task<CreatedImageResponse> Handle(CreateImageCommand request, CancellationToken cancellationToken)
        {
            // user Blocked ise üretemez false dönecek true ise => token check appisi jwt token ile çalýþan 5den fazla ise true  5 den az ise false
            // user Blocked ise üretemez
            await _imageBusinessRules.AreBlocked(request.UserId);
            await _imageBusinessRules.HavingEnoughToken(request.UserId);


            request.Blocked = false;
            request.SalePrice = 0;
            request.SaleStatus = false;
            request.Discover = false;
            Image image = _mapper.Map<Image>(request);
            await _imageRepository.AddAsync(image);

            User user = await _userRepository.GetAsync(x => x.Id == request.UserId);
            user.Token -= 5;
            await _userRepository.UpdateAsync(user);

            CreatedImageResponse response = _mapper.Map<CreatedImageResponse>(image);
            return response;


        }


    }
}