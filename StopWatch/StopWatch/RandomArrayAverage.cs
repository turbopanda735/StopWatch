using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    internal class RandomArrayAverage
    {
        public double ArrayAverage(double[] numerals)
        {
            return numerals.Sum() / numerals.Length;
        }
        public double[] ArrayFiller()
        {
            var random = new Random();
            var array = new double[random.Next(1, 101)];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 11);
            }
            foreach (var numeral in array)
            {
                Console.WriteLine(numeral);
            }
            return array;
        }
    }
}
