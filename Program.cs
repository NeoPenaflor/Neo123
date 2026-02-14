using System;
namespace accountmanage
{
internal class Program
{
static void Main(string[] args)
        {
            Console.WriteLine("");

            string user = "Neo";
            string pass = "Neo12345";

            Console.WriteLine("Enter your username: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            string passInput = Console.ReadLine();

            if (userInput == user && passInput == pass)
            {
            Console.WriteLine("Login Succesful Congrats!");
            }
            else
            {
            Console.WriteLine("Wrong credentials");
            }
        }
    }
}
