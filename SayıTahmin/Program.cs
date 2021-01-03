using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayıTahmin
{
    class Program
    {
        static Random Rastgele = new Random();
        static void Main(string[] args)
        {
            
            int tahmin, sayi = Rastgele.Next(100);
            int hak = 0;
            int oyunseviyesi;
            Console.WriteLine("Zorluk seçiniz ");
            Console.WriteLine("1. Basit");
            Console.WriteLine("2. Orta");
            Console.WriteLine("3. Zor");
            Console.Write("Seçiminiz ?\n");
            oyunseviyesi = Convert.ToInt32(Console.ReadLine());
            if (oyunseviyesi == 1)
            {
                sayi = Rastgele.Next(1, 10);
                hak = 6;
                
                
            }
            else if (oyunseviyesi == 2)
            {
                sayi = Rastgele.Next(1, 25);
                hak = 4;
            }
            else if(oyunseviyesi == 3)
            {
                sayi = Rastgele.Next(1, 50);
                hak = 2;
                
            }
            
            while (true)
            {
                Console.WriteLine("\n\n" + hak-- + " hakkınız var.");
                if (hak < 0)
                {
                    Console.WriteLine("KAYBETTİNİZ!");
                    break;
                }

                Console.Write("SAYI GİRİNİZ: ");
                tahmin = Convert.ToInt32(Console.ReadLine());
                if (tahmin > sayi)
                {
                    Console.WriteLine("Daha KÜÇÜK bir sayı giriniz.");
                }
                else if (tahmin < sayi)
                {
                    Console.WriteLine("Daha BÜYÜK bir sayı giriniz.");
                }
                else
                {
                    Console.WriteLine("TEBRİKLER!");
                    break;
                }
                
            }
        }
    }
}
