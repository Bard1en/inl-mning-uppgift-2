using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace inlämning_Uppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nummer = new List<int>();
            nummer.Add(10);
            nummer.Add(20);
            nummer.Add(30);
            nummer.Add(918237);
            Max(nummer);
            Console.ReadKey();
        }
        static void Max (List<int> nummer)
        {
            nummer.Sort();
            nummer.RemoveRange(0, nummer.Count -1);
            foreach(int numbers  in nummer)
            {
                Console.WriteLine("Det största talet var " + numbers);
            }
        }
    }
}