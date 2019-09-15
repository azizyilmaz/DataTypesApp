using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class IEnumerable
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3 };
            IEnumerable<int> enumarableIntegers = arr1;

            List<int> listOfIntegers = new List<int>();
            listOfIntegers.AddRange(arr1);
        }
    }
}
