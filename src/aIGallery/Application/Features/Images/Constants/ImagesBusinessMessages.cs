namespace Application.Features.Images.Constants;

public static class ImagesBusinessMessages
{
    public const string ImageNotExists = "Image not exists.";
    public const string HasNotEnoughToken = "You have not enough tokens.";
    public const string AreBlocked = "You are blocked.";
    public const string CreateImage = "Could not create image.";
    public const string HasBannedPrompt = "Cannot use banned propmt!";
    public const string HasSalePrice = "Sale Price must be greater than 0.";
    public const string HasMustCategory = "Image must have a category..";
}