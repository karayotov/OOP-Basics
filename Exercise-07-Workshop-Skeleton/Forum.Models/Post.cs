using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Models
{
    public class Post
    {
        private int id;
        private string title;
        private string content;
        private int categoryId;
        private int authorId;
        private ICollection<int> replyIds;

        public Post(int id, string title, string content, int categoryid, int authorId, ICollection<int> replyIds)
        {
            this.Id = id;
            this.Title = title;
            this.Content = content;
            this.CategoryId = categoryid;
            this.AuthorId = authorId;
            this.ReplyIds = new List<int>(replyIds);
        }

        public ICollection<int> ReplyIds { get; set; }

        public int AuthorId { get; set; }

        public int CategoryId { get; set; }

        public string Content { get; set; }

        public string Title { get; set; }

        public int Id { get; set; }

    }
}
