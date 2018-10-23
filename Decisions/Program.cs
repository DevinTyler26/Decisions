using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Devin's Big Giveaway!");
            Console.Write("Choose a door: 1, 2, or 3: ");
            string userValue = Console.ReadLine();
            string message;
            switch (userValue)
            {
                case "1":
                    message = "You win a car!";
                    break;
                case "2":
                    message = "You win a boat!";
                    break;
                case "3":
                    message = "You win a house!";
                    break;
                default:
                    message = "Sorry we dont understand";
                    break;
            }
            Console.WriteLine(message);
        }
    }
}
