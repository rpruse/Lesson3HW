using System;

namespace Lesson3HW
{
    class Program
    {
        static void Main(string[] args)
        {
            var phone = new Appl3();

            Console.WriteLine("Sveiki, uzraksti lūdzu telefona parametrus");

            Console.WriteLine($"Marka");
            string Marka = Console.ReadLine();
            Console.WriteLine($"Modelis");
            string Modelis = Console.ReadLine();

            Console.WriteLine("Garums");
            string Garums = Console.ReadLine();
            int Garums1 = int.Parse(Garums);

            Console.WriteLine("Platums");
            string Platumns = Console.ReadLine();
            int Platums1 = int.Parse(Platumns);

            Console.WriteLine("Augstums");
            string Augstums = Console.ReadLine();
            int Augstums1 = int.Parse(Augstums);

            phone.Marka = "Samsung";
            phone.Modelis = "Galaxy";
            phone.Garums = 20;
            phone.Platums = 1;
            phone.Augstums = 10;

            Console.WriteLine("----------------------------------------------");

        }
    }
}
