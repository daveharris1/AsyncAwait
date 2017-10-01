using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait.FilePathHandler
{
    public interface IFilePathMapper
    {
        string GetFullFilePath(string location);
    }
}
