using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Odev3_16Ocak2021_ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteriler musteri)
        {
            Console.WriteLine(musteri.Id + "'miz " + musteri.Ad + " " + musteri.Soyad + " Kaydedildi!");
            Console.WriteLine("//////////////////////////////////////////////////////");
        }

        public void Listele(Musteriler musteri0)
        {
            Console.WriteLine(musteri0.Ad + " " + musteri0.Soyad);

        }

        public void Sil(Musteriler musteri1)
        {
            Console.WriteLine("***** " + musteri1.Id + "'miz " + musteri1.Ad + " " + musteri1.Soyad + "'nin talebi üzerine bankamızla ilişkisi kesilmiş ve bilgileri silinmiştir." + " Silinen bilgileri: " + "Yaş: " + musteri1.Yas + " " + "Tc: " + musteri1.Tc + " " + "Doğum Tarihi: " + musteri1.DogumTarihi + " " + "Doğum Yeri: " + musteri1.DogumYeri + " *****");
            Console.WriteLine("---------------------------------------");

        }
    }
}
