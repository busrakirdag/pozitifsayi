using System;

namespace PozitifNegatifSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı Giriniz:");
            int i = int.Parse(Console.ReadLine());
            if (i < 0)
            {
                Console.WriteLine("Sayı Negatif");
            }
            else if (i > 0)
            {
                Console.WriteLine("Sayı Pozitif");
            }
            else
            {
                Console.WriteLine("Sayı 0'dır.");
            }
            Console.ReadKey();
        }
    }
}
