using AsyncAwait.Models;
using AsyncAwaitData;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Diagnostics;
using System;
using AsyncAwaitData.StreamHandler;
using AsyncAwaitData.SleepHandler;
using AsyncAwaitData.AsyncAwaitHandler;
using AsyncAwait.FilePathHandler;
using AsyncAwaitData.Models;

namespace AsyncAwait.Controllers
{
    public class AsyncAwaitController : Controller
    {
        private IAsyncAwaitFacade _asyncAwaitFacade;
        private IFilePathMapper _filePathMapper;

        private string fullPath = string.Empty;

        public AsyncAwaitController(IAsyncAwaitFacade asyncAwaitFacade, IFilePathMapper filePathMapper)
        {
            _asyncAwaitFacade = asyncAwaitFacade;
            _filePathMapper = filePathMapper;

            fullPath = _filePathMapper.GetFullFilePath(@"~/Files/RandomText.txt");
        }

        public ActionResult Index()
        {
            return View("Asyncawaitdemo");
        }

        public async Task<ActionResult> MVCAsyncAwaitGetData()
        {
            Task<AsyncawaitModel> returnedData = _asyncAwaitFacade.MVCAsyncAwaitGetData(fullPath);

            AsyncawaitModel model = await returnedData;

            return View("Asyncawaitdemo", new AsyncawaitVM { TaskAwaitMVCData = model.TaskAwaitMVCData});
        }

        public ActionResult MVCGetData()
        {
            AsyncawaitModel returnedData = _asyncAwaitFacade.MVCGetData(fullPath);

            return View("Asyncawaitdemo", new AsyncawaitVM { MVCData = returnedData.MVCData });
        }

        [HttpGet]
        public JsonResult AjaxGetData()
        {
            AsyncawaitModel returnedData = _asyncAwaitFacade.AjaxGetData(fullPath);

            return Json(new AsyncawaitVM { AjaxData = returnedData.AjaxData }, JsonRequestBehavior.AllowGet);
        }
    }
}