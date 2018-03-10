using System;

using System.Linq;
using Forum.Data;
namespace Forum.App.Services
{
    
    public static class UserService
    {
        private static int MIN_LENGTH = 3;

        public static bool TryLogInUser(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            ForumData forumData = new ForumData();

            bool userExist = forumData.Users.Any(u => u.Username == username && u.Password == password);
            return userExist;     
        }

        public static SignUpStatus TrySignUpUser(string username, string password)
        {
            bool validUsername = !string.IsNullOrWhiteSpace(username) && username.Length > MIN_LENGTH;
            bool validPassword = !string.IsNullOrWhiteSpace(password) && password.Length > MIN_LENGTH;

            if (!validPassword || !validUsername)
            {
                return SignUpStatus.DetailsError;
            }

            ForumData forumData = new ForumData();

            bool userAlreadyExist = forumData.Users.Any(u => u.Username == username);
            if (!userAlreadyExist)
            {
                int userId = forumData.Users.LastOrDefault()?.Id + 1 ?? 1;
                User user = new User(userId, username, password);
                forumData.Users.Add(user);
                forumData.SaveChanges();

                return SignUpStatus.Success;
            }

            return SignUpStatus.UsernameTakenError;
        }


    }
}