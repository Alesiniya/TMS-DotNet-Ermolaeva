using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;

namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample_Aggregate_Lambda_Simple();
            Sample_Aggregate_Lambda_Seed();
            Sample_Average_Lambda();
            Sample_Count_Lambda();
            Sample_LongCount_Lambda();
            Sample_Min_Lambda();
            Sample_Max_Lambda();
            Sample_Sum_Lambda();
            Sample_AsEnumerable_Lambda();
            Sample_Cast_Lambda();
            Sample_OfType_Lambda();
            Sample_ToArray_Lambda();
            Sample_ToDictionary_Lambda_Simple();
            Sample_ToDictionary_Lambda_Conditional();
            Sample_ToList_Lambda();
            Sample_ToLookup_Lambda();
            Sample_ElementAt_Lambda();
            Sample_ElementAtOrDefault_Lambda();
            Sample_First_Lambda_Simple();
            Sample_First_Lambda_Conditional();
            Sample_FirstOrDefault_Lambda();
            Sample_Last_Lambda();
            Sample_LastOrDefault_Simple();
            Sample_LastOrDefault_Conditional();
            Sample_Single_Lambda();
            Sample_SingleOrDefault_Lambda();
            Sample_DefaultIfEmpty_Lambda_Simple();
            Sample_DefaultIfEmpty_Lambda_DefaultValue();
            Sample_Empty_Lambda();
            Sample_Range_Lambda();
            Console.ReadLine();
        }
        private static void Sample_Aggregate_Lambda_Simple()
        {
            var str = new string[] { "one", "two", };

            var result = str.Aggregate((a, b) => a + b);

            Console.WriteLine("Aggregated str:");
            Console.WriteLine(result);
        }
        private static void Sample_Aggregate_Lambda_Seed()
        {
            var str = new string[] { "one", "two", };

            var result = str.Aggregate("ten", (a, b) => a + b);

            Console.WriteLine("Aggregated str by addition world ten:");
            Console.WriteLine(result);
        }
        static void Sample_Average_Lambda()
        {
            int[] numbers = { 11, 12, 13, 14 };

            var result = numbers.Average();

            Console.WriteLine("Average is:");
            Console.WriteLine(result);
        }
        static void Sample_Count_Lambda()
        {
            int[] numbers = { 1, 2, 3 };

            var result = numbers.Count();

            Console.WriteLine("Counting nimbers gives:");
            Console.WriteLine(result);
        }
        static void Sample_LongCount_Lambda()
        {
            var largeArr = new string[] { "one", "two", "three" };

            Int64 result = largeArr.LongCount();


            Console.WriteLine("Counting largeArr elements:");
            Console.WriteLine(result);
        }
        static void Sample_Min_Lambda()
        {
            var word = new string[] { "one", "two", "three" };

            var result = word.Min();

            Console.WriteLine("Min word is:");
            Console.WriteLine(result);
        }
        static void Sample_Max_Lambda()
        {
            int[] numbers = { 5, 3, 9 };

            var result = numbers.Max();

            Console.WriteLine("Lowest number is:");
            Console.WriteLine(result);
        }
        static void Sample_Sum_Lambda()
        {
            int[] numbers = { 5, 3, 9 };

            var result = numbers.Sum();

            Console.WriteLine("Summing the numbers:");
            Console.WriteLine(result);
        }
        static void Sample_AsEnumerable_Lambda()
        {
            int[] numbers = { 5, 3, 9 };

            var result = numbers.AsEnumerable();

            Console.WriteLine("Iterating over IEnumerable collection:");
            foreach (var number in result)
                Console.WriteLine(numbers);
        }
        static void Sample_Cast_Lambda()
        {
            List<string> vegetables = new List<string> { "Cucumber", "Tomato", "Broccoli" };

            var result = vegetables.Cast<string>();

            Console.WriteLine("List of vegetables:");
            foreach (string vegetable in result)
                Console.WriteLine(vegetable);
        }
        static void Sample_OfType_Lambda()
        {
            int[] objects = { 1, 2, 3 };

            var result = objects.OfType<int>();

            Console.WriteLine("Objects being of type:");
            foreach (int str in result)
                Console.WriteLine(str);
        }
        static void Sample_ToArray_Lambda()
        {
            string[] numbers = { "1", "2", "3", "4" };

            var result = numbers.ToArray();

            Console.WriteLine("New array contains identical values:");
            foreach (string number in result)
                Console.WriteLine(number);
        }
        class DecimaltoBinary
        {
            public string Decimal { get; set; }
            public string Binary { get; set; }
        }

        static void Sample_ToDictionary_Lambda_Simple()
        {
            DecimaltoBinary[] Inttotwo =
            {
        new DecimaltoBinary { Decimal = "1", Binary = "0001" },
        new DecimaltoBinary { Decimal = "2", Binary= "0010" },
        new DecimaltoBinary { Decimal = "3", Binary = "0011" },
    };

            var result = Inttotwo.ToDictionary(k => k.Decimal, v => v.Binary);

            Console.WriteLine("Values:");
            foreach (KeyValuePair<string, string> dic in result)
                Console.WriteLine(String.Format("Decimal {0} is {1} in Binary", dic.Key, dic.Value));
        }
        static void Sample_ToDictionary_Lambda_Conditional()
        {
            string[] word = { "one", "two" };

            var result = word.ToDictionary(k => k, v => v);

            Console.WriteLine("Word in dictionary:");
            foreach (var dic in result)
                Console.WriteLine("Value {0} is {1}", dic.Key, dic.Value);
        }
        static void Sample_ToList_Lambda()
        {
            string[] names = { "Brenda", "Carl", "Finn" };

            List<string> result = names.ToList();

            Console.WriteLine(String.Format("names is of type: {0}", names.GetType().Name));
            Console.WriteLine(String.Format("result is of type: {0}", result.GetType().Name));
        }
        static void Sample_ToLookup_Lambda()
        {
            string[] words = { "one", "two", "three", "four", "five", "six", "seven" };

            var result = words.ToLookup(w => w.Length);

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(String.Format("Elements with a length of {0}:", i));
                foreach (string word in result[i])
                    Console.WriteLine(word);
            }
        }
        static void Sample_ElementAt_Lambda()
        {
            int[] n = { 1, 22, 666 };

            var result = n.ElementAt(2);

            Console.WriteLine("Element at index 2 in the array is:");
            Console.WriteLine(result);
        }
        static void Sample_ElementAtOrDefault_Lambda()
        {
            int[] c = { 1, 12, 1526 };

            var resultIndex1 = c.ElementAtOrDefault(3);

            var resultIndex10 = c.ElementAtOrDefault(10);

            Console.WriteLine("Element at index 3 in the array contains:");
            Console.WriteLine(resultIndex1);

            Console.WriteLine("Element at index 10 in the array does not exist:");
            Console.WriteLine(resultIndex10 == null);
        }
        static void Sample_First_Lambda_Simple()
        {
            int[] c = { 1, 12, 1526 };

            var result = c.First();

            Console.WriteLine("First element in the array is:");
            Console.WriteLine(result);
        }
        static void Sample_First_Lambda_Conditional()
        {
            string[] c = { "Alesya", "Inna", "Vova" };

            var result = c.First(c => c.Length == 6);


            Console.WriteLine("First element with a length of 6 characters:");
            Console.WriteLine(result);
        }
        static void Sample_FirstOrDefault_Lambda()
        {
            int [] c = { 1, 6,17, 168 };
            int[] empty = { };

            var result = c.FirstOrDefault();

            var resultEmpty = empty.FirstOrDefault();

            Console.WriteLine("First element in the countries array contains:");
            Console.WriteLine(result);

            Console.WriteLine("First element in the empty array does not exist:");
            Console.WriteLine(resultEmpty == null);
        }
        static void Sample_Last_Lambda()
        {
            string[] n = { "Alesya", "Inna", "Vova" };

            var result = n.Last();

            Console.WriteLine("Last number in array is:");
            Console.WriteLine(result);
        }
        static void Sample_LastOrDefault_Simple()
        {
            int[] c = { 1, 6, 17, 168 };
            int[] empty = { };

            var result = c.LastOrDefault();

            var resultEmpty = empty.LastOrDefault();

            Console.WriteLine("Last element in the words array contains:");
            Console.WriteLine(result);

            Console.WriteLine("Last element in the empty array does not exist:");
            Console.WriteLine(resultEmpty == null);
        }
        static void Sample_LastOrDefault_Conditional()
        {
            string[] n = { "Alesya", "Inna", "Vova" };

            var result = n.LastOrDefault(w => w.Length == 4);

            var resultNoMatch = n.LastOrDefault(w => w.Length == 5);

            Console.WriteLine("Last element in the words array having a length of 3:");
            Console.WriteLine(result);

            Console.WriteLine("Last element in the empty array having a length of 2 does not exist:");
            Console.WriteLine(resultNoMatch == null);
        }
        static void Sample_Single_Lambda()
        {
            int[] a = { 1 };
            int[] b = { 2,4,5};
            int[] empty = { };

            var result1 = a.Single();

            Console.WriteLine("The only number in the array is:");
            Console.WriteLine(result1);

            try
            {
                var resultEmpty = empty.Single();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                var result3 = b.Single();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Sample_SingleOrDefault_Lambda()
        {
            int[] a = { 1 };
            int[] b = { 2, 4, 5 };
            int[] empty = { };

            var result1 = a.SingleOrDefault();

            var resultEmpty = empty.SingleOrDefault();

            Console.WriteLine("The only nunber in the array is:");
            Console.WriteLine(result1);

            Console.WriteLine("As array is empty, SingleOrDefault yields null:");
            Console.WriteLine(resultEmpty == null);

            try
            {
                var result3 = b.SingleOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Sample_DefaultIfEmpty_Lambda_Simple()
        {
            string[] emptyStr = { };
            int[] emptyInt = { };
            int[] n = { 1, 2544, 298955 };

            var resultStr = emptyStr.DefaultIfEmpty();

            var resultInt = emptyInt.DefaultIfEmpty();

            var resultWords = n.DefaultIfEmpty();

            Console.WriteLine("resultStr has one element with a value of null:");
            Console.WriteLine(resultStr.Count() == 1 && resultStr.First() == null);

            Console.WriteLine("resultInt has one element with a value of 0:");
            Console.WriteLine(resultInt.Count() == 1 && resultInt.First() == 0);

            Console.WriteLine("resultWords has same content as number array:");
            Console.WriteLine(resultWords.SequenceEqual(n));
        }
        static void Sample_DefaultIfEmpty_Lambda_DefaultValue()
        {
            int[] empty = { };

            var result = empty.DefaultIfEmpty(5);

            Console.WriteLine("result contains one element with a value of 5:");
            Console.WriteLine(result.Count() == 1 && result.First() == 5);
        }
        static void Sample_Empty_Lambda()
        {
            var empty = Enumerable.Empty<int>();

            Console.WriteLine("Sequence is empty:");
            Console.WriteLine(empty.Count() == 0);
        }
        static void Sample_Range_Lambda()
        {
            var result = Enumerable.Range(0, 12);

            Console.WriteLine("Counting from 0 to 10:");
            foreach (int number in result)
                Console.WriteLine(number);
        }
        static void Sample_Repeat_Lambda()
        {
            string word = "Banana";

            var result = Enumerable.Repeat(word, 5);

            Debug.WriteLine("String is repeated 5 times:");
            foreach (string str in result)
                Debug.WriteLine(str);
        }
    }
}
