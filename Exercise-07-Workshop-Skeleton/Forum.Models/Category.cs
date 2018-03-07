using System.Collections.Generic;

namespace Forum.Models
{
    public class Category
    {
        private int id;
        private string name;
        private ICollection<int> postIds;

        public Category(int id, string name, IEnumerable<int> postIds)
        {
            this.Id = id;
            this.Name = name;
            this.PostIds = new List<int>(postIds);
        }

        public ICollection<int> PostIds
        {
            get { return postIds; }
            set { postIds = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
