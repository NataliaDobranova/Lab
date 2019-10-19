using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Polygon : Figures
    {
        public Polygon()
        {
            colour = "white";
        }

        public override void Draw()
        {
            Console.WriteLine("      ******");
            Console.WriteLine("     *      *");
            Console.WriteLine("    *        *");
            Console.WriteLine("   *          *");
            Console.WriteLine("    *        *");
            Console.WriteLine("     *      *");
            Console.WriteLine("      ******");
        }

    }
}
