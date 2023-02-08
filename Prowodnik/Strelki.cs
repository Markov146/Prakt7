using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prowodnik
{
    internal class Strelki
    {       
        
        public static int Max, Min;
        public static int position = 3;
        public Strelki(int min, int max)
        {
            
            Max = max;
            Min = min;
        }
        public int Strelka()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            do
            {
                Console.SetCursorPosition(0, position);
                Console.Write("  ");
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        position--;
                      
                        if (position < Min)
                        {
                            position = Max;
                        }
                        else if (position > Max + 1)
                        {
                            position = Min + 1;
                        }
                        Console.SetCursorPosition(0, position);
                        Console.WriteLine("->");
                        break;
                    case ConsoleKey.DownArrow:
                        position++;
                        if (position <= Min + 1)
                        {
                            position = Max;
                        }
                        else if (position > Max + 1)
                        {
                            position = Min;
                        }
                        Console.SetCursorPosition(0, position);
                        Console.WriteLine("->");
                        break;
                    case ConsoleKey.Escape:
                        return -1111;
                        break;
                }
            } while (key.Key != ConsoleKey.Enter);
             Console.Clear();
             
        }
    }
}

