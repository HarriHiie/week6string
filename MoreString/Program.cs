using System;

namespace MoreString
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("sisesta oma eesnimi");
            string userfirstname = Console.ReadLine();

            Console.WriteLine("Sisesta oma perekonnanimi");
            string userlastname = Console.ReadLine();

            Console.WriteLine($"Tere, {userfirstname[0]}. {userlastname[0]}.!");





        }
    }
}
