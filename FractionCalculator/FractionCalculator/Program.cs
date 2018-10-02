    using System;

namespace FractionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the fraction calculator.");
            Console.WriteLine("This calculator takes two values seperated by an operator");
            Console.WriteLine("Values that are acceptible should be framed like: 1/2 * 3_3/4");
            Console.WriteLine("Type quit or exit to close the application");
            string input = Console.ReadLine().ToLower();
            while(input != "quit" || input != "exit")
            {
                Parser.Parse(input);

                input = Console.ReadLine();
            }
        }
    }
}
