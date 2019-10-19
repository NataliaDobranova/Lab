using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Dog : Pet
    {

        public override string Say()
        {
            return "Woof";
        }

        public new string Move()
        {
            return "Run";
        }
    }
   
}
