using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Examples.Adapter_Pattern
{
    public class IAuthToken
    {
        public string UserName { get; set; }

        public string Token { get; set; }
    }

    public class FtpFile
    {
        public IAuthToken Authorize(string userName, string password)
        {
            if (!string.IsNullOrEmpty(password))
            {
                return new IAuthToken
                {
                    UserName = userName,
                    Token = System.Guid.NewGuid().ToString()
                };
            }
            return null;
        }

        public void FileDownload(IAuthToken authToken, string filename)
        {
            Console.WriteLine("File downloaded from Ftp file system");
        }
    }
}
