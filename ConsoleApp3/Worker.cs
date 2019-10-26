using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Worker : IWorker
    {

        public void BuildBasement(House house)
        {
            house.Parts.Add(new Basement());
        }

        public void BuildWalls(House house)
        {
            house.Parts.Add(new Walls());
        }
        public void BuildDoors(House house)
        {
            house.Parts.Add(new Door());
        }

        public void BuildWindows(House house)
        {
            house.Parts.Add(new Window());
        }
        public void BuildRoof(House house)
        {
            house.Parts.Add(new Roof());
        }

    }
}
