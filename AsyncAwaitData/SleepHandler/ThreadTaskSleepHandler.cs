using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitData.SleepHandler
{
    public class ThreadTaskSleepHandler : IThreadTaskSleepHandler
    {
        public void Sleep()
        {
            Thread.Sleep(5000);
        }

        public void SleepOne()
        {
            Thread.Sleep(5000);
        }

        public async Task<string> SleepAsync()
        {
            await Task.Delay(5000);

            return "Delayed for 5 seconds";
        }

        public async Task<string> SleepAsyncOne()
        {
            await Task.Delay(5000);

            return "Delayed for another 5 seconds";
        }


    }
}
