using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {

            int m;

            Figures[] figures = new Figures[6];

            figures[0] = new Rectangle();
            figures[1] = new Rhomb();
            figures[2] = new Triangle();
            figures[3] = new Trapeze();
            figures[4] = new Polygon();

            do
            {
                Console.WriteLine("Which figure do you want?");
                Console.WriteLine("0 - Rectangle");
                Console.WriteLine("1 - Rhomb");
                Console.WriteLine("2 - Triangle");
                Console.WriteLine("3 - Trapeze");
                Console.WriteLine("4 - Polygon");
                Console.WriteLine("5 - Exit");

                var n = Console.ReadLine();
                m = Convert.ToInt32(n);
               switch (m)
                {
                    case 0:
                        figures[0].Draw();
                        break;
                    case 1:
                        figures[1].Draw();
                        break;
                    case 2:
                        figures[2].Draw();
                        break;
                    case 3:
                        figures[3].Draw();
                        break;
                    case 4:
                        figures[4].Draw();
                        break;
                   
                       

                }
            } while (m != 5);
            
           



        }




    }
}
