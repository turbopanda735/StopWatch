
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    public class Program
    {
        public static void Main()
        {
            var randomArrayAverage = new RandomArrayAverage();

            var doubleArray = randomArrayAverage.ArrayFiller();

            Console.WriteLine(randomArrayAverage.ArrayAverage(doubleArray));

            Console.WriteLine();
            var stopWatch = new StopWatch();
            stopWatch.RunStopWatch();
            stopWatch.LoopStopWatch();
        }
    }
}
