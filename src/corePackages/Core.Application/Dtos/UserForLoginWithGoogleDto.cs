namespace Core.Application.Dtos;

public class UserForLoginWithGoogleDto : IDto
{
    public string Email { get; set; }
    public string? AuthenticatorCode { get; set; }

    public UserForLoginWithGoogleDto()
    {
        Email = string.Empty;
    }

    public UserForLoginWithGoogleDto(string email)
    {
        Email = email;
    }
}
