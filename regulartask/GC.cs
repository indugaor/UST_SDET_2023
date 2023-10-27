using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class GC
    {

        public void ListHandling()
        {
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            /* for (int i = 0; i < arrayList.Count; i++)
             {


                 Console.WriteLine(arrayList[i]);
             }*/
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            numbers.Add(66);
            numbers.Add(55);
            numbers.Add(1234);
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            numbers.Reverse();
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            numbers.RemoveAt(3);
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            numbers.Clear();
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            numbers.Sort();
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(numbers.Contains(10));
            Console.WriteLine(numbers.IndexOf(20));
            numbers.Clear();

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

        }
        public void Dicthandling()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "10");
            dict.Add(2, "20");
            dict.Add(3, "30");
            dict.Add(5, "AA");
            dict.Add(4, "BB");
            foreach (int item in dict.Keys)
            {
                Console.WriteLine(dict.ElementAt(item));
            }
            dict.Remove(3);
            foreach (int item in dict.Keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(dict.ElementAt(6));
            foreach (int item in dict.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (var item in dict.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count" + dict.Count);


        }

    }



}

