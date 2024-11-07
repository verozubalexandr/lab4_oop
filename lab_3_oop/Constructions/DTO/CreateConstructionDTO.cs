﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.Constructions.DTO
{
    internal class CreateConstructionDTO
    {

        public float Height { get; set; }
        public float Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }
        public Models.BuildMaterialEnum BuildMaterial { get; set; }
    }
}
