using System;

namespace VizeFinalOrt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vize Notu Giriniz:");
            int vze = int.Parse(Console.ReadLine());
            Console.WriteLine("Final Notu Giriniz:");
            int fnal = int.Parse(Console.ReadLine());
            double sonuc;
            sonuc = (vze * 0.4) + (fnal * 0.6);

            if(sonuc<=100 && sonuc>=80)
            {
                Console.WriteLine("AA");
            }
            else if (sonuc <= 79 && sonuc >= 70)
            {
                Console.WriteLine("BA");
            }
            else if (sonuc <= 69 && sonuc >= 60)
            {
                Console.WriteLine("CC");
            }
            else if (sonuc <= 59 && sonuc >= 45)
            {
                Console.WriteLine("DD");
            }
            else
            {
                Console.WriteLine("FF");
            }
            Console.ReadKey();
        }
    }
}
