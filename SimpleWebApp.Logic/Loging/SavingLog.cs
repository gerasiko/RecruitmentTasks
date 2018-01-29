using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWebApp.Logic.Loging
{
    class SavingLog : ILog
    {
        string _oldValue;
        string _newValue;

        public SavingLog(string oldValue, string newValue)
        {
            _oldValue = oldValue;
            _newValue = newValue;
        }
        public string GetLogInformation()
        {
            return "Wartosc " + _oldValue + " została dodana do listy rozwijalnej jako: " + _newValue;
        }
    }
}
