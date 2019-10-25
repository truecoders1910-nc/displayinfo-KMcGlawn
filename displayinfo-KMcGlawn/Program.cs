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

            string Response = $"Hello {First} {Last}, I see your favorite animal is a {Animal} and your favorite number is {Num}.";
            Console.WriteLine(Response);
        }
    }
}
