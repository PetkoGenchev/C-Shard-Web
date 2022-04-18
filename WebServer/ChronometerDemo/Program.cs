using System;
using System.Text;

namespace ChronometerDemo
{
    public class Program
    {
        static void Main()
        {
            var chronometer = new Chronometer();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "exit")
                {
                    break;
                }

                if (input == "start")
                {
                    chronometer.Start();
                }
                else if (input == "stop")
                {
                    chronometer.Stop();
                }
                else if (input == "lap")
                {
                    var result = chronometer.Lap();
                    Console.WriteLine(result);

                }
                else if (input == "laps")
                {
                    var laps = chronometer.Laps;

                    if (laps.Count == 0)
                    {
                        Console.WriteLine("Laps: no laps");
                        continue;
                    }

                    var sb = new StringBuilder();

                    sb.AppendLine("Laps:");

                    for (int i = 0; i < laps.Count; i++)
                    {
                        sb.AppendLine($"{i}. {laps[i]}");
                    }
                    Console.WriteLine(sb.ToString().TrimEnd()); 
                }
                else if (input == "time")
                {
                    Console.WriteLine(chronometer.GetTime);
                }
                else if (input == "reset")
                {
                    chronometer.Reset();
                }
            }
        }
    }
}
