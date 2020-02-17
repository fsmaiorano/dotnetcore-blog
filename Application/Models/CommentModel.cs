using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Models
{
    public class CommentModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual UserModel User { get; set; }
        public string Content { get; set; }
        public DateTime PublishedAt { get; private set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public CommentModel()
        {
            PublishedAt = DateTime.Now;
        }
    }
}
