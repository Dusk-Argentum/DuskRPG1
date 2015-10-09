using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuskRPG1
{
    class Program
    {
        public static void PrintTextLine(String text, params Object[] param)
        {
            PrintText(text + "\n", param);
        }

        public static void PrintText (String text, params Object[] param)
        {
            for (int i = 0; i < param.Length; i++)
            {
                text = text.Replace("{" + i + "}", param[i].ToString());
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '|')
                {
                    int bg = Convert.ToInt32(text[i+1].ToString());
                    int fg = Convert.ToInt32(text[i+2].ToString(), 16);

                    Console.ForegroundColor = (ConsoleColor)fg;
                    Console.BackgroundColor = (ConsoleColor)bg;

                    i += 2;
                }
                else
                {
                    Console.Write(text[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            ///Introduce the player to the game and ask their name.
            /// 
            PrintTextLine("|02-|0a=|02-|0a=|02-|0a=|02-|0a=|02-|0a=|02-|0a=|02-|0a=|02-|0a=|02-|0a=|02-|0a=|02-|0a=|02-|0a=|02-|0a=|02-|0a=|02-|0a=|02-|0a=|02-|0a=|02-|0a=|02-|0a=|02-|0a=|02-|0a=|02-|0a=|02-|0a=|02-|0a=|07\n");

            PrintTextLine("Hello! Welcome to DuskRPG, a text-based RPG in its very early stages!");
            PrintText("Welcome, new player! Please enter your name: ");
            string name = Console.ReadLine();

            PrintTextLine("Ah, so your name is |09{0}|07?", name);
            //Console.ReadKey("y", true);
            //bool y = false;
            //string y1String = Console.ReadKey(y);
            //Console.ReadKey("n", true);
            PrintTextLine("Normally, you'd be able to type 'yes' or 'no' here, but unfortunately, I am not skilled enough to do this. Sorry.");

            PrintTextLine("In any event, welcome, {0}! There isn't much to do yet.", name);
            ///Due to me not knowing how to allow users to input and read different options, the remaining bits will be added at a future date.
        }
    }
}
