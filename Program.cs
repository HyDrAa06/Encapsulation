using Class_Box_Data;
using System;

namespace ClassBoxData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Length:");
            double l = double.Parse(Console.ReadLine());

            Console.WriteLine("Width:");
            double w = double.Parse(Console.ReadLine());

            Console.WriteLine("Height:");
            double h = double.Parse(Console.ReadLine());

            Box box = new Box(1, 1, 1);

            try
            {
                box = new Box(l, w, h);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            

            Console.WriteLine(box.SurfaceArea());
            Console.WriteLine(box.LateralSurfaceArea());
            Console.WriteLine(box.Volume());
        }
    }
}