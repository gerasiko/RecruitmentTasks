using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWebApp.Logic.Loging
{
    class LogDecorator : ILog
    {
        ILog _log;
        public LogDecorator(ILog log)
        {
            _log = log;
        }

        public virtual string GetLogInformation()
        {
            return _log.GetLogInformation();
        }
    }
}
