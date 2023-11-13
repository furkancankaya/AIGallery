using Application.Features.Likes.Constants;
using Application.Features.Likes.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Pipelines.Caching;
using MediatR;

namespace Application.Features.Likes.Commands.Delete;

public class DeleteLikeCommand : IRequest<DeletedLikeResponse>, ICacheRemoverRequest
{
    public Guid ImageId { get; set; }
    public int UserId { get; set; }

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string CacheGroupKey => "GetImages";

    public class DeleteLikeCommandHandler : IRequestHandler<DeleteLikeCommand, DeletedLikeResponse>
    {
        private readonly IMapper _mapper;
        private readonly ILikeRepository _likeRepository;
        private readonly LikeBusinessRules _likeBusinessRules;

        public DeleteLikeCommandHandler(IMapper mapper, ILikeRepository likeRepository,
                                         LikeBusinessRules likeBusinessRules)
        {
            _mapper = mapper;
            _likeRepository = likeRepository;
            _likeBusinessRules = likeBusinessRules;
        }

        public async Task<DeletedLikeResponse> Handle(DeleteLikeCommand request, CancellationToken cancellationToken)
        {
            Like? like = await _likeRepository.GetAsync(predicate: l => l.ImageId == request.ImageId && l.UserId == request.UserId, cancellationToken: cancellationToken);
            await _likeBusinessRules.LikeShouldExistWhenSelected(like);

            await _likeRepository.DeleteAsync(like!);

            DeletedLikeResponse response = _mapper.Map<DeletedLikeResponse>(like);
            return response;
        }
    }
}