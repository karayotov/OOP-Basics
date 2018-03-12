using Forum.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Forum.Data
{
    public static class DataMapper 
    {
        //DATA_PATH and CONFIG_PATH are user concatenated to specify where the file should be.

        private const string DATA_PATH = "../data/"; //It will store the directory path were we will store our data (.csv files).
        private const string CONFIG_PATH = "config.ini"; //and it stores the configuration file name
        private const string DEFAULT_CONFIG = "users=users.csv\r\ncategories=categories.csv\r\nposts=posts.csv\r\nreplies=replies.csv"; //stores the content of the configuration file.

        private static readonly Dictionary<string, string> config;

        private static void EnsureConfigFile(string configPath)
        {
            if (!File.Exists(configPath))
            {
                File.WriteAllText(configPath, DEFAULT_CONFIG);
            }
        }

        private static void EnsureFile(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
        }

        private static string[] ReadLines(string path)
        {
            EnsureFile(path);
            string[] lines = File.ReadAllLines(path);
            return lines;
        }

        private static Dictionary<string, string> LoadConfig(string configPath)
        {
            EnsureConfigFile(configPath);

            string[] contents = ReadLines(configPath);

            Dictionary<string, string> config = contents
                .Select(l => l.Split('='))
                .ToDictionary(t => t[0], t => DATA_PATH + t[1]);

            return config;
        }



        private static void WriteLines(string path, string[] lines)
        {
            File.WriteAllLines(path, lines);
        }

        static DataMapper()
        {
            Directory.CreateDirectory(DATA_PATH);
            config = LoadConfig(DATA_PATH + CONFIG_PATH);

        }
       
        public static List<Category> LoadCategories()
        {

            string[] lines = ReadLines(config["categories"]);

            List<Category> categories = new List<Category>();

            foreach (var line in lines)
            {
                var splitLine = line
                    .Split(";");

                int[] postIds = splitLine[2]
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                Category category = new Category(int.Parse(splitLine[0]), splitLine[1], postIds);
                categories.Add(category);
            }

            return categories;

        }

        public static void SaveCategories(List<Category> categories)
        {
            const string categoryFormat = "{0};{1};{2}";

            List<string> lines = new List<string>();

            foreach (var category in categories)
            {
                string line = string.Format(categoryFormat,
                    category.Id,
                    category.Name,
                    string.Join(",", category.PostIds)           //<-----------?? Posts?
                    );
                lines.Add(line);
            }
            WriteLines(config["categories"], lines.ToArray());
        }

        public static List<User> LoadUsers()
        {

            string[] lines = ReadLines(config["users"]);

            List<User> users = new List<User>();

            foreach (var line in lines)
            {
                var splitLine = line
                    .Split(";");

                var postIds = splitLine[3]
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                User user = new User(int.Parse(splitLine[0]), splitLine[1], splitLine[2], postIds);
                users.Add(user);
            }

            return users;

        }

        public static void SaveUsers(List<User> users)
        {
            const string userFormat = "{0};{1};{2};{3}";

            List<string> lines = new List<string>();

            foreach (var user in users)
            {
                string line = string.Format(userFormat,
                    user.Id,
                    user.Username,
                    user.Password,
                    string.Join(",", user.PostIds)           //<-----------?? Posts?
                    );
                lines.Add(line);
            }
            WriteLines(config["users"], lines.ToArray());
        }

        public static List<Post> LoadPosts()
        {

            var lines = ReadLines(config["posts"]);

            List<Post> posts = new List<Post>();

            foreach (var line in lines)
            {
                var splitLine = line
                    .Split(";");

                var replyIds = splitLine[5]
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                Post post = new Post(int.Parse(splitLine[0]),
                    splitLine[1],
                    splitLine[2],
                    int.Parse(splitLine[3]),
                    int.Parse(splitLine[4]),
                    replyIds);

                posts.Add(post);
            }

            return posts;
        }

        public static void SavePosts(List<Post> posts)
        {
            const string postFormat = "{0};{1};{2};{3};{4};{5}";

            List<string> lines = new List<string>();

            foreach (var post in posts)
            {
                string line = string.Format(postFormat,
                    post.Id,
                    post.Title,
                    post.Content,
                    post.CategoryId,
                    post.AuthorId,
                    string.Join(",", post.ReplyIds)           //<-----------?? Posts?
                    );
                lines.Add(line);
            }
            WriteLines(config["posts"], lines.ToArray());
        }


        public static List<Reply> LoadReplies()
        {

            string[] lines = ReadLines(config["replies"]);

            List<Reply> replies = new List<Reply>();

            foreach (var line in lines)
            {
                var splitLine = line
                    .Split(";");

                Reply reply = new Reply(int.Parse(splitLine[0]), 
                    splitLine[1], 
                    int.Parse(splitLine[2]),
                    int.Parse(splitLine[3])
                    );
                
                replies.Add(reply);
            }

            return replies;

        }

        public static void SaveReplies(List<Reply> replies)
        {
            const string userFormat = "{0};{1};{2};{3}";

            List<string> lines = new List<string>();

            foreach (var reply in replies)
            {
                string line = string.Format(userFormat,
                    reply.Id,
                    reply.Content,
                    reply.AuthorId,
                    reply.PostId           //<-----------?? Posts?
                    );
                lines.Add(line);
            }
            WriteLines(config["replies"], lines.ToArray());
        }
    }
}
