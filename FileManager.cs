using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;
using System.Net;


namespace SemesterWork
{
    public class FileManager
    {
        public static byte[] getFile(string rawUrl, ServerSettings _serverSetting)
        {
            byte[] buffer = null;
            var filePath = _serverSetting.Path + rawUrl;

            if (Directory.Exists(filePath))
            {

                filePath = filePath + "main-page/index.html";

                if (File.Exists(filePath))
                {
                    //Console.WriteLine(filePath);
                    buffer = File.ReadAllBytes(filePath);
                }

            }
            else if (File.Exists(filePath))
                buffer = File.ReadAllBytes(filePath);
            return buffer;
        }
    }
}
