using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    public class StopWatch
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan TimeSpan { get; set; }
        public DateTime StartWatch()
        {
            StartTime = DateTime.Now;
            return StartTime;
        }
        public DateTime EndWatch()
        {
            EndTime = DateTime.Now;
            return EndTime;
        }
        public TimeSpan Duration()
        {
            TimeSpan span = EndTime - StartTime;
            TimeSpan = span;
            return TimeSpan;
        }
        public void RunStopWatch()
        {
            Console.WriteLine("Welcome to the Stop Watch!");
            Console.WriteLine("Please press ENTER to begin...");
            Console.ReadLine();

            var stopWatch = new StopWatch();
            Console.WriteLine(stopWatch.StartWatch());

            Console.WriteLine("The Stop Watch has begun!");
            Console.WriteLine("When you are ready to stop the Stop Watch, please press ENTER...");
            Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("The final stop time was...");
            Console.WriteLine(stopWatch.EndWatch());

            Console.WriteLine();
            Console.WriteLine("The duration of the Stop Watch was...");
            Console.WriteLine(stopWatch.Duration());

            Console.ReadLine();
        }
        public void LoopStopWatch()
        {
            bool endWatchValid = false;
            do
            {
                bool userChoiceValid = false;
                while (!userChoiceValid)
                {
                    Console.WriteLine();
                    Console.WriteLine("Would you like to run the stop watch again?");
                    Console.WriteLine("Please press 1 for YES or 2 for NO.");
                    var isLooping = int.TryParse(Console.ReadLine(), out int userInput);
                    if (isLooping && (userInput == 1 || userInput == 2))
                    {
                        switch (userInput)
                        {
                            case 1:
                                endWatchValid = false;
                                userChoiceValid = false;
                                RunStopWatch();
                                break;
                            case 2:
                                endWatchValid = true;
                                userChoiceValid = true;
                                break;
                            default:
                                endWatchValid = false;
                                userChoiceValid = false;
                                break;
                        }
                    }
                    else
                    {
                        userChoiceValid = false;
                    }

                }

            } while (!endWatchValid);
        }
    }
}
