using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            string input = "";
            Console.WriteLine("is 2 + 2 = 5");
           input = Console.ReadLine();

            if(input == "y")
            {
                Console.WriteLine("yes good job");
            }
            else
            {
                Console.WriteLine("wrong!!");
            }

            Console.WriteLine("What colour is the sky");
            input = Console.ReadLine();

            if (input == "blue")
            {
                Console.WriteLine("Correct");
            }
            else 
            { 
                Console.WriteLine("Wrong");
            }
            Console.WriteLine("Do you like dog?");
            input= Console.ReadLine();

            if (input =="y")
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("that full");
            }
            Console.ReadLine();
        }
    }
}
