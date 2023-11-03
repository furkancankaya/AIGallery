namespace Core.Application.Dtos;

public class UserForRegisterDto : IDto
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string Nick { get; set; }
  
    

    public UserForRegisterDto()
    {
        Email = string.Empty;
        Password = string.Empty;
        Nick = string.Empty;
        
    }

    public UserForRegisterDto(string email, string password, string nick)
    {
        Email = email;
        Password = password;
        Nick = nick;    
    }
}
