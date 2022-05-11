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
            Console.ReadLine();
        }
    }
}
