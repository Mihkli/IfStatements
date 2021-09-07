using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub sisestada numbrit'
            //programm kontrollib numbrit
            //kui number on positiivne, konsool kuvab "number on positiivne"
            //kui number on negatiivne, konsool kuvab "number on negatiivene"
            //kui sisestad number 0, siis konsool kuvab "null"
            //NB! Int32.Parse asemel kasutame Convert.ToInt32(Console.Readline());

            Console.WriteLine("Palun sisestada numbrit");
            int Positiivne = Convert.ToInt32(Console.ReadLine());
            int Negatiivne = - + Positiivne;

            if (Positiivne > Negatiivne)
            {
                Console.WriteLine("Number on positiivne");
            }
            else if (Positiivne < Negatiivne)
            {
                Console.WriteLine("Number on negatiivne");
            }
            else
            {
                Console.WriteLine("Null");
            }
        }
    }
}
