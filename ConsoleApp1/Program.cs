using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atmApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 1000;
            int yatirilanPara;
            int cekilenPara;
            Console.WriteLine("Hoşgeldiniz lütfen yapmak istediğiniz işlemi seçiniz");
            Console.WriteLine("1: Bakiye sorgulama");
            Console.WriteLine("2: Para yatır");
            Console.WriteLine("3: Para çek");
            Console.WriteLine("4: Çıkış");
            tekrar:
            string tus = Console.ReadLine();

            if(tus == "1")
            {
                Console.WriteLine("Bakiyeniz "+ bakiye);
                Console.ReadLine();
            }else if (tus == "2")
            {
                yatirilanPara = Convert.ToInt32(Console.ReadLine());
                bakiye += yatirilanPara;
                Console.WriteLine("Yeni bakiye: " + bakiye);
                Console.ReadLine();
                
            }else if (tus == "3")
            {
                cekilenPara = Convert.ToInt32(Console.ReadLine());
                bakiye -= cekilenPara;
                Console.WriteLine("Yeni bakiye: "+ bakiye);
                Console.ReadLine();

            }else if(tus == "4")
            {
                Console.WriteLine("Çıkış yapılıyor...");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Hatalı tuslama ");
                goto tekrar;
            }
        }
    }
}
