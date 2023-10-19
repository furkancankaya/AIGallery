using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class TokenHistoryConfiguration : IEntityTypeConfiguration<TokenHistory>
{
    public void Configure(EntityTypeBuilder<TokenHistory> builder)
    {
        builder.ToTable("TokenHistories").HasKey(th => th.Id);

        builder.Property(th => th.Id).HasColumnName("Id").IsRequired();
        builder.Property(th => th.Amount).HasColumnName("Amount");
        builder.Property(th => th.Price).HasColumnName("Price");
        builder.Property(th => th.UserId).HasColumnName("UserId");
        builder.Property(th => th.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(th => th.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(th => th.DeletedDate).HasColumnName("DeletedDate");

        builder.HasOne(th => th.User);

        builder.HasQueryFilter(th => !th.DeletedDate.HasValue);
    }
}