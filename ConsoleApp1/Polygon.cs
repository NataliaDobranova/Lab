using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Polygon : Figures
    {
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
