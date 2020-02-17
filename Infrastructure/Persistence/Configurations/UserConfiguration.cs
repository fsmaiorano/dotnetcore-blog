using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(400).IsRequired();
            builder.Property(x => x.Surname).HasMaxLength(400).IsRequired();
            builder.Property(x => x.Nickname).HasMaxLength(400).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(400).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(400).IsRequired();
            builder.Property(x => x.Avatar).HasMaxLength(600);
            builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.Now).IsRequired();
            builder.Property(x => x.UpdatedAt).HasDefaultValue(DateTime.Now).IsRequired();

            // Relationship
            builder.HasMany(x => x.Posts).WithOne(y => y.User);
            builder.HasMany(x => x.Comments).WithOne(y => y.User);
            builder.HasMany(x => x.UserGroups).WithOne(y => y.User);
        }
    }
}
