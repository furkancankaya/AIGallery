using Application.Features.Pros.Rules;
using Application.Features.Users.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Core.Security.Entities;
using MailKit.Search;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Application.Features.Users.Queries.GetById;

public class GetByIdUserQuery : IRequest<GetByIdUserResponse>
{
    public int Id { get; set; }

    public class GetByIdUserQueryHandler : IRequestHandler<GetByIdUserQuery, GetByIdUserResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly UserBusinessRules _userBusinessRules;
        private readonly IProRepository _proRepository;
        private readonly IConfiguration _configuration;

        public GetByIdUserQueryHandler(IUserRepository userRepository, IMapper mapper, UserBusinessRules userBusinessRules, IProRepository proRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _userBusinessRules = userBusinessRules;
            _proRepository = proRepository;
            _configuration = configuration;
        }

        public async Task<GetByIdUserResponse> Handle(GetByIdUserQuery request, CancellationToken cancellationToken)
        {
            User? user = await _userRepository.GetAsync(predicate: b => b.Id == request.Id, include:x=>x.Include(x=>x.Images),cancellationToken: cancellationToken);
            await _userBusinessRules.UserShouldBeExistsWhenSelected(user);

            GetByIdUserResponse response = _mapper.Map<GetByIdUserResponse>(user);
            var data =await _proRepository.GetListAsync(predicate: b => b.UserId == request.Id, orderBy: x => x.OrderByDescending(x=>x.CreatedDate));
            if (data.Items.Count > 0)
            {
                var data2 = data.Items.FirstOrDefault();
                TimeSpan dateTime = (DateTime.UtcNow.Date - data2.CreatedDate);

                if (data2.Type == 1)
                {
                    response.Pro = dateTime.Days > 30 ? false : true;
                }
                else if(data2.Type == 2)
                {
                     response.Pro = dateTime.Days > 360 ? false : true;
                }
            }
            else
            {
                response.Pro = false;
            }

            string apiDomain = _configuration["ImageConfiguration"];
            string photo = response.Photo;
            string[] parts = photo.Split(new string[] { "\\" }, StringSplitOptions.None);
            string desiredPart = apiDomain+ "/Images/" + parts.Last();
            response.Photo = desiredPart;

            return response;
        }
    }
}

