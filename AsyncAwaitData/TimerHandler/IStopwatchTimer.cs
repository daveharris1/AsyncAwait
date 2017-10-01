using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwaitData.TimerHandler
{
    public interface IStopwatchTimer
    {
        void StartStopwatch();

        void StopStopwatch();

        string GetElapsedTime();
    }
}
