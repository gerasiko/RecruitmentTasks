using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWebApp.Logic.Replacing
{
    class EmptyReplacement : IReplacementStrategy
    {
        public string ReplaceOption(string option)
        {
            return option;
        }
    }
}
