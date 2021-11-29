using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {

        //naming convention - isimlendirme kuralı
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler, Sepete Eklendi! : " + urun.Adi);

        }
        public void Ekle2(string urunadi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunadi);
        }
    }
}
