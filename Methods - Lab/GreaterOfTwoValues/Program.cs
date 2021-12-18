using System;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Globalization;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeData = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();

            Console.WriteLine(GetMax(typeData, firstValue, secondValue));

        }

        static string GetMax (string typeData, string firstValue, string secondValue)
        {
            int result = 0;
            int result2 = 0;

            if (typeData == "int")
            {
                result = int.Parse(firstValue);
                result2 = int.Parse(secondValue);
            }
            else if (typeData == "char")
            {
                result = char.Parse(firstValue);
                result2 = char.Parse(secondValue);
            }
            else if (typeData == "string")
            {
                int compare = firstValue.CompareTo(secondValue);

                if (compare > 0)
                {
                    return firstValue;
                }
                else
                {
                    return secondValue;
                }
            }

            if (result > result2)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }
        }


    }
}
