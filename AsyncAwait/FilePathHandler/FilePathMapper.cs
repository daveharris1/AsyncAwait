using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AsyncAwait.FilePathHandler
{
    public class FilePathMapper : IFilePathMapper
    {
        public string GetFullFilePath(string location)
        {
            return System.Web.Hosting.HostingEnvironment.MapPath(location); ;
        }
    }
}