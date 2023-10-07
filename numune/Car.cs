using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numune
{
    internal class Car
    {
        public string Ad;
        public string Marka;
        public const string Il = "2012";

        public void show()
        {
            Console.WriteLine(Ad);
            Console.WriteLine(Marka);
            Console.WriteLine(Il);
        }
    }
}
