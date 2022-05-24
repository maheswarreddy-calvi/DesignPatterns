using DesignPatterns.Examples.Adapter_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Examples.Adapter_Pattern
{
    public class FtpFileAdapter : IFileDownloader
    {
        private readonly string userName;
        private readonly string password;

        public FtpFileAdapter(string userName,string password)
        {
            this.userName = userName;
            this.password = password;
        }

        public void FileDownload(string fileName)
        {
            var ftp = new FtpFile();
            var token=ftp.Authorize(this.userName, this.password);
            ftp.FileDownload(token, fileName);
        }
    }
}
