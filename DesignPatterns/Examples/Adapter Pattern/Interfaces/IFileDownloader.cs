using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Examples.Adapter_Pattern.Interfaces
{
    public interface IFileDownloader
    {
        void FileDownload(string fileName);
    }
}
