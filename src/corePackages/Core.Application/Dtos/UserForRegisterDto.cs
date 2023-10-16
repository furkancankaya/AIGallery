namespace Core.Application.Dtos;

public class UserForRegisterDto : IDto
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Nick { get; set; }

    public UserForRegisterDto()
    {
        Email = string.Empty;
        Password = string.Empty;
        FirstName = string.Empty;
        LastName = string.Empty;
        Nick= string.Empty;
    }

    public UserForRegisterDto(string email, string password, string firstName, string lastName,string nick)
    {
        Email = email;
        Password = password;
        FirstName = firstName;
        LastName = lastName;
        Nick = nick;
    }
}
