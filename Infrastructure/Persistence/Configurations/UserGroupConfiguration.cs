using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistence.Configurations
{
    public class UserGroupConfiguration : IEntityTypeConfiguration<UserGroupEntity>
    {
        public void Configure(EntityTypeBuilder<UserGroupEntity> builder)
        {
            builder.HasKey(x => new { x.UserId, x.GroupId }); // many to many
            builder.Property(x => x.IsAdministrator).IsRequired();
            builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.Now).IsRequired();
            builder.Property(x => x.UpdatedAt).HasDefaultValue(DateTime.Now).IsRequired();

        }
    }
}
