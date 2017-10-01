using AsyncAwaitData;
using AsyncAwaitData.AsyncawaitModelHandler;
using AsyncAwaitData.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait.Tests
{
    [TestClass]
    public class AsyncawaitModelTypeSelectorTests
    {
        private IModelTypeSelector _modelTypeSelector;

        [TestInitialize]
        public void CreateModelTypeSelector()
        {
            _modelTypeSelector = new ModelTypeSelector();
        }

        [TestMethod]
        public void ModelTypeSelectorShouldReturnAPopulatedAsyncawaitModelWithAPopulatedTaskAwaitMVCDataPropertyWhenSuppliedAnAsyncMvcType()
        {
            string fauxData = "This is Async MVC data";

            AsyncawaitModel asyncAwaitData = _modelTypeSelector.GetAsyncawaitModel(ModelDataTypes.AsyncMvc, fauxData);

            Assert.IsNotNull(asyncAwaitData);

            Assert.AreEqual(fauxData, asyncAwaitData.TaskAwaitMVCData);
        }

        [TestMethod]
        public void ModelTypeSelectorShouldReturnAPopulatedAsyncawaitModelWithAPopulatedMVCDataPropertyWhenSuppliedAMvcType()
        {
            string fauxData = "This is MVC data";

            AsyncawaitModel asyncAwaitData = _modelTypeSelector.GetAsyncawaitModel(ModelDataTypes.Mvc, fauxData);

            Assert.IsNotNull(asyncAwaitData);

            Assert.AreEqual(fauxData, asyncAwaitData.MVCData);
        }

        [TestMethod]
        public void ModelTypeSelectorShouldReturnAPopulatedAsyncawaitModelWithAPopulatedAjaxPropertyWhenSuppliedAAjaxType()
        {
            string fauxData = "This is Ajax data";

            AsyncawaitModel asyncAwaitData = _modelTypeSelector.GetAsyncawaitModel(ModelDataTypes.Ajax, fauxData);

            Assert.IsNotNull(asyncAwaitData);

            Assert.AreEqual(fauxData, asyncAwaitData.AjaxData);
        }
    }
}
