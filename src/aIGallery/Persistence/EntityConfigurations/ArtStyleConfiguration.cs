using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class ArtStyleConfiguration : IEntityTypeConfiguration<ArtStyle>
{
    public void Configure(EntityTypeBuilder<ArtStyle> builder)
    {
        builder.ToTable("ArtStyles").HasKey(a => a.Id);

        builder.Property(a => a.Id).HasColumnName("Id").IsRequired();
        builder.Property(a => a.Logo).HasColumnName("Logo");
        builder.Property(a => a.Name).HasColumnName("Name");
        builder.Property(a => a.Prompt).HasColumnName("Prompt");
        builder.Property(a => a.Sort).HasColumnName("Sort");
        builder.Property(a => a.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(a => a.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(a => a.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(a => !a.DeletedDate.HasValue);
        builder.HasMany(a => a.Image);
        builder.HasData(getSeeds());
    }
    private IEnumerable<ArtStyle> getSeeds()
    {
        List<ArtStyle> artStyles = new();
        List<string> newItems = new(){
            "Magical,https://storagez.aiart.limited/app/realai/generated/fab123 (8).png",
            "Neon,https://storagez.aiart.limited/app/realai/generated/fab123 (6).png",
            "Characters,https://storagez.aiart.limited/app/realai/generated/fab123 (7).png",
            "Digital Art,https://storagez.aiart.limited/app/realai/generated/fab123 (3).png",
            "Anime,https://storagez.aiart.limited/app/realai/generated/fab123 (2).png",
            "Beauty,https://storagez.aiart.limited/app/realai/generated/fab123 (4).png",
            "Pencil Art,https://storagez.aiart.limited/app/realai/generated/fab123 (5).png",
            "Realistic,https://storagez.aiart.limited/app/realai/generated/fab123 (1).png"};
        foreach (var item in newItems)
        {
            ArtStyle adminUser =
           new()
           {
               Id = Guid.NewGuid(),
               Name = item.Split(',').First(),
               Logo = item.Split(',').Last(),
               Prompt = item.Split(",").First(),
           };
            artStyles.Add(adminUser);
        }


        return artStyles.ToArray();
    }
}