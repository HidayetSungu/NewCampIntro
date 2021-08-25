﻿using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "hido";
            int yas = 20;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursunEgitmeni = "Kerem varıs";
            kurs2.IzlenmeOrani = 48;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.KursunEgitmeni = "Berkay bilgin";
            kurs3.IzlenmeOrani = 80;


            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3
            };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.KursunEgitmeni);
            }

        


        }

        class Kurs
        {
            public string KursAdi { get; set; }
            public string KursunEgitmeni { get; set; }
            public int IzlenmeOrani { get; set; }
        }

    }
}
