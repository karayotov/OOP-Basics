using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Models
{
    public class User
    {
        private int id;
        private string username;
        private string password;
        private ICollection<int> postIds;

        public User(int id, string username, string password, IEnumerable<int> postIds)
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
            this.PostIds = new List<int>(postIds);
        }
        public ICollection<int> PostIds
        {
            get { return postIds; }
            set { postIds = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
