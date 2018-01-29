using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWebApp.Logic.Loging
{
    class ExceptionLog : ILog
    {
        Exception _ex;

        public ExceptionLog(Exception ex)
        {
            _ex = ex;
        }
        public string GetLogInformation()
        {
            return _ex.Message;
        }
    }
}
