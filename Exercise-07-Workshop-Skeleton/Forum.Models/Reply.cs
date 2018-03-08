using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Models
{
    public class Reply
    {
        private int id;
        private string content;
        private int authorId;
        private ICollection<int> postIds;

        public Reply(int id, string content, int authorId, IEnumerable<int> postIds)
        {
            this.Id = id;
            this.Content = content;
            this.AuthorId = authorId;
            this.PostIds = new List<int>(postIds);
        }

        public ICollection<int> PostIds
        {
            get { return postIds; }
            set { postIds = value; }
        }

        public int AuthorId
        {
            get { return authorId; }
            set { authorId = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
