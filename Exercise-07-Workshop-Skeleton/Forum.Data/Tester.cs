using Forum.Models;
using System;
using System.Collections.Generic;

namespace Forum.Data
{
    class Tester
    {
        static void Main(string[] args)
        {
            ICollection<int> ids = new List<int>
            {
                { 213}, { 12331321}, { 12321}, { 1323}, { 31}
            };

            ForumData fd = new ForumData();
            fd.Users.Add(new User(1232321, "Pesho", "2345432", ids));

            fd.SaveChanges();

        }
    }
}
