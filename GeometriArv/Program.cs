using System;
using System.Collections.Generic;

namespace GeometriArv
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figur> figurs = new List<Figur>();

            figurs.Add(new Parallelogram(3, 5, 20, "Parallelogram"));
            figurs.Add(new Trapezen(10,9,8,9, "Trapezen"));
            figurs.Add(new Trekant(8,7,9, "Trekant"));


            foreach (Figur figur in figurs)
            {
                figur.SetAreal();
                figur.SetOmkreds();

                Console.WriteLine($"Name: {figur.Name}");
                Console.WriteLine($"Areal: {figur.Areal}");
                Console.WriteLine($"Omkreds: {figur.Omkreds}");
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
