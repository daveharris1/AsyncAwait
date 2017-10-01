using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsyncAwaitData.Models;
using AsyncAwaitData.StreamHandler;
using AsyncAwaitData.SleepHandler;
using AsyncAwaitData.TimerHandler;
using AsyncAwaitData.AsyncawaitModelHandler;

namespace AsyncAwaitData.AsyncAwaitHandler
{
    public class AsyncAwaitFacade : IAsyncAwaitFacade
    {
        private IStreamReaderHandler _streamReaderHandler;
        private IThreadTaskSleepHandler _timerHandler;
        private IStopwatchTimer _stopWatchTimer;

        private IModelTypeSelector _modelTypeSelector;

        public AsyncAwaitFacade(IStreamReaderHandler streamReaderHandler, IThreadTaskSleepHandler timerHandler, IStopwatchTimer stopWatchTimer, IModelTypeSelector modelTypeSelector)
        {
            _streamReaderHandler = streamReaderHandler;
            _timerHandler = timerHandler;
            _stopWatchTimer = stopWatchTimer;
            _modelTypeSelector = modelTypeSelector;
        }

        public AsyncawaitModel AjaxGetData(string fileLocation)
        {
            return GetNonAsyncData(fileLocation, ModelDataTypes.Ajax);
        }

        public async Task<AsyncawaitModel> MVCAsyncAwaitGetData(string fileLocation)
        {
            _stopWatchTimer.StartStopwatch();

            Task<string> task = _streamReaderHandler.ReadFileAsync(fileLocation);

            string result = await task;

            Task<string> returnedSleepTask = _timerHandler.SleepAsync();

            string sleepMessage = await returnedSleepTask;

            Task<string> returnedSleepTaskOne = _timerHandler.SleepAsyncOne();

            string sleepMessageOne = await returnedSleepTask;

            _stopWatchTimer.StartStopwatch();

            var elapsedMs = _stopWatchTimer.GetElapsedTime();

            return _modelTypeSelector.GetAsyncawaitModel(ModelDataTypes.AsyncMvc, "Execution time was: " + elapsedMs + ". First Async sleep time was: " + sleepMessage + ". Second Async sleep time was:" + sleepMessageOne + " " + result);
        }

        public AsyncawaitModel MVCGetData(string fileLocation)
        {
            return GetNonAsyncData(fileLocation, ModelDataTypes.Mvc);
        }

        private AsyncawaitModel GetNonAsyncData(string fileLocation, string type)
        {
            _stopWatchTimer.StartStopwatch();

            string result = _streamReaderHandler.ReadFile(fileLocation);

            _timerHandler.Sleep();

            _timerHandler.SleepOne();

            _stopWatchTimer.StopStopwatch();

            var elapsedMs = _stopWatchTimer.GetElapsedTime();

            return _modelTypeSelector.GetAsyncawaitModel(type, "Execution time was: " + elapsedMs + " " + result);
        }
    }
}
