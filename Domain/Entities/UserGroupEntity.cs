using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class UserGroupEntity : BaseEntity
    {
        public bool IsAdministrator { get; set; }
        public int UserId { get; set; }
        public virtual UserEntity User { get; set; }
        public int GroupId { get; set; }
        public virtual GroupEntity Group { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
