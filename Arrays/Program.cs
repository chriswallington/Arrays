using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomNumbers = { 1, 1, 3, 5, 4, 2, 6, 4, 2, 7, 74, 7, 8, 4, 7, 2, 5, 4, 6, 1 };

            var numberDictionary = new SortedDictionary<int, int>();

            DeDuplicateDictionary(randomNumbers, numberDictionary);

            //var results = numberDictionary.OrderBy(n => n.Value);

            //foreach (var result in results)
            //{
            //    Console.WriteLine($"{result}");
            //}

            SortDictionary(numberDictionary);

        }

        private static void SortDictionary(SortedDictionary<int, int> numberDictionary)
        {
            foreach (KeyValuePair<int, int> number in numberDictionary.OrderBy(n => n.Value))
            {
                Console.WriteLine($"{number.Key},{number.Value}");
            }
        }

        private static void DeDuplicateDictionary(int[] randomNumbers, SortedDictionary<int, int> numberDictionary)
        {
            foreach (var number in randomNumbers)
            {
                if (!numberDictionary.ContainsValue(number))
                {
                    numberDictionary.Add(number, number);
                }
            }
        }
    }
}
