using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemoo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Hoşgeldiniz: " + musteri.Adi + musteri.Soyadi);
        }
        public void Guncelleme(Musteri musteri)
        {
            Console.WriteLine(musteri.Sube + "  Şube Bilgileriniz Güncellenmiştir");
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.id + " Numaralı Hesap Bilgileriniz Silinmiştir  " + musteri.Adi + musteri.Soyadi);
        }

    }
}
