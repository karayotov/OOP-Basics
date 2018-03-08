using Forum.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Forum.Data
{
    public class DataMapper 
    {
        //DATA_PATH and CONFIG_PATH are user concatenated to specify where the file should be.

        private const string DATA_PATH = "../data/"; //It will store the directory path were we will store our data (.csv files).
        private const string CONFIG_PATH = "config.ini"; //and it stores the configuration file name
        private const string DEFAULT_CONFIG = "users=users.csv\r\ncategories=categories.csv\r\nposts=posts.csv\r\nreplies=replies.csv"; //stores the content of the configuration file.

        private static Dictionary<string, string> config;

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
        private static Dictionary<string, string> LoadConfig(string configPath)
        {
            EnsureConfigFile(configPath);

            var contents = ReadLines(configPath);

            var config = contents
                .Select(l => l.Split('='))
                .ToDictionary(t => t[0], t => DATA_PATH + t[1]);

            return config;
        }

        private static string[] ReadLines(string path)
        {
            EnsureFile(path);
            var lines = File.ReadAllLines(path);
            return lines;
        }

        public static void WriteLines(string path, string[] lines)
        {
            File.WriteAllLines(path, lines);
        }

        public DataMapper()
        {
            Directory.CreateDirectory(DATA_PATH);
            config = LoadConfig(DATA_PATH + CONFIG_PATH);
        }

        public static List<Category> LoadCategoryes()
        {
            List<Category> categories = new List<Category>();
            string[] dataLines = ReadLines(config["categories"]);

            foreach (var line in dataLines)
            {
                string[] args = line
                    .Split(";", StringSplitOptions.RemoveEmptyEntries);
                int id = int.Parse(args[0]);
                string name = args[1];
                int[] postIds = args[2]
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                Category category = new Category(id, name, postIds);
                categories.Add(category);
            }

            return categories;

        }

        public static void SaveCategories(List<Category> categories)
        {
            List<string> lines = new List<string>();

            foreach (var category in categories)
            {
                const string categoryFormat = "{0}; {1}; {2}";
                string line = string.Format(categoryFormat,
                    category.Id,
                    category.Name,
                    string.Join(", ", category.PostIds)           //<-----------?? Posts?
                    );
                lines.Add(line);
            }
            WriteLines(config["categories"], lines.ToArray());
        }

        public static List<User> LoadUsers()
        {
            List<User> users = new List<User>();
            string[] dataLines = ReadLines(config["users"]);

            foreach (var line in dataLines)
            {
                string[] args = line
                    .Split(";", StringSplitOptions.RemoveEmptyEntries);
                int id = int.Parse(args[0]);
                string username = args[1];
                string password = args[2];
                int[] postIds = args[3]
                    .Split(",", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                User user = new User(id, username, password, postIds);
                users.Add(user);
            }
            return users;
        }

        public static void SaveUsers(List<User> users)
        {
            List<string> lines = new List<string>();

            foreach (var user in users)
            {
                const string userFormat = "{0}, {1}, {2}, {3}";
                string line = string.Format(userFormat,
                    user.Id,
                    user.Username,
                    user.Password,
                    string.Join(", ", user.PostIds)
                    );
                lines.Add(line);
            }
            WriteLines(config["users"], lines.ToArray());
        }

        public static List<Post> LoadPosts()
        {
            List<Post> posts = new List<Post>();
            string[] dataLines = ReadLines(config["posts"]);

            foreach (var line in dataLines)
            {
                string[] args = line.Split(";", StringSplitOptions.RemoveEmptyEntries);
                int id = int.Parse(args[0]);
                string title = args[1];
                string content = args[2];
                int categoryId = int.Parse(args[3]);
                int authorId = int.Parse(args[4]);
                int[] postsId = args[5].Split(",", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                Post post = new Post(id, title, content, categoryId, authorId, postsId);
                posts.Add(post);
            }

            return posts;
        }

        public static void SavePosts(List<Post> posts)
        {
            List<string> lines = new List<string>();

            foreach (var post in posts)
            {
                const string postsFormat = "{0}; {1}; {2}; {3}; {4}";
                string line = string.Format(postsFormat,
                    post.Id,
                    post.Title,
                    post.Content,
                    post.CategoryId,
                    string.Join(", ", post.ReplyIds)
                    );
                lines.Add(line);
            }

        }

        public static List<Reply> LoadReplies()
        {
            List<Reply> replies = new List<Reply>();
            string[] datalines = ReadLines(config["replies"]);

            foreach (var line in datalines)
            {
                string[] args = line.Split(";", StringSplitOptions.RemoveEmptyEntries);

                int id = int.Parse(args[0]);
                string content = args[1];
                int authorId = int.Parse(args[2]);
                int[] postIds = args[3]
                    .Split(",", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                Reply reply = new Reply(id, content, authorId, postIds);
                replies.Add(reply);
            }
            return replies;
        }

        public static void SaveReplies(List<Reply> replies)
        {
            List<string> lines = new List<string>();

            foreach (var reply in replies)
            {
                const string repliesFormat = "{0}, {1}, {2}, {3}";
                string line = string.Format(repliesFormat,
                    reply.Id,
                    reply.Content,
                    reply.AuthorId,
                    string.Join(", ", reply.PostIds)
                    );

                lines.Add(line);
            }

            WriteLines(config["replies"], lines.ToArray());
        }
    }
}
