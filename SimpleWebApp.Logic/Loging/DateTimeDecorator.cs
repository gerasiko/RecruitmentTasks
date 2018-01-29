using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWebApp.Logic.Loging
{
    class DateTimeDecorator : LogDecorator
    {
        public DateTimeDecorator(ILog log) : base(log)
        {
        }

        public override string GetLogInformation()
        {
            StringBuilder logMsg = new StringBuilder();
            logMsg.Append("[");
            logMsg.Append(DateTime.UtcNow.ToString());
            logMsg.Append("] ");
            logMsg.Append(base.GetLogInformation());
            return logMsg.ToString();
        }
    }
}
