using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuskRPG1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Introduce the player to the game and ask their name.
            Console.WriteLine("Hello! Welcome to DuskRPG, a text-based RPG in its very early stages!");
            Console.Write("Welcome, new player! Please enter your name. ");
            string nameAsString = Console.ReadLine();

            Console.Write("Ah, so your name is {1}?", name);

            //Console.ReadKey("y", true);
            //bool y = false;
            //string y1String = Console.ReadKey(y);
            //Console.ReadKey("n", true);

            Console.WriteLine("Normally, you'd be able to type 'yes' or 'no' here, but unfortunately, I am not skilled enough to do this. Sorry.");

            Console.WriteLine("In any event, welcome, {1}! There isn't much to do yet.");
            ///Due to me not knowing how to allow users to input and read different options, the remaining bits will be added at a future date.
        }
    }
}
