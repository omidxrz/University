using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> usernames = new List<string>{"user1", "user2", "user3"};
        List<string> passwords = new List<string>{"pass1", "pass2", "pass3"};
        List<int> attemptsLeft = new List<int>{3, 3, 3};

        bool loggedIn = false;

        while (!loggedIn)
        {
            Console.Write("[+] Enter username: ");
            string username = Console.ReadLine();

            Console.Write("[+] Enter password: ");
            string password = Console.ReadLine();

            // Check if username and password are correct
            int index = usernames.IndexOf(username);
            if (index == -1){
                Console.WriteLine("\n[-] Username not found!\n");
                continue;
            }
            
            if (attemptsLeft[index] <= 0)
            {
                Console.WriteLine($"\n[-] Your account {username} is blocked!!!!\n");
                continue;
            }

            if (index != -1 && passwords[index] == password)
            {
                loggedIn = true;
                Console.WriteLine("\nWelcome, " + username + "!\n");
            }
            else
            {
                Console.WriteLine("\n[-] Invalid password!\n");
                // int userIndex = usernames.IndexOf(username);
                if (index != -1)
                {
                    attemptsLeft[index]--;
                    Console.WriteLine($"[*] You have {attemptsLeft[index]} attempts left for {username} !!\n");  
                }else{
                    Console.WriteLine("qwe");
                }
            }
        }
    }
}
