using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmısMı = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artıs Butonu");
            }
            else
            {
                Console.WriteLine("Degismedi Butonu");
            }
            

            if (sistemeGirisYapmısMı == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giris Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);
            Console.ReadLine();

           
        }
    }
}
