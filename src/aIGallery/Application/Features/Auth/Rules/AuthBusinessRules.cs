using Application.Features.Auth.Constants;
using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Security.Entities;
using Core.Security.Enums;
using Core.Security.Hashing;

namespace Application.Features.Auth.Rules;

public class AuthBusinessRules : BaseBusinessRules
{
    private readonly IUserRepository _userRepository;
    private readonly IUserTempRepository _userTempRepository;
    private readonly IForgetPasswordRepository _forgetPasswordRepository;
    private readonly IEmailAuthenticatorRepository _emailAuthenticatorRepository;

    public AuthBusinessRules(IUserRepository userRepository, IEmailAuthenticatorRepository emailAuthenticatorRepository,IUserTempRepository userTempRepository, IForgetPasswordRepository forgetPasswordRepository)
    {
        _userRepository = userRepository;
        _userTempRepository = userTempRepository;
        _forgetPasswordRepository = forgetPasswordRepository;
        _emailAuthenticatorRepository = emailAuthenticatorRepository;
    }

    public Task EmailAuthenticatorShouldBeExists(EmailAuthenticator? emailAuthenticator)
    {
        if (emailAuthenticator is null)
            throw new BusinessException(AuthMessages.EmailAuthenticatorDontExists);
        return Task.CompletedTask;
    }

    public Task OtpAuthenticatorShouldBeExists(OtpAuthenticator? otpAuthenticator)
    {
        if (otpAuthenticator is null)
            throw new BusinessException(AuthMessages.OtpAuthenticatorDontExists);
        return Task.CompletedTask;
    }

    public Task OtpAuthenticatorThatVerifiedShouldNotBeExists(OtpAuthenticator? otpAuthenticator)
    {
        if (otpAuthenticator is not null && otpAuthenticator.IsVerified)
            throw new BusinessException(AuthMessages.AlreadyVerifiedOtpAuthenticatorIsExists);
        return Task.CompletedTask;
    }

    public Task EmailAuthenticatorActivationKeyShouldBeExists(EmailAuthenticator emailAuthenticator)
    {
        if (emailAuthenticator.ActivationKey is null)
            throw new BusinessException(AuthMessages.EmailActivationKeyDontExists);
        return Task.CompletedTask;
    }

    public Task UserShouldBeExistsWhenSelected(User? user)
    {
        if (user == null)
            throw new BusinessException(AuthMessages.UserDontExists);
        return Task.CompletedTask;
    }

    public Task UserShouldNotBeHaveAuthenticator(User user)
    {
        if (user.AuthenticatorType != AuthenticatorType.None)
            throw new BusinessException(AuthMessages.UserHaveAlreadyAAuthenticator);
        return Task.CompletedTask;
    }

    public Task RefreshTokenShouldBeExists(RefreshToken? refreshToken)
    {
        if (refreshToken == null)
            throw new BusinessException(AuthMessages.RefreshDontExists);
        return Task.CompletedTask;
    }

    public Task RefreshTokenShouldBeActive(RefreshToken refreshToken)
    {
        if (refreshToken.Revoked != null && DateTime.UtcNow >= refreshToken.Expires)
            throw new BusinessException(AuthMessages.InvalidRefreshToken);
        return Task.CompletedTask;
    }

    public async Task UserEmailShouldBeNotExists(string email)
    {
        bool doesExists = await _userRepository.AnyAsync(predicate: u => u.Email == email, enableTracking: false);
        if (doesExists)
            throw new BusinessException(AuthMessages.UserMailAlreadyExists);
    }
    public async Task UserNickShouldBeNotExists(string nick)
    {
        bool doesExists = await _userRepository.AnyAsync(predicate: u => u.Nick == nick, enableTracking: false);
        if (doesExists)
            throw new BusinessException(AuthMessages.UserNickAlreadyExists);
    }

    public async Task UserEmailShouldBeExists(string email)
    {
        bool doesExists = await _userRepository.AnyAsync(predicate: u => u.Email == email, enableTracking: false);
        if (!doesExists)
            throw new BusinessException(AuthMessages.UserMailAlreadyExists);
    }
    public async Task UserPasswordShouldBeMatch(int id, string password)
    {
        User? user = await _userRepository.GetAsync(predicate: u => u.Id == id, enableTracking: false);
        await UserShouldBeExistsWhenSelected(user);
        if (!HashingHelper.VerifyPasswordHash(password, user!.PasswordHash, user.PasswordSalt))
            throw new BusinessException(AuthMessages.PasswordDontMatch);
    }
    public async Task UserTempCheck(int OTP,string Email)
    {
        UserTemp? user = await _userTempRepository.GetAsync(predicate :x => x.Email==Email && x.OTP== OTP, enableTracking: true);
        TimeSpan timeDifference=new TimeSpan();
        if (user != null)
             timeDifference = DateTime.UtcNow - user.CreatedDate;
        
        if (user ==null)
            throw new BusinessException(AuthMessages.OtpFalse);
        else if(timeDifference.TotalSeconds>60)
            throw new BusinessException(AuthMessages.OtpOverTime);
       
    }

    public async Task ForgetPasswordCheck(int OTP, string Email)
    {
        ForgetPassword? user = await _forgetPasswordRepository.GetAsync(predicate: x => x.Email == Email && x.OTP == OTP, enableTracking: true);
        TimeSpan timeDifference = new TimeSpan();
        if (user != null)
            timeDifference = DateTime.UtcNow - user.CreatedDate;

        if (user == null)
            throw new BusinessException(AuthMessages.OtpFalse);
        else if (timeDifference.TotalSeconds > 60)
            throw new BusinessException(AuthMessages.OtpOverTime);

    }
}
