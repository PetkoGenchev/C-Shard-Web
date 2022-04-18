using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChronometerDemo
{
    public class Chronometer : IChronometer
    {
        Stopwatch stopWatch = new Stopwatch();

        private readonly List<string> TestLaps; 

        public Chronometer()
        {
            this.TestLaps = new List<string>();
        }

        public string GetTime => String.Format("{0:00}:{1:00}.{2:0000}",
            stopWatch.Elapsed.Minutes, stopWatch.Elapsed.Seconds, stopWatch.Elapsed.Milliseconds);


        public List<string> Laps => this.TestLaps;

        public string Lap()
        {

            string elapsedTime = String.Format("{0:00}:{1:00}.{2:0000}",
            stopWatch.Elapsed.Minutes, stopWatch.Elapsed.Seconds, stopWatch.Elapsed.Milliseconds);

            TestLaps.Add(elapsedTime);

            return elapsedTime;
        }

        public void Reset()
        {
            stopWatch.Reset();
        }

        public void Start()
        {
            stopWatch.Start();
        }


        public void Stop()
        {
            stopWatch.Stop();
        }
    }
}
