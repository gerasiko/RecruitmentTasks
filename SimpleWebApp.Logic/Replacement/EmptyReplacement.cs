using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWebApp.Logic.Replacement
{
    class EmptyReplacement : IReplacementStrategy
    {
        public string ReplaceOption(string option)
        {
            return option;
        }
    }
}
