using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short_Story_C1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, age, year, animal;

            Console.Title = ("STORY MAKER");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WindowWidth = 160;
            Console.WindowHeight = 50;

            Console.WriteLine("-- Welcome! to Short Story Maker --\n");

            Console.Write("\nEnter random person name: ");
            name = Console.ReadLine();

            Console.Write("\nEnter age: ");
            age = Console.ReadLine();

            Console.Write("\nEnter animal name: ");
            animal = Console.ReadLine();

            Console.Write("\nEnter a year: ");
            year = Console.ReadLine();

            Console.WriteLine($"\n\aOnce upon a time person named {name} in a year {year}, was attacked by a {animal} and died at his age {age}. \n\n - press any key to exit.- ");

            Console.ReadLine();



        }
    }
}