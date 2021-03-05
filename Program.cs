using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace bin2dec
{
    class Program
    {
        // Coded by intexception

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Number to convert: ");

            int number = Int32.Parse(Console.ReadLine());

            string converted = Convert.ToString(number, 2);

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Your binary number is: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(converted);
            Thread.Sleep(-1);
        }


    }
}

