using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class PostEntity : BaseEntity
    {
        public string Content { get; set; }
        public string ContentUrl { get; set; }
        public int UserId { get; set; }
        public virtual UserEntity User { get; set; }
        public int GroupId { get; set; }
        public bool IsActive { get; set; }
        public virtual GroupEntity Group { get; set; }
        public DateTime PublishedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
