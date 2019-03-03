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

            var numberDictionary = new Dictionary<int, int>();
           
            foreach (var number in randomNumbers)
             {
                 if (!numberDictionary.ContainsValue(number))
                 {
                    numberDictionary.Add(number, number);
                 }
             }
            


                //for (int i = 0; i < randomNumbers.Length; i++)
                //{
                //    if (!randomNumbers.Contains(i))
                //    {
                //        numberDictionary.Add(randomNumbers[i],"non duplicate number");
                        
                //    }
                    
                //}

            
            



        }

    }
}
