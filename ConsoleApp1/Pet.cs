using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Pet
    {
        public string name;
        public abstract string Say();
        public virtual string Move()
        {
            return "Walk";
        }

     }
}
