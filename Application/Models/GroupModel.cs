using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Models
{
    public class GroupModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Avatar { get; set; }
        public virtual ICollection<PostModel> Posts { get; set; }
        public virtual ICollection<UserGroupModel> UserGroups { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
