using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsyncAwaitData.Models;

namespace AsyncAwaitData.AsyncawaitModelHandler
{
    public class ModelTypeSelector : IModelTypeSelector
    {
        public AsyncawaitModel GetAsyncawaitModel(string dataType, string data)
        {
            AsyncawaitModel asyncawaitModelData = null;

            if(dataType == ModelDataTypes.AsyncMvc)
            {
                asyncawaitModelData = new AsyncawaitModel { TaskAwaitMVCData = data };
            }
            if (dataType == ModelDataTypes.Mvc)
            {
                asyncawaitModelData = new AsyncawaitModel { MVCData = data };
            }
            if (dataType == ModelDataTypes.Ajax)
            {
                asyncawaitModelData = new AsyncawaitModel { AjaxData = data};
            }

            return asyncawaitModelData;
        }
    }
}
