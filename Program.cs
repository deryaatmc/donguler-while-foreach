using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // While Döngüsü
            // 1'den başlayarak console'dan girilen sayıya kadar olan sayıların ortalamasını hesaplayalım.

            Console.Write("Lütfen bir sayı giriniz: ");
            if (!int.TryParse(Console.ReadLine(), out int sayi) || sayi <= 0)
            {
                Console.WriteLine("Geçerli bir sayı giriniz!");
                return;
            }
            int sayac = 1;
            int toplam = 0;

            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }

            double ortalama = (double)toplam / sayi;
            Console.WriteLine("Ortalama: " + ortalama);

            // Foreach Döngüsü
            string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }

            Console.WriteLine("\nProgram sona erdi.");
        }
    }
}
