using Core.Application.Responses;

namespace Application.Features.Users.Commands.Update;

public class UpdatedUserResponse : IResponse
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Nick { get; set; }
    public bool Status { get; set; }

    public UpdatedUserResponse()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
        Email = string.Empty;
        Nick = string.Empty;
    }

    public UpdatedUserResponse(int id, string firstName, string lastName, string email, string nick, bool status)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Nick = nick;
        Status = status;
    }
}
