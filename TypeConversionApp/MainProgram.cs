using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversionApp
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            //int a = 12;
            //float b = 3.5F;
            //int c = a + Convert.ToInt32(b);

            char l = 'k';
            float b = 19.0f;
            int c;
            //c = (l / Convert.ToInt32(b));
            c = Convert.ToInt32(l / b);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
