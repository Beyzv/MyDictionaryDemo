using System;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> animals = new MyDictionary<int, string>();
            animals.Add(1, "Aslan");
            animals.Add(2, "Ayı");
            animals.Add(3, "Bal Porsuğu");
            animals.Add(4, "Çıyan");
            animals.Add(5, "Panda");
            animals.Add(6, "Manda");
            animals.Add(7, "Sırtlan");
            animals.Add(8, "Karınca");
            animals.Add(9, "Kaplan");
            animals.Add(10, "Yılan");
            animals.Add(11, "Kartal");
            animals.Add(12, "Fil");

            foreach (var numbers in animals.key)
            {
                Console.WriteLine(numbers);
            }

            foreach (var animal in animals.value)
            {
                Console.WriteLine(animal);
            }

        }
    }
}
