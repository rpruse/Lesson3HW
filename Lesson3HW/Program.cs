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

            var Car = new Opel();

            Console.WriteLine("Sveiki, uzraksti lūdzu mašīnas parametrus");

            Console.WriteLine($"Marka1");
            string Marka1 = Console.ReadLine();


            Console.WriteLine("Nummurzīme");
            string Nummurzīme = Console.ReadLine();
            int Numurs = int.Parse(Nummurzīme);

            Console.WriteLine("Ātrums");
            string Ātrums = Console.ReadLine();
            int Speed = int.Parse(Ātrums);

            Car.Marka1 = "Opel";
            Car.Nummurzīme = "JD10";
            Car.Ātrums = 200;

            string beep = Car.BeigtBraukt();
            Console.WriteLine(beep);

            Console.WriteLine("----------------------------------------------");




        }
    }
}
