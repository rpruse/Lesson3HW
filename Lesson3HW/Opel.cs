using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3HW
{
    class Opel
    {
        public string Marka1 { get; set; }
        public string Nummurzīme { get; set; }
        public int Ātrums { get; set; }

        public void Uzsāktbraukt() { }

        public void Palielinātātrumu() { }
    
        public string BeigtBraukt()
        {
            return $"Beep beep";
        }
    }
}
