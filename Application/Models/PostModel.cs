using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Models
{
    public class PostModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string ContentUrl { get; set; }
        public int UserId { get; set; }
        public virtual UserModel User { get; set; }
        public int GroupId { get; set; }
        public virtual GroupModel Group { get; set; }
        public DateTime PublishedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
