using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWebApp.Logic.Replacing
{
    interface IReplacementStrategy
    {
        string ReplaceOption(string option);
    }
}
