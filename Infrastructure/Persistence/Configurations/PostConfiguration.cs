using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<PostEntity>
    {
        public void Configure(EntityTypeBuilder<PostEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.GroupId).IsRequired();
            builder.Property(x => x.Content).HasMaxLength(400).IsRequired();
            builder.Property(x => x.IsActive).HasDefaultValue(false).IsRequired();
            builder.Property(x => x.PublishedAt);
            builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.Now).IsRequired();
            builder.Property(x => x.UpdatedAt).HasDefaultValue(DateTime.Now).IsRequired();


            // Relationship
            builder.HasOne(x => x.User).WithMany(y => y.Posts);
        }
    }
}
