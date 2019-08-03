using System;

namespace DataTypesApp
{
    class Program
    {
        static void Metod(in int i, ref int j, out int k)
        {
            //i = 0;// readonly
            j = 0;
            k = 0;
            Console.WriteLine("i:" + i);
            Console.WriteLine("j:" + j);
            Console.WriteLine("k:" + k);
        }
        static void Main(string[] args)
        {
            int i = 1;
            int j = 2;
            Metod(i, ref j, out int k);
            //Bilgisayar b1 = new Bilgisayar("Dell");
            //Bilgisayar b2 = b1;
            //Console.WriteLine("1. nesne {0} markası", b1.Marka);
            //Console.WriteLine("2. nesne {0} markası", b2.Marka);
            //b2.Marka = "Toshiba";
            //Console.WriteLine("1. nesne {0} markası", b1.Marka);
            //Console.WriteLine("2. nesne {0} markası", b2.Marka);

            //Personel p1 = new Personel(1, 1, "Dell");
            //Personel p2 = p1;
            //Console.WriteLine("1. nesne {0} markası", p1.ToString());
            //Console.WriteLine("2. nesne {0} markası", p2.ToString());
            //p2.Adet = 2;
            //p2.Bilgisayar.Marka = "Toshiba";
            //p2.Sicil = 2;
            //Console.WriteLine("1. nesne {0} markası", p1.ToString());
            //Console.WriteLine("2. nesne {0} markası", p2.ToString());

            //Takim t1 = new Takim(1, 93);
            //Takim t2 = (Takim)t1.Clone();
            //Console.WriteLine(t1.ToString());
            //Console.WriteLine(t2.ToString());
            //t2.Puan = 60;
            //t2.Siralama = 7;
            //Console.WriteLine(t1.ToString());
            //Console.WriteLine(t2.ToString());

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
