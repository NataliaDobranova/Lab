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
            Worker worker = new Worker();
            Project project = new Project(4, 4, 1);
            var house = new House();
            TeamLeader leader = new TeamLeader(project, worker, house);

        }
    }
}
