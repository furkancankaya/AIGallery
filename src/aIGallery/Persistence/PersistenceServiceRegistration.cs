using Application.Services.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using Persistence.Repositories;

namespace Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<BaseDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("AIGallery")));
        services.AddScoped<IEmailAuthenticatorRepository, EmailAuthenticatorRepository>();
        services.AddScoped<IOperationClaimRepository, OperationClaimRepository>();
        services.AddScoped<IOtpAuthenticatorRepository, OtpAuthenticatorRepository>();
        services.AddScoped<IRefreshTokenRepository, RefreshTokenRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUserOperationClaimRepository, UserOperationClaimRepository>();
        services.AddScoped<IUserTempRepository, UserTempRepository>();
        services.AddScoped<IForgetPasswordRepository, ForgetPasswordRepository>();

         services.AddScoped<IArtStyleRepository, ArtStyleRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IImageRepository, ImageRepository>();
        services.AddScoped<ILikeRepository, LikeRepository>();
        services.AddScoped<ISaledImageRepository, SaledImageRepository>();
        services.AddScoped<IArtStyleRepository, ArtStyleRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IImageRepository, ImageRepository>();
        services.AddScoped<ILikeRepository, LikeRepository>();
        services.AddScoped<ILikeRepository, LikeRepository>();
        services.AddScoped<ISaledImageRepository, SaledImageRepository>();
        services.AddScoped<IArtStyleRepository, ArtStyleRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IImageRepository, ImageRepository>();
        services.AddScoped<ILikeRepository, LikeRepository>();
        services.AddScoped<ILikeRepository, LikeRepository>();
        services.AddScoped<ISaledImageRepository, SaledImageRepository>();
        services.AddScoped<IArtStyleRepository, ArtStyleRepository>();
        services.AddScoped<IBannedPromptRepository, BannedPromptRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IImageRepository, ImageRepository>();
        services.AddScoped<IImageRepository, ImageRepository>();
        services.AddScoped<ILikeRepository, LikeRepository>();
        services.AddScoped<ISaledImageRepository, SaledImageRepository>();
        services.AddScoped<IBannedPromptRepository, BannedPromptRepository>();
        services.AddScoped<IProRepository, ProRepository>();
        services.AddScoped<ITokenHistoryRepository, TokenHistoryRepository>();
        return services;
    }
}
