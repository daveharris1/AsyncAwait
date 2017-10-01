using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitData.StreamHandler
{
    public class StreamReaderHandler : IStreamReaderHandler
    {
        public async Task<string> ReadFileAsync(string filePath)
        {
            await Task.Delay(10000);

            string result = string.Empty;

            using (StreamReader reader = new StreamReader(filePath))
            {
                result = await reader.ReadToEndAsync();
            }
            return result;
        }

        public string ReadFile(string filePath)
        {
            Thread.Sleep(10000);

            string result = string.Empty;

            using (StreamReader reader = new StreamReader(filePath))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }
    }
}
