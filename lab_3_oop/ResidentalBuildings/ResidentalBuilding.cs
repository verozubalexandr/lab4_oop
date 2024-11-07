using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab_3.Constructions;

namespace lab_3.ResidentalBuildings
{
    internal class ResidentalBuilding : Construction
    {

        public ResidentalBuilding() { }
        public ResidentalBuilding(int numberOfFloors) 
        { 
            NumberOfFloors = numberOfFloors;
        }

        public int NumberOfFloors { get; set; } 
    }
}
