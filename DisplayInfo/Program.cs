﻿using System;

namespace DisplayInfo
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



            Console.WriteLine($"Hello {First} {Last}, I see your favorite animal is a {Animal}.");
            
            // Get first and last name from user input
            // Get their favorite number
            // Get their favorite animal

            // Once you have gotten all their info and stored it,
            // display it back to them.

            // If their favorite number is greater than 10, display it in green.
            // If their favorite number is less than 5, display it in red.
        }
    }
}
