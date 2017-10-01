using AsyncAwaitData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwaitData.AsyncawaitModelHandler
{
    public interface IModelTypeSelector
    {
        AsyncawaitModel GetAsyncawaitModel(string dataType, string data);
    }
}
