using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWebApp.Logic.Replacing
{
    class NumberReplacement : IReplacementStrategy
    {
        public string ReplaceOption(string option)
        {
            long number;
            if (!Int64.TryParse(option, out number))
                return option;

            return number.ToString("X");
        }
    }
}
