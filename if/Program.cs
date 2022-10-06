using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int not1 = 90;
            int not2 = 90;
            int ortalama = (not1 + not2) / 2;
            if (ortalama >= 90)
            {
                Console.WriteLine("Notunuz A ");
                Console.ReadLine();

            }
            else if (ortalama >= 80)
            {
                Console.WriteLine("Notunuz B ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("kaldınız");
                Console.ReadLine();
            }


        }
    }
}
