using System;
using System.Collections.Generic;

namespace Generics
{
    public interface IFood
    {
        void EatenBy(Animal animal);
    }

    public class Grass : IFood
    {
        public void EatenBy(Animal animal)
        {
            Console.WriteLine("Grass was eaten by: {0}", animal.Name);
        }
    }

    public class Animal
    {
        public string Name { get; set; }

        public void Eat<TFood>(TFood food) where TFood : IFood
        {
            food.EatenBy(this);
        }
    }

    public class Carnivore : Animal
    {
        public Carnivore()
        {
            Name = "Carnivore";
        }
    }

    public class Herbivore : Animal, IFood
    {
        public Herbivore()
        {
            Name = "Herbivore";
        }

        public void EatenBy(Animal animal)
        {
            Console.WriteLine("Herbivore was eaten by: {0}", animal.Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var grass = new Grass();
            var sheep = new Herbivore();
            var lion = new Carnivore();

            sheep.Eat(grass);
            lion.Eat(sheep);

            //sheep.Eat(lion);

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
