using DesignPatterns.Examples.Adapter_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Examples.Adapter_Pattern
{
    public class GoogleDriveAdapter : IFileDownloader
    {
        public void FileDownload(string fileName)
        {
            //Get token from appsettings.json/create token
            string token = System.Guid.NewGuid().ToString();
            new GoogleDrive().FileDownload(token, fileName);
        }
    }
}
