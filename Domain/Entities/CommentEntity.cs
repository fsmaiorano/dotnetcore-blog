using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class CommentEntity: BaseEntity
    {
        public int UserId { get; set; }
        public virtual UserEntity User { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public CommentEntity()
        {
            CreatedAt = DateTime.Now;
        }

        public void SetUser(UserEntity user)
        {
            if (user != null)
                User = user;
        }
    }
}
