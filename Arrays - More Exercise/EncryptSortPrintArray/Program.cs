using System;
using System.Linq;


namespace EncryptSortPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] sortedArr = new int[n];

            char[] vowels =
            {
                'a', 'A', 'o', 'O', 'e', 'E',
                'i', 'I', 'u', 'U'
            };

            for (int i = 0; i < n; i++)
            {
                string names = Console.ReadLine();

                char[] arr = names.ToCharArray();

                for (int j = 0; j < arr.Length; j++)
                {
                    if (vowels.Contains(arr[j]))
                    {
                        sum += arr[j] * arr.Length;
                    }
                    else
                    {
                        sum += arr[j] / arr.Length;
                    }

                }

                sortedArr[i] = sum;
                sum = 0;
            }

            Array.Sort(sortedArr);

            foreach (var element in sortedArr)
            {
                Console.WriteLine(element);
            }
        }
    }
}
