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
            int age;

            // Ask to enter name as "string"
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();

            // Ask to enter age as "string"
            Console.WriteLine("Please enter your age");
            age = int.Parse(Console.ReadLine());
             
            // Validate age if pass the requirements
            if (age < 18)
            {
                Console.WriteLine("You are too young to play"); 
            }
            else
            {
                Console.WriteLine("You are old enough to play");
            } 

            // Calling a function
            DoStuffWithAge();

            // Press any key to exit
            Console.ReadLine();
        }


        /**
        * function without parameter
        */
        static void DoStuffWithAge ()
        {
            Console.WriteLine("Outpustuff from function");
        }
    }
}
