using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Avatar { get; set; }

        public virtual ICollection<PostModel> Posts { get; set; }
        public virtual ICollection<CommentModel> Comments { get; set; }
        public virtual ICollection<UserGroupModel> UserGroups { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public UserModel()
        {
            Posts = new List<PostModel>();
            UserGroups = new List<UserGroupModel>();
        }
    }
}
