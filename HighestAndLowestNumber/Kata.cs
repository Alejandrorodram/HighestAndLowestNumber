using System;
using System.Linq;

namespace HighestAndLowestNumber
{
    internal class Kata
    {
        public static string HighestAndLowestNumber1(string numbers)
        {
            var parsed = numbers.Split().Select(int.Parse);
            return parsed.Max() + " " + parsed.Min();
        }
        public static string HighestAndLowestNumber2(string numbers)
        {
            var numbersList = numbers.Split(' ').Select(x => Convert.ToInt32(x));
            return string.Format("{0} {1}", numbersList.Max(), numbersList.Min());
        }
        public static string HighestAndLowestNumber3(string numbers)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            string[] values = numbers.Split(' ');
            for (int i = values.Length - 1; i >= 0; --i)
            {
                int value = System.Convert.ToInt32(values[i]);
                if (value < min)
                {
                    min = value;
                }
                if (value > max)
                {
                    max = value;
                }
            }
            return string.Format("{0} {1}", max, min);
        }
    }
}
