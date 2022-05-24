using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Examples.Adapter_Pattern
{
    public class GoogleDrive
    {
        public void FileDownload(string token,string filename)
        {
            Console.WriteLine("File downloaded from google drive");
        }
    }
}
