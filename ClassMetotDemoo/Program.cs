using System;

namespace ClassMetotDemoo
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Mert";
            string soyadi = "Özkeş";
            string sube = "Kocasinan";
            int id = 232454;

            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Mert";
            musteri1.Soyadi = "Özkeş";
            musteri1.Sube = "Kocasinan";
            musteri1.id = 232454;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Murat";
            musteri2.Soyadi = "Ekrem";
            musteri2.Sube = "Kocasinan";
            musteri2.id = 232455;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Gökhan";
            musteri3.Soyadi = "Yılmaz";
            musteri3.Sube = "Kocasinan";
            musteri3.id = 232456;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri Adı: " + musteri.Adi);
                Console.WriteLine("Müsteri Soyadı: " + musteri.Soyadi);
                Console.WriteLine("Müşterinin Şubesi: " + musteri.Sube);
                Console.WriteLine("Müşteri Id: " + musteri.id);
                Console.WriteLine("-------------------------------------------------------------------------------------");

            }


            MusteriManager musteridüuzenleme = new MusteriManager();
            musteridüuzenleme.Ekle(musteri1);
            musteridüuzenleme.Guncelleme(musteri2);
            musteridüuzenleme.Silme(musteri3);
        }
    }
    
}
