using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab_3.Constructions;

namespace lab_3.IndustrialBuildings
{
    internal class IndustrialHall : Construction
    {
        public IndustrialHall() : base(29.7f, 45.4f, 5, 124, Constructions.Models.BuildMaterialEnum.Brick)
        {
            
        }
    }
}
