using System;

namespace displayinfo_KMcGlawn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string First = Console.ReadLine();
            Console.WriteLine("What is your surname?");
            string Last = Console.ReadLine();
            Console.WriteLine("What is your favorite number?");
            string Num = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string Animal = Console.ReadLine();

            double Number = Convert.ToDouble(Num);
                        
            string Response = $"Hello {First} {Last}, I see your favorite animal is a {Animal}.";

            Console.WriteLine(Response);

            while (Number > 10)
            {
                Console.ForegroundColor = ConsoleColor.Green; 
                Console.WriteLine($"Your favorite number is {Number}.");
                Console.ResetColor();
                break;
            }

            while (Number < 5)
            {
                Console.ForegroundColor = ConsoleColor.Red; 
                Console.WriteLine($"Your favorite number is {Number}.");
                Console.ResetColor();
                break;
            }

            while (Number >= 5 && Number <= 10)
            {
                Console.WriteLine($"Your favorite number is {Number}.");
                break;
            }
            
        }
    }
}
