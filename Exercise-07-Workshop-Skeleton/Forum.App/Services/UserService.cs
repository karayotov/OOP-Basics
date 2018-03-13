using System;
using Forum.App.Controllers;
using System.Linq;
using Forum.Data;
using Forum.Models;
using System.Collections.Generic;
using static Forum.App.Controllers.SignUpController;

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
                User user = new User(userId, username, password, new List<int>());
                forumData.Users.Add(user);
                forumData.SaveChanges();

                return SignUpStatus.Success;
            }

            return SignUpStatus.UsernameTakenError;
        }

        internal static User GetUser(int userId)
        {
            ForumData forumData = new ForumData();
            User user = forumData.Users.Find(u => u.Id == userId);

            return user;
        }
        //Having this, implement an overload to this method that takes string username as a parameter.

        public static User GetUser(string username, ForumData forumData)
        {

            var user = forumData.Users.Single(u => u.Username == username);
            return user;
        }


    }
}