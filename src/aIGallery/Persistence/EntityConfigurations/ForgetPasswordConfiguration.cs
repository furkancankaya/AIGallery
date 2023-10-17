using Core.Security.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntityConfigurations;
public class ForgetPasswordConfiguration : IEntityTypeConfiguration<ForgetPassword>
{
    public void Configure(EntityTypeBuilder<ForgetPassword> builder)
    {
        builder.ToTable("ForgetPasswords").HasKey(u => u.Id);
        builder.Property(u => u.Id).HasColumnName("Id").IsRequired();
        builder.Property(u => u.Email).HasColumnName("Email").IsRequired();
        builder.Property(u => u.OTP).HasColumnName("OTP").IsRequired();
        builder.Property(u => u.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(u => u.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(u => u.DeletedDate).HasColumnName("DeletedDate");
 

        builder.HasQueryFilter(u => !u.DeletedDate.HasValue);
    }
}
