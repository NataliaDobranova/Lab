using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class TeamLeader
    {
        private Project Project { get; set; }
        private Worker Worker { get; set; }
        private House House { get; set; }

        public TeamLeader(Project project, Worker worker, House house)
        {
            Project = project;
            Worker = worker;
            House = house;

        }



        public bool IsBasement(Project project, House house)
        {
            if (project.IsBasementNeeded && !house.Parts.OfType<Basement>().Any())
            {
                return true;
            }
            else return false;
        }

        public bool IsWalls(Project project, House house)
        {
            if (project.IsBasementNeeded && house.Parts.OfType<Basement>().Any()
                 && (house.Parts.OfType<Walls>().Count() < project.NumberOfWalls))
            {
                return true;
            }
            else if (project.IsBasementNeeded == false
              && (house.Parts.OfType<Walls>().Count() < project.NumberOfWalls))
            {
                return true;
            }
            else return false;
        }

        public bool IsDoors(Project project, House house)
        {
            {
                if ((house.Parts.OfType<Walls>().Count() == project.NumberOfWalls)
                      && (house.Parts.OfType<Door>().Count() < project.NumberOfDoors))
                {
                    return true;
                }
                else return false;
            }
        }

        public bool IsWindows(Project project, House house)
        {
            {
                if ((house.Parts.OfType<Walls>().Count() == project.NumberOfWalls)
                      && (house.Parts.OfType<Window>().Count() < project.NumberOfWindows))
                {
                    return true;
                }
                else return false;
            }
        }

        public bool IsRoof(Project project, House house)
        {
            {
                if ((house.Parts.OfType<Walls>().Count() == project.NumberOfWalls)
                      && !house.Parts.OfType<Roof>().Any())
                {
                    return true;
                }
                else return false;
            }
        }

        public bool IsComplete (Project project, House house)
        { if ((project.IsBasementNeeded && house.Parts.OfType<Basement>().Any()
                 && 

        }


        public House BuildHouse(Project project, House house)
        { while ()
            {



            }

        }



    }




}
