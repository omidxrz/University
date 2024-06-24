using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            users.Add(new User(username: "mohammad", password: "1234"));
            bool isExists = users.Any(x => x.Username == "mohammad" && x.Password == "1234");
            Console.WriteLine(isExists);
            User user1 = new User(username: "mohammad", password: "1234");
            Console.WriteLine(user1.CheckLogin(username: "mohammad", password: "1234"));
        }
    }

    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public User(string username, string password)
        {
            Username = username;
            Password = password;

        }
        public bool CheckLogin(string username, string password)
        {
            if (username == Username && Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}