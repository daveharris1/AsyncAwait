using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwaitData.SleepHandler
{
    public interface IThreadTaskSleepHandler
    {
        void Sleep();

        void SleepOne();

        Task<string> SleepAsync();

        Task<string> SleepAsyncOne();
    }
}
