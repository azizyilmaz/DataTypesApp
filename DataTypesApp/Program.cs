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
            string s = "35";
            string s2 = "Kapı";
            string s3 = "922337203685477580";
            string s4 = null;
            sbyte x = 127;
            short y = 32767;
            int z = 2147483647;
            long t = 922337203685477580;
            int z2 = Convert.ToInt32(x);
            int z3 = Convert.ToInt32(y);
            //int z4 = Convert.ToInt32(t);// System.OverflowException: 'Değer bir Int32 için çok büyük ya da çok küçüktü.'
            int z5 = Convert.ToInt32(s4);
            int ss = Int32.Parse(s);
            //int ss2 = Int32.Parse(s2);// System.FormatException: 'Giriş dizesi doğru biçimde değildi.'
            //int ss3 = Int32.Parse(s3);// System.OverflowException: 'Değer bir Int32 için çok büyük ya da çok küçüktü.'
            //int ss4 = Int32.Parse(s4);// System.ArgumentNullException: 'Değer null olamaz.Parametre adı: String'

            int i = 1;
            int j = 2;
            Metod(i, ref j, out int k);
            Bilgisayar b1 = new Bilgisayar("Dell");
            Bilgisayar b2 = b1;
            Console.WriteLine("1. nesne {0} markası", b1.Marka);
            Console.WriteLine("2. nesne {0} markası", b2.Marka);
            b2.Marka = "Toshiba";
            Console.WriteLine("1. nesne {0} markası", b1.Marka);
            Console.WriteLine("2. nesne {0} markası", b2.Marka);

            Personel p1 = new Personel(1, 1, "Dell");
            Personel p2 = p1;
            Console.WriteLine("1. nesne {0} markası", p1.ToString());
            Console.WriteLine("2. nesne {0} markası", p2.ToString());
            p2.Adet = 2;
            p2.Bilgisayar.Marka = "Toshiba";
            p2.Sicil = 2;
            Console.WriteLine("1. nesne {0} markası", p1.ToString());
            Console.WriteLine("2. nesne {0} markası", p2.ToString());

            Takim t1 = new Takim(1, 93);
            Takim t2 = (Takim)t1.Clone();
            Console.WriteLine(t1.ToString());
            Console.WriteLine(t2.ToString());
            t2.Puan = 60;
            t2.Siralama = 7;
            Console.WriteLine(t1.ToString());
            Console.WriteLine(t2.ToString());

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
