using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SimpleWebApp.Logic.Loging
{
    class Logger : ILogger
    {
        string _filePath;

        public Logger(string filePath)
        {
            _filePath = filePath;
        }

        public void SaveLog(ILog log)
        {
            using (StreamWriter outputFile = new StreamWriter(File.Open(_filePath, FileMode.Append)))
            {
                outputFile.WriteLine(log.GetLogInformation());
            }
        }
    }
}
