using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Avatar { get; set; }

        public virtual ICollection<PostEntity> Posts { get; set; }
        public virtual ICollection<CommentEntity> Comments { get; set; }
        public virtual ICollection<UserGroupEntity> UserGroups { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public UserEntity()
        {
            Posts = new List<PostEntity>();
            UserGroups = new List<UserGroupEntity>();
        }
    }
}
