using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Name;

namespace CS_131_Projects
{
    public class Program
    {

        static void Main()
        {
           
            string response = "";        
            while (response!= "4")
            {
                List<User> printList = new List<User>();
                Console.WriteLine("1. Luis");
                Console.WriteLine("2. Amanda");
                Console.WriteLine("3. User");
                Console.WriteLine("4. Comment");

                Console.WriteLine("");
                Console.WriteLine("Please Select A Value");

                response = Console.ReadLine();
                switch (response!= "4")
                {
                    case "1":
                        User name1 = new User();
                        name1.UserName = "Luis";
                        Console.WriteLine("The user your created is: " + name1.UserName);
                        break;

                    case "2":
                        User name2 = new User();
                        name2.UserName = "Amanda";
                        name2.Comment = "You are the best";
                        Console.WriteLine("The user comment is: " + name2.Comment);
                        break;

                    case "3":
                        printList.Add(new User { UserName = "List of User" });
                        break;

                    case "4":
                        printList.Add(new User { Comment = "List of Comments" });
                        break;

                }

                Console.WriteLine("your response is: " + response);
                foreach (var User in printList)
                {
                    Console.WriteLine(User);
                }
            }

        }
    }
}


