using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusu
{
    class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i + "For Döngüsü");
            //}

            // 1'den 10'a kadar olan sayıların toplamını bulan program.
            int toplam = 0;
            for (int i = 1; i < 4; i++)
            {
                // toplama her seferinde i'yi keldik.
                toplam = toplam + i;
            }
            Console.WriteLine("Toplam : " + toplam);

            int i;
            for (i = 1; i <= 10; i++)
            {

            }

            //Sonsuz Döngü
            for (;;)
            {
                Console.WriteLine("Seyda Eğlensin");
            }

            for (;;)
            {
                Console.Write("Çıkmak için Ç'ye basın.");
                string harf = Console.ReadLine();
                if (harf.ToUpper() == "Ç")
                {
                    break;
                }
                Console.WriteLine("Başka harfe bastınız.");
            }
            Console.WriteLine("Ç harfine bastınız tebrikler.");

            //Azalan DÖngü

            for (int i = 100; i >= 75; i--)
            {
                Console.WriteLine(i);
            }

            // Örnek1: Klavyeden girilen 2 sayı arasındaki sayıları toplayan
            // programı yazınız. For döngüsü kullanarak.
            Console.Write("1. Sayıyı Giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. Sayıyı Giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int buyuk = Math.Max(sayi1, sayi2);
            int kucuk = Math.Min(sayi1, sayi2);

            int toplam = 0;
            int i;
            for (i = kucuk; i <= buyuk; i++)
            {
                //toplam = toplam + i;
                toplam += i;
                Console.WriteLine(i);
            }
            Console.WriteLine($"{kucuk} ile {buyuk} arasındaki sayıların toplamı: {toplam}");

            // 1 ile klavyeden girilen sayı arasındaki sayılardan 3'ün katı olanları toplamını bulan program.
            int toplam = 0;
            Console.Write("Sayı Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            // 1. Yöntem
            for (int i = 1; i <= sayi; i++)
            {
                if (i % 3 == 0)
                {
                    toplam += i;
                    Console.WriteLine("Toplama eklenen sayı : " + i);
                }
            }
            Console.WriteLine(toplam);
            // 2. Yöntem: Döngü değişkeni 3'er 3'er artıyor.
            for (int i = 0; i <= sayi; i = i + 3)
            {
                toplam += i;
                Console.WriteLine("Toplama eklenen sayı : " + i);
            }

            // SORU: 1'den 100'e kadar olan tek ve çift sayıların toplamını bulan program.

            int CiftToplam = 0;
            int TekToplam = 0;

            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    CiftToplam = CiftToplam + i;
                }
                else
                {
                    TekToplam = TekToplam + i;
                }
            }
            Console.WriteLine($"Teklerin Toplamı: {TekToplam}");
            Console.WriteLine($"Çiftlerin Toplamı: {CiftToplam}");

            // Klavyeden işçi Sayısını İstiyoruz:
            // Her işçi için çocuk sayısını sor:
            // Temel Ücret: 3000
            // Çocuk başına da 100 TL ek ücret ekleyerek. Her işçinin maaşını yazdırıyoruz.
            // İşçinin yaşı 45 ve üzeri ise maaşına 250 TL ek yansıtılsın.
            // Tüm İşçilere Ödenen Maaşı Göstersin.

            Console.Write("İşçi Sayısını Giriniz:");
            int isciSayisi = Convert.ToInt32(Console.ReadLine());

            int toplamMaas = 0; // Tüm işçilere ödenen maaşın toplamı

            for (int i = 1; i <= isciSayisi; i++)
            {
                int maas = 3000;
                Console.Write($"{i}. İşçinin Çocuk Sayısı: ");
                byte cocSay = Convert.ToByte(Console.ReadLine());
                maas = maas + cocSay * 100;

                Console.Write($"{i}. İşçinin Yaşı: ");
                byte yas = Convert.ToByte(Console.ReadLine());

                if (yas >= 45)
                {
                    maas += 250;
                }
                toplamMaas += maas;

                Console.WriteLine($"{i}. İşçinin Maaşı: {maas}");
            }
            Console.WriteLine("Toplam Ödenen Maaş: " + toplamMaas);



            // Ekrana aşağıdaki şekli çıkarın.
            /*
             
             
             *
             **
             ***
             ****
             *****             
            */

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Write("*");


            1 - 100 arasında 7 ye tam bölünen sayılar için:
            Kaçıncı tam olduğuna göre ekrana sayı veya yıldız yazacak
             9 dan büyük olanları yazmasın.
            1
            22
            333
            4444
            int sayac = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 7 == 0 && sayac < 9)
                {
                    sayac++;
                    for (int j = 1; j <= sayac; j++)
                    {
                        Console.Write(sayac); //sayac ı yazdır.
                    }
                    Console.WriteLine();
                }
            }
            Console.Read();
        }
    }
}