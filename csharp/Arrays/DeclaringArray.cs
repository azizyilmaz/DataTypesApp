using System;
using System.Linq;

namespace Arrays
{
    class DeclaringArray
    {
        public static void Main(string[] args)
        {
            //Comparing arrays for equality
            int[] array1 = new int[4];
            array1[0] = 1;
            array1[1] = 3;
            array1[2] = 5;
            int[] array2 = new int[4] { 1, 3, 5, 0 };
            bool result = array1.SequenceEqual(array2);
            Console.WriteLine(result);

            //Copying arrays
            var sourceArray = new int[] { 1, 2, 3, 4, 5, 6 };
            var destinationArray = new int[10];
            sourceArray[0] = 45;
            sourceArray.CopyTo(destinationArray, 2);
            //Array.Copy(sourceArray, destinationArray, 3);
            foreach (var destArr in destinationArray)
            {
                Console.WriteLine(destArr);
            }

            //Initializing an array filled with a repeated nondefault value
            bool[] booleanArray = Enumerable.Repeat(true, 10).ToArray();
            int[] intArray = Enumerable.Repeat(100, 6).ToArray();
            string[] stringArray = Enumerable.Repeat("C#", 3).ToArray();
            foreach (var array in stringArray)
            {
                System.Console.WriteLine(array);
            }

            var arr1 = new[] { 1, 2, 3, 4, 5 };
            var arr2 = new[] { "one", "two", "three" };
            var arr3 = new[] { 1.0, 2.0, 3.0 };

            int[] arr = { 24, 2, 13, 47, 45 };

            //int[] arr = null;
            int first = arr[0];
            System.Console.WriteLine("First:" + first);
            System.Console.ReadKey();
        }
    }
}
