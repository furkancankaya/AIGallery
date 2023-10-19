using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class ProConfiguration : IEntityTypeConfiguration<Pro>
{
    public void Configure(EntityTypeBuilder<Pro> builder)
    {
        builder.ToTable("Pros").HasKey(p => p.Id);

        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Type).HasColumnName("Type");
        builder.Property(p => p.UserId).HasColumnName("UserId");
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");

        builder.HasOne(p => p.User);


        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
    }
}