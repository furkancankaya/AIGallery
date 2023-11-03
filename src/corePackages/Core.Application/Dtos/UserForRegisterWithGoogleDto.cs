namespace Core.Application.Dtos;

public class UserForRegisterWithGoogleDto : IDto
{
    public string Email { get; set; }
    public string Nick { get; set; }
    

    public UserForRegisterWithGoogleDto()
    {
        Email = string.Empty;
        Nick = string.Empty;   
    }

    public UserForRegisterWithGoogleDto(string email, string nick)
    {
        Email = email;
        Nick = nick;     
    }
}
