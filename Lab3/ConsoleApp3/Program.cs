using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What figure do you want?");
            Console.WriteLine("0 - Rectangle");
            Console.WriteLine("1 - Rhomb");
            Console.WriteLine("2 - Triangle");
            Console.WriteLine("3 - Trapeze");
            Console.WriteLine("4 - Polygon");
            Console.WriteLine("5 - All figures");
            Console.WriteLine("6 - Exit");

            int m;
            int p;

            Figures[] figures = new Figures[5];

            figures[0] = new Rectangle();
            figures[1] = new Rhomb();
            figures[2] = new Triangle();
            figures[3] = new Trapeze();
            figures[4] = new Polygon();


            do
            {
                var n = Console.ReadLine();
                m = Convert.ToInt32(n);

                if (m <= 4)
                {
                    Console.WriteLine("What color do you want?");
                    Console.WriteLine("0 - Red");
                    Console.WriteLine("1 - Blue");
                    Console.WriteLine("2 - Green");
                    var l = Console.ReadLine();
                    p = Convert.ToInt32(l);
                    switch (p)
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Red;
                            figures[m].colour = "red";
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            figures[m].colour = "blue";
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Green;
                            figures[m].colour = "green";
                            break;
                        default:
                            figures[m].colour = "white";
                            Console.WriteLine("Error!!! It will be White");
                            break;

                    }
                    figures[m].Draw();
                    Console.WriteLine(figures[m].colour);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("What figure do you want?");
                }
                else if (m == 5)
                {
                    foreach (Figures fig in figures)
                    {
                        fig.colour = "white";
                        fig.Draw();
                        Console.WriteLine(fig.colour);
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("What figure do you want?");
                }
                else if (m == 6)
                {
                    Console.WriteLine("Good bye!");
                }
                else
                {
                    Console.WriteLine("Error!");
                    m = 6;

                }


            } while (m != 6);
        }
    }
}
