using Application.Features.Categories.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MailKit.Search;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharpCompress.Compressors.Xz;

namespace Application.Features.Categories.Queries.GetById;

public class GetByIdCategoryQuery : IRequest<GetByIdCategoryResponse>
{
    public Guid Id { get; set; }
    public int PageIndex { get; set; }
    public int PageSize { get; set; }

    public class GetByIdCategoryQueryHandler : IRequestHandler<GetByIdCategoryQuery, GetByIdCategoryResponse>
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;
        private readonly CategoryBusinessRules _categoryBusinessRules;

        public GetByIdCategoryQueryHandler(IMapper mapper, ICategoryRepository categoryRepository, CategoryBusinessRules categoryBusinessRules)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
            _categoryBusinessRules = categoryBusinessRules;
        }

        public async Task<GetByIdCategoryResponse> Handle(GetByIdCategoryQuery request, CancellationToken cancellationToken)
        {
            Category? category = await _categoryRepository.GetAsync(
                predicate: c => c.Id == request.Id, 
                include: x => x.Include(x => x.Image.OrderBy(x=>x.Sort).ThenByDescending(x=>x.UpdatedDate).Skip(request.PageIndex* request.PageSize).Take(request.PageSize)).ThenInclude(x => x.User)
                .Include(x=>x.Image).ThenInclude(x=>x.Like)
                .Include(x=>x.Image).ThenInclude(x=>x.SaledImage),
               
                cancellationToken: cancellationToken);
            await _categoryBusinessRules.CategoryShouldExistWhenSelected(category);

            GetByIdCategoryResponse response = _mapper.Map<GetByIdCategoryResponse>(category);
            return response;
        }
    }
}