using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class BannedPromptConfiguration : IEntityTypeConfiguration<BannedPrompt>
{
    public void Configure(EntityTypeBuilder<BannedPrompt> builder)
    {
        builder.ToTable("BannedPrompts").HasKey(bp => bp.Id);

        builder.Property(bp => bp.Id).HasColumnName("Id").IsRequired();
        builder.Property(bp => bp.Prompt).HasColumnName("Prompt");
        builder.Property(bp => bp.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(bp => bp.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(bp => bp.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(bp => !bp.DeletedDate.HasValue);
    }
}