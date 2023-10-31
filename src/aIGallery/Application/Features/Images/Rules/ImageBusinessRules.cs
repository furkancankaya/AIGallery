using Application.Features.Images.Constants;
using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Security.Entities;
using Domain.Entities;
using Elasticsearch.Net;
using Org.BouncyCastle.Asn1.Sec;

namespace Application.Features.Images.Rules;

public class ImageBusinessRules : BaseBusinessRules
{
    private readonly IImageRepository _imageRepository;
    private readonly IUserRepository _userRepository;
    private readonly IBannedPromptRepository _bannedPromptRepository;

    public ImageBusinessRules(IImageRepository imageRepository,
                               IUserRepository userRepository,
                               IBannedPromptRepository bannedPromptRepository)
    {
        _imageRepository = imageRepository;
        _userRepository = userRepository;
        _bannedPromptRepository = bannedPromptRepository;
    }

    public Task ImageShouldExistWhenSelected(Image? image)
    {
        if (image == null)
            throw new BusinessException(ImagesBusinessMessages.ImageNotExists);
        return Task.CompletedTask;
    }

    public async Task ImageIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        Image? image = await _imageRepository.GetAsync(
            predicate: i => i.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await ImageShouldExistWhenSelected(image);
    }
    public Task AreBlocked(int id)
    {
        
        User? user = _userRepository.Get(predicate: u => u.Id == id, enableTracking: false);
        if (user.Blocked == true)
          throw new BusinessException(ImagesBusinessMessages.AreBlocked); 
        return Task.CompletedTask;
    }
    public Task HavingEnoughToken(int id)
    {
        User? user = _userRepository.Get(predicate: u => u.Id == id, enableTracking: false);
 
        if (user.Token < 5)
          throw new BusinessException(ImagesBusinessMessages.HasNotEnoughToken); 
       
        return Task.CompletedTask;
    }
    public Task IncludeBannedPrompt(string promt)
    {
        if (_bannedPromptRepository.Any(predicate: b => promt.Trim().ToLower().Contains(b.Prompt.Trim().ToLower())))
        {
           
            throw new BusinessException(ImagesBusinessMessages.HasBannedPrompt);
        }
        return Task.CompletedTask;
    }
 
}