using Core.Application.Dtos;

namespace Application.Features.Users.Queries.GetList;

public class GetListUserListItemDto : IDto
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Nick { get; set; }
    public string Email { get; set; }
    public bool Status { get; set; }
    public string Photo { get; set; }

    public GetListUserListItemDto()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
        Email = string.Empty;
        Nick = string.Empty;
        Photo = string.Empty;
    }

    public GetListUserListItemDto(int id, string firstName, string lastName, string email, bool status,string nick,string photo)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Status = status;
        Nick = nick;
        Photo = photo;
    }
}
