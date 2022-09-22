using System;

namespace Lab1_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            int top = Console.CursorTop + 1;
            int y = top;
            do
            {
                Console.WriteLine("Choose your destiny:");

                Console.WriteLine("Get square");
                Console.WriteLine("Get perimeter");
                Console.WriteLine("Get volume of piramid");
                Console.WriteLine("Exit");

                int down = Console.CursorTop;

                Console.CursorSize = 100;
                Console.CursorTop = top;

                ConsoleKey key;
                while ((key = Console.ReadKey(true).Key) != ConsoleKey.Enter)
                {
                    if (key == ConsoleKey.UpArrow)
                    {
                        if (y > top)
                        {
                            y--;
                            Console.CursorTop = y;
                        }
                    }
                    else if (key == ConsoleKey.DownArrow)
                    {
                        if (y < down - 1)
                        {
                            y++;
                            Console.CursorTop = y;
                        }
                    }
                }

                Console.CursorTop = down;

                if (y == top)
                {
                    Console.Clear();
                    Console.WriteLine("Please, enter sides a and b");
                    TRTriangle triangle = new TRTriangle(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    Console.Clear();
                    Console.WriteLine(triangle.Get_Square());
                    Console.ReadKey();
                    Console.Clear();
                }

                else if (y == top + 1)
                {
                    Console.Clear();
                    Console.WriteLine("Please, enter sides a and b");
                    TRTriangle triangle = new TRTriangle(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    Console.Clear();
                    Console.WriteLine(triangle.Get_Perimeter());
                    Console.ReadKey();
                    Console.Clear();
                }

                else if (y == top + 2)
                {
                    Console.Clear();
                    Console.WriteLine("Please, enter sides a and b and height");
                    TRPiramid piramid = new TRPiramid(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    Console.Clear();
                    Console.WriteLine(piramid.Get_Volume());
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (y == top + 3)
                    Console.Clear();

            }
            while (y != top + 3);
        }


    }
}
