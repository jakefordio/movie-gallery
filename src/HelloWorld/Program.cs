using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get name and age.
            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            string userAge = Console.ReadLine();

            //Change echo color, just for fun.
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;

            //Echo to the console.
            Console.WriteLine("Hello {0}, you are {1} years old!", userName, userAge);

            //Restore color.
            Console.ForegroundColor = prevColor;

            Console.ReadLine();
        }
    }
}
