using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen araç tipini seçiniz!");
            Console.WriteLine("1. Otomobil");
            Console.WriteLine("2. Kamyonet");
            Console.WriteLine("3. İş Makinesi");
            int aracTuru = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen Kalınacak saati giriniz!");
            int sure = Convert.ToInt32(Console.ReadLine());
            int gun = sure/24;
            int saat = sure % 24;
            int ucret = 0;

            if (aracTuru == 1) {
               ucret = 13*gun;
                if (saat <= 2)
                {
                    ucret += 5;
                }
                else if (saat <= 10)
                {
                    ucret += (5 + ((saat - 2) * 1));
                }
                else if (saat > 10)
                {
                    ucret += 13;  // sabit ücret
                }
                else 
                {
                    ucret += 13;
                }

            }

            else if (aracTuru == 2)
            {
                ucret = 15 * gun;
                if (saat <= 2)
                {
                    ucret += 8;
                }
                else if (saat <= 8)
                {
                    ucret += (8 + ((saat - 2) * 2));
                }
                else if (saat > 8)
                {
                    ucret += 15;  
                }
                else 
                {
                    ucret += 15;
                }

            }


           else if (aracTuru == 3)
            {
                ucret = 20 * gun;
                if (saat <= 2)
                {
                    ucret += 12;
                }
                else if (saat <= 8)
                {
                    ucret += (12 + ((saat - 2) * 3));
                }
                else if (saat > 8)
                {
                    ucret += 20;
                }
                else 
                {
                    ucret += 20;
                }
            }
            else
            {
                Console.WriteLine("hatalı giriş yaptınız");
              
            }


                Console.WriteLine(ucret);


        }
    }
}
