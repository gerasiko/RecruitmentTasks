using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWebApp.Logic.Replacement
{
    interface IReplacementStrategy
    {
        string ReplaceOption(string option);
    }
}
