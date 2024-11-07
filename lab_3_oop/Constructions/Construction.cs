using lab_3.Constructions.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.Constructions
{
    internal class Construction
    {
        private Models.BuildMaterialEnum _buildMaterial;

        public Construction()
        {
            Height = 0;
            Width = 0;
            Entrances = 0;
            HumanCapacity = 1;
            BuildMaterial = Models.BuildMaterialEnum.Brick;
        }

        public Construction(CreateConstructionDTO construction)
        {
            Height = construction.Height;
            Width = construction.Width;
            Entrances = construction.Entrances;
            HumanCapacity = construction.HumanCapacity;
            BuildMaterial = construction.BuildMaterial;
        }


        public Construction(float height, float width, int entrances, int humanCapacity, Models.BuildMaterialEnum buildMaterial)
        {
            Height = height;
            Width = width;
            Entrances = entrances;
            HumanCapacity = humanCapacity;
            BuildMaterial = buildMaterial;
        }



        public float Height { get; set; }
        public float Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }

        //public string BuildMaterial
        //{
        //    get => _buildMaterial;
        //    set
        //    {
        //        if (string.IsNullOrWhiteSpace(value))
        //        {
        //            throw new ArgumentNullException(nameof(value), "Build material cannot be empty.");
        //        }
        //        _buildMaterial = value;
        //    }
        //}

        public Models.BuildMaterialEnum BuildMaterial
        {
            get
            {
                return _buildMaterial;
            }

            set
            {
                //if (value == null)
                //{
                //    throw new ArgumentNullException(nameof(value), "Build material cannot be empty.");
                //}
                _buildMaterial = value;
            }
        }

        public float getSquareCost()
        {
            if (BuildMaterial == Models.BuildMaterialEnum.Concrete)
            {
                return 0.87f * Height * Width * 0.9f;
            }
            if (BuildMaterial == Models.BuildMaterialEnum.Brick)
            {
                return 0.8f * Height * Width * 0.9f;
            }
            if (BuildMaterial == Models.BuildMaterialEnum.Wood)
            {
                return 0.78f * Height * Width * 0.9f;
            }

            return 0.78f * Height * Width * 0.9f;
        }

    }

}