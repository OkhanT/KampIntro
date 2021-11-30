using System;

namespace _3.Odev3_16Ocak2021_ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteriler musteriler = new Musteriler();
            musteriler.Id = "1. Müşteri";
            musteriler.Ad = "Mehmet Okhan";
            musteriler.Soyad = "Yılmaz";
            musteriler.Yas = 27;
            musteriler.Tc = 12345678901;
            musteriler.DogumYeri = "Van";
            musteriler.DogumTarihi = "26Nisan1995";


            Musteriler musteriler1 = new Musteriler();
            musteriler1.Id = "2.Müsteri";
            musteriler1.Ad = "Fatih";
            musteriler1.Soyad = "Yılmaz";
            musteriler1.Yas = 33;
            musteriler1.Tc = 10987654321;
            musteriler1.DogumYeri = "Erçiş";
            musteriler1.DogumTarihi = "26.11.1989";

            Musteriler musteriler2 = new Musteriler();
            musteriler2.Id = "3.Müşteri";
            musteriler2.Ad = "Veysel";
            musteriler2.Soyad = "Yılmaz";
            musteriler2.Yas = 58;
            musteriler2.Tc = 67890154321;
            musteriler2.DogumYeri = "Van";
            musteriler2.DogumTarihi = "14.12.1964";

            Musteriler musteriler3 = new Musteriler();
            musteriler3.Id = "4.Müşteri";
            musteriler3.Ad = "Nilcan";
            musteriler3.Soyad = "Yılmaz";
            musteriler3.Yas = 45;
            musteriler3.Tc = 32178901456;
            musteriler3.DogumYeri = "Van";
            musteriler3.DogumTarihi = "15/03/1972";

            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Ekle(musteriler);
            musterimanager.Ekle(musteriler1);
            musterimanager.Ekle(musteriler2);
            musterimanager.Ekle(musteriler3);
            Console.WriteLine("Müşterilerimiz: ");
            musterimanager.Listele(musteriler);
            musterimanager.Listele(musteriler1);
            musterimanager.Listele(musteriler2);
            musterimanager.Listele(musteriler3);
            Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
            musterimanager.Sil(musteriler);
            musterimanager.Sil(musteriler3);
            musterimanager.Sil(musteriler1);
            musterimanager.Sil(musteriler2);

            Console.WriteLine("Müşterilerimiz: ");
            Musteriler[] musteriListele = new Musteriler[] { musteriler, musteriler1, musteriler2, musteriler3 };
            foreach (var liste in musteriListele)
            {
                Console.WriteLine(liste.Ad + " " + liste.Soyad);
            }

        }
    }
}
