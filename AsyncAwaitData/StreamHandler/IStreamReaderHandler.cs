using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwaitData.StreamHandler
{
    public interface IStreamReaderHandler
    {
        Task<string> ReadFileAsync(string filePath);


        string ReadFile(string filePath);
    }
}
