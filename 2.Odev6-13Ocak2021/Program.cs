using System;

namespace Odev6_13Ocak2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.UrunKategori = "Beyaz Eşya";
            product1.UrunAd = "Buzdolabı";
            product1.UrunFiyat = 1250;

            Product product2 = new Product();
            product2.UrunKategori = "Oyuncak";
            product2.UrunAd = "Lego";
            product2.UrunFiyat = 450;

            Product product3 = new Product();
            product3.UrunKategori = "Spor";
            product3.UrunAd = "Futbol Topu";
            product3.UrunFiyat = 350;

            Product product4 = new Product();
            product4.UrunKategori = "Kozmetik";
            product4.UrunAd = "Cilt Bakım Kremi";
            product4.UrunFiyat = 90;

            Product product5 = new Product();
            product5.UrunKategori = "Kitap";
            product5.UrunAd = "Beyaz Zambaklar Ülkesi";
            product5.UrunFiyat = 60;

            Product product6 = new Product();
            product6.UrunKategori = "Bahçe";
            product6.UrunAd = "Yapay Çim";
            product6.UrunFiyat = 1550;

            Product[] productList = new Product[] { product1, product2, product3, product4, product5, product6 };

            for (int i = 0; i < productList.Length; i++)
            {
                Console.WriteLine(productList[i].UrunKategori);
                Console.WriteLine(productList[i].UrunAd);
                Console.WriteLine(productList[i].UrunFiyat);

                Console.WriteLine(productList[i].UrunAd + " : " + productList[i].UrunFiyat + " TL");
            }

            Console.WriteLine("----------------For döngüsü bitti!!!----------------");

            foreach (var i1 in productList)
            {
                Console.WriteLine("Ürün Kategorisi: " + i1.UrunKategori + " / " + "Ürün Adı: " + i1.UrunAd + " / " + "Ürün Fiyatı: " + i1.UrunFiyat);

            }

            Console.WriteLine("--------------Foreach döngüsü bitti!!!------------");

            int i0 = 0;
            while (i0 < productList.Length)
            {
                Console.WriteLine("While, For ve Foreach döngülerini tamamlandı. While döngüsü bu stringi 6 kez yazdıracak!!!");

                i0++;
            }

            Console.WriteLine("Hello World!");
        }
    }

    class Product
    {
        public string UrunKategori { get; set; }

        public string UrunAd { get; set; }

        public int UrunFiyat { get; set; }


    }
}
