using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Project
    {
        public int NumberOfWalls;
        public int NumberOfWindows;
        public int NumberOfDoors;
        public bool IsBasementNeeded;
        public bool IsRoofNeeded;


       public Project (int NumberOfWalls, int NumberOfWindows, int NumberOfDoors,
           bool IsBasementNeeded = true, bool IsRoofNeeded = true)
        {  
            this.NumberOfWalls = NumberOfWalls;
            this.NumberOfWindows = NumberOfWindows;
            this.NumberOfDoors = NumberOfDoors;
            this.IsBasementNeeded = IsBasementNeeded;
            this.IsRoofNeeded = IsRoofNeeded;
        }

       
    }
}
