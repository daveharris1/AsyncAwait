using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwaitData.TimerHandler
{
    public class StopwatchTimer : IStopwatchTimer
    {
        private Stopwatch _stopWatch;

        public StopwatchTimer()
        {
            _stopWatch = new Stopwatch();
        }

        public string GetElapsedTime()
        {
           return _stopWatch.ElapsedMilliseconds.ToString();
        }

        public void StartStopwatch()
        {
            _stopWatch.Start();
        }

        public void StopStopwatch()
        {
            _stopWatch.Stop();
        }
    }
}
