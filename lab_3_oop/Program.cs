using System;
using System.Reflection;
using lab_3.Constructions;
using lab_3.Constructions.DTO;
using lab_3.IndustrialBuildings;
using lab_3.ResidentalBuildings;

class Program
{
    static void Main()
    {
        var construction = new Construction(29.7f, 45.4f, 5, 124, lab_3.Constructions.Models.BuildMaterialEnum.Brick);
        var construction2 = new Construction();
        var construction3 = new Construction(new CreateConstructionDTO()
        {
            Height = 0,
            Width = 0,
            Entrances = 0,
            HumanCapacity = 1,
            BuildMaterial = (lab_3.Constructions.Models.BuildMaterialEnum)0
        });

        Console.WriteLine("first obj:");
        Console.WriteLine("Height: " + construction.Height);
        Console.WriteLine("Width: " + construction.Width);
        Console.WriteLine("Entrances: " + construction.Entrances);
        Console.WriteLine("Human Capacity: " + construction.HumanCapacity);
        Console.WriteLine("Build Material: " + construction.BuildMaterial);

        Console.WriteLine("second obj:");
        Console.WriteLine("Height: " + construction2.Height);
        Console.WriteLine("Width: " + construction2.Width);
        Console.WriteLine("Entrances: " + construction2.Entrances);
        Console.WriteLine("Human Capacity: " + construction2.HumanCapacity);
        Console.WriteLine(construction.getSquareCost());

        var residental = new ResidentalBuilding();
        var hall = new IndustrialHall();

        Console.WriteLine("///////////////");
        Console.WriteLine(residental.Height);
        Console.WriteLine(hall.Entrances);
        //try
        //{
        //    construction.BuildMaterial = "";
        //}
        //catch (ArgumentNullException ex)
        //{
        //    Console.WriteLine("Exception caught: " + ex.Message);
        //}
    }
}