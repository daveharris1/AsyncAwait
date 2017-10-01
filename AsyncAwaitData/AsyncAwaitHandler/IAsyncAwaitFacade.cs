using AsyncAwaitData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwaitData.AsyncAwaitHandler
{
    public interface IAsyncAwaitFacade
    {
        Task<AsyncawaitModel> MVCAsyncAwaitGetData(string fileLocation);

        AsyncawaitModel MVCGetData(string fileLocation);

        AsyncawaitModel AjaxGetData(string fileLocation);
    }
}
