using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class GroupEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Avatar { get; set; }
        public virtual ICollection<PostEntity> Posts { get; set; }
        public virtual ICollection<UserGroupEntity> UserGroups { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
