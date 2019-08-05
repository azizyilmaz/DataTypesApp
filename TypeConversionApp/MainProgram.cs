using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversionApp
{
    class CanliVarlik
    {

    }
    class Insan : CanliVarlik
    {

    }
    class MainProgram
    {
        static void Main(string[] args)
        {
            //Implicit & Explicit
            CanliVarlik c = new Insan();
            Insan i = (Insan)c;
            //Boxing
            double d = 797693134862;
            object o;
            o = d;
            Console.WriteLine(d);
            Console.WriteLine(o);
            d++;
            Console.WriteLine(d);
            Console.WriteLine(o);
            //Unboxing
            double d2;
            d2 = (double)o;
            Console.WriteLine(d2);

            //int a = 12;
            //float b = 3.5F;
            //int c = a + Convert.ToInt32(b);

            //char l = 'k';
            //float b = 19.0f;
            //int c;
            ////c = (l / Convert.ToInt32(b));
            //c = Convert.ToInt32(l / b);
            //Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
