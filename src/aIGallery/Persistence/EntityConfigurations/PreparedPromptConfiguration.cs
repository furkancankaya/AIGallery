using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class PreparedPromptConfiguration : IEntityTypeConfiguration<PreparedPrompt>
{
    public void Configure(EntityTypeBuilder<PreparedPrompt> builder)
    {
        builder.ToTable("PreparedPrompts").HasKey(pp => pp.Id);

        builder.Property(pp => pp.Id).HasColumnName("Id").IsRequired();
        builder.Property(pp => pp.Name).HasColumnName("Name");
        builder.Property(pp => pp.Logo).HasColumnName("Logo");
        builder.Property(pp => pp.Prompt).HasColumnName("Prompt");
        builder.Property(pp => pp.TextToImage).HasColumnName("TextToImage");
        builder.Property(pp => pp.Gender).HasColumnName("Gender");
        builder.Property(pp => pp.Sort).HasColumnName("Sort");
        builder.Property(pp => pp.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(pp => pp.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(pp => pp.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(pp => !pp.DeletedDate.HasValue);


        builder.HasData(getSeeds());
    }
    private IEnumerable<PreparedPrompt> getSeeds()
    {
        List<PreparedPrompt> preparedPromts = new();
        List<string> newItems = new(){
            "ironman 4k musculer,https://storages.aiart.limited/app/realai/generated/3.jpg",
            "platinum short hair playboy model,https://storages.aiart.limited/app/realai/generated/4.jpg",
            "Azure female viking warrior,https://storages.aiart.limited/app/realai/generated/13.jpg",
            "A cairn terrier dog as the doomslayer,https://storages.aiart.limited/app/realai/generated/14.jpg",
            "A bird pokemon with horns and 4 wings,https://storages.aiart.limited/app/realai/generated/15.jpg",
            "Male astronaut, in space, futuristic suit,https://storages.aiart.limited/app/realai/generated/17.jpg",
            "A cute adorable phoenix,https://storages.aiart.limited/app/realai/generated/18.jpg"
        };
        List<string> newItemsMale = new(){
            "Keanu Reeves,https://storages.aiart.limited/app/realai/generated/3 (4).jpg",
            "Neat Curly Quiff,https://storages.aiart.limited/app/realai/generated/0 (4).jpg",
            "Captain America,https://storages.aiart.limited/app/realai/generated/capt.jpg",
            "Brad Pitt,https://storages.aiart.limited/app/realai/generated/brr.jpg",
            "Chris Evans,https://storages.aiart.limited/app/realai/generated/cris (2).jpg",
            "Soldier,https://storages.aiart.limited/app/realai/generated/2 (2).jpg",
            "Superman,https://storages.aiart.limited/app/realai/generated/1 (1).jpg"
        };
        List<string> newItemsFemale = new(){
            "Evening Dresses,https://storages.aiart.limited/app/realai/generated/011.jpg",
            "Amber Heard,https://storages.aiart.limited/app/realai/generated/0amber.jpg",
            "Platinum Short,https://storages.aiart.limited/app/realai/generated/platin.jpg",
            "Daenerys Targaryen,https://storages.aiart.limited/app/realai/generated/tanga.jpg",
            "Harley Quinn,https://storages.aiart.limited/app/realai/generated/harly.jpg",
            "Kim Kardashian,https://storages.aiart.limited/app/realai/generated/kardas.jpg",
            "Angelina Jolie,https://storages.aiart.limited/app/realai/generated/angelina.jpg"
        };
        foreach (var item in newItems)
        {
            PreparedPrompt prepared =
            new()
            {
                Id = Guid.NewGuid(),
                Name = item.Split(',')[0],
                Prompt = item.Split(',')[0],
                Logo = item.Split(',')[1],
                TextToImage = true,
            };
            preparedPromts.Add(prepared);
        }
        foreach (var item in newItemsMale)
        {
            PreparedPrompt prepared =
            new()
            {
                Id = Guid.NewGuid(),
                Name = item.Split(',')[0],
                Prompt = item.Split(',')[0],
                Logo = item.Split(',')[1],
                TextToImage = false,
                Gender = 0
            };
            preparedPromts.Add(prepared);
        }
        foreach (var item in newItemsFemale)
        {
            PreparedPrompt prepared =
            new()
            {
                Id = Guid.NewGuid(),
                Name = item.Split(',')[0],
                Prompt = item.Split(',')[0],
                Logo = item.Split(',')[1],
                TextToImage = false,
                Gender = 1
            };
            preparedPromts.Add(prepared);
        }

        return preparedPromts.ToArray();
    }

}