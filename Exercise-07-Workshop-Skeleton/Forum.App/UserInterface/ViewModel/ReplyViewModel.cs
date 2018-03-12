using Forum.App.Services;
using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Forum.App.UserInterface.ViewModel
{
    public class ReplyViewModel
    {
        private const int LINE_LENGTH = 37;

        public string Author { get; set; }

        public IList<string> Content { get; set; }

        public ReplyViewModel() { }

        public ReplyViewModel(Reply reply)
        {
            this.Author = UserService.GetUser(reply.AuthorId).Username;
            this.Content = GetLines(reply.Content);
        }

        public IList<string> GetLines(string content)
        {
            char[] contentChars = content.ToCharArray();
            IList<string> lines = new List<string>();

            for (int i = 0; i < content.Length; i += LINE_LENGTH)
            {
                char[] row = contentChars.Skip(i).Take(LINE_LENGTH).ToArray();
                string rowString = String.Join("", row);
                lines.Add(rowString);
            }

            return lines;
        }


    }
}
