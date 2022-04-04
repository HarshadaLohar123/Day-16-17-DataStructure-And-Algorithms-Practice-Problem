using System;

namespace AlgorithmProblems
{
    public class InsertionSort
    {
        static void Main(string[] args)
        {
            string[] names = { "Banana", "Apple", "Kiwi", "Pineapple", "Mango" };
            InsertSort(names);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
        public static void InsertSort(IComparable[] array)
        {
            int i, j;
            for (i = 1; i < array.Length; i++)
            {
                IComparable value = array[i];
                j = i - 1;
                while ((j >= 0) && (array[j].CompareTo(value) > 0))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = value;
            }
        }
    }
}


   