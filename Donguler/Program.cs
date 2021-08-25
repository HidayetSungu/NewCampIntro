using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Gelistirici Yetiştirme Kampı";
            string kurs2 = "programlmaya başlangıc için temel kurs";
            string kurs3 = "java";

            string[] kurslar = new string[] { "Yazılım Gelistirici Yetiştirme Kampı",
                "programlmaya başlangıc için temel kurs", 
                "java", "python"};



            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");
             
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }




            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}
