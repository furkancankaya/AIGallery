using Core.Application.Responses;

namespace Application.Features.Users.Queries.GetById;

public class GetByIdUserResponse : IResponse
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public bool Status { get; set; }
    public string Nick { get; set; }
    public int Token { get; set; }
    public bool Pro { get; set; }
    public GetByIdUserResponse()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
        Email = string.Empty;
        Nick = string.Empty;
        Token = 0;
        Pro = false;
    }

    public GetByIdUserResponse(int id, string firstName, string lastName, string email, bool status,string nick, int token, bool pro)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Status = status;
        Nick = nick;
        Token = token;
        Pro = pro;
    }
}
