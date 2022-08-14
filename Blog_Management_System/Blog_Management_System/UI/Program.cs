using Blog_Management_System.ApplicationLogic;
using Blog_Management_System.ApplicationLogic.Services;
using System;

namespace Blog_Management_System.UI
{
    internal class Program
    {
       
         
            public static void Main(string[] args)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine();
                Console.WriteLine("                             *******************************************************                ");
                Console.WriteLine("                             *********** WELCOME TO OUR APPLICATION *******************                ");
                Console.WriteLine("                             *******************************************************                ");
                Console.Beep();
                Console.WriteLine();
                Console.WriteLine("/register");
                Console.WriteLine("/login");
                Console.WriteLine("/show-blogs-with-comments");
                Console.WriteLine("/show-filtered-blogs-with-comments");
                Console.WriteLine("/find-blog-by-code");
                Console.WriteLine("/exit");
                Console.WriteLine();
                while (true)
                {
                    Console.Write("Enter suitable command :");
                    string command = Console.ReadLine();
                    if (command == "/register")
                    {
                        Authentication.Register();
                    }
                    else if (command == "/login")
                    {
                        Authentication.Login();
                    }
                    else if (command == "/show-blogs-with-comments")
                    {
                        BlogService.ShowBlogsWithComment();
                    }
                    else if (command == "/show-filtered-blogs-with-comments")
                    {
                        BlogService.ShowFilteredBlogsWithComments();
                    }
                    else if (command == "/find-blog-by-code")
                    {
                        BlogService.FindBlogByCode();
                    }
                    else if (command == "/exit")
                    {
                        Console.WriteLine("Thanks for using our application");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Command not found ...");
                    }
                }
            }
        }

      
    }

    

