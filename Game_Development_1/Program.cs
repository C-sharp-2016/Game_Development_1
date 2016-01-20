using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Development_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variable
            string name;

            // Ask to enter name as "string"
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();

            // Print name entered
            Console.WriteLine("Your name is " + name);
            Console.ReadLine();
        }
    }
}
