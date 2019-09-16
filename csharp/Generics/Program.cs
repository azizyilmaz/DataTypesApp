using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var dics = new Dictionary<string, int> {
                { "x", 1 },
                { "y", 2 },
                { "z", 3 }
            };

            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            keyValuePairs["x"] = 50;
            keyValuePairs["y"] = 70;
            keyValuePairs["z"] = 40;

            foreach (KeyValuePair<string, int> keyValues in dics)
            {
                Console.WriteLine("Key is {0} and value is {1}", keyValues.Key, keyValues.Value);
            }

            List<int> list = new List<int>();
            list.Add(3);
            list.Add(4);
            //list.Add(5.0);
            int total = 0;
            foreach (var item in list)
            {
                total += item;
            }
            Console.WriteLine("Total:{0}", total);
            Console.ReadLine();
        }
    }
}
