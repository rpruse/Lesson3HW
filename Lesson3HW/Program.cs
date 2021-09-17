using System;

namespace Lesson3HW
{
    class Program
    {
        static void Main(string[] args)
        {

            string Marka = Console.ReadLine();
            Console.WriteLine($"Marka");
            string Modelis = Console.ReadLine();
            Console.WriteLine($"Modelis");

            string Garumsphone = Console.ReadLine();
            int Garums = int.Parse(Garumsphone);
            Console.WriteLine(Garums);

            string Platumnsphone = Console.ReadLine();
            int Platums = int.Parse(Platumnsphone);
            Console.WriteLine(Platums);

            string Augstumsphone = Console.ReadLine();
            int Augstums = int.Parse(Augstumsphone);
            Console.WriteLine(Augstums);


        }
    }
}
