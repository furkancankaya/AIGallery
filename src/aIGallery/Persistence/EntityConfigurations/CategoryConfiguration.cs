
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories").HasKey(c => c.Id);

        builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
        builder.Property(c => c.Name).HasColumnName("Name");
        builder.Property(c => c.Logo).HasColumnName("Logo");
        builder.Property(c => c.Sort).HasColumnName("Sort");
        builder.Property(c => c.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(c => c.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(c => c.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(c => !c.DeletedDate.HasValue);
        builder.HasData(getSeeds());

    }

    private IEnumerable<Category> getSeeds()
    {
        List<Category> categories = new();
        List<string> newItems = new(){
            "Animals,https://storages.aiart.limited/app/realai/generated/zqBEZVjuO.png",
            "Anime,https://storages.aiart.limited/app/realai/generated/vcP7Viv7R.png",
            "Funny,https://storages.aiart.limited/app/realai/generated/h9xJfxLyJ.png",
            "Games,https://storages.aiart.limited/app/realai/generated/yTddOHaqG.png",
            "Music,https://storages.aiart.limited/app/realai/generated/5pA66bWhH.png",
            "Space,https://storages.aiart.limited/app/realai/generated/i2LlVn3AC.png",
            "Logos,https://storages.aiart.limited/app/realai/generated/MO32CXfmz.png"
        };
        foreach (var item in newItems)
        {
            Category category =
    new()
    {
        Id = Guid.NewGuid(),
        Name = item.Split(',')[0],
        Logo = item.Split(',')[1]


    };
            categories.Add(category);
        }



        return categories.ToArray();
    }
}