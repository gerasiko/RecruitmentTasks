using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SimpleWebApp.Logic.Replacing
{
    class LetterReplacement : IReplacementStrategy
    {
        public string ReplaceOption(string option)
        {
            if (string.IsNullOrEmpty(option))
            {
                return string.Empty;
            }

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            return Encoding.ASCII.GetString(
            Encoding.GetEncoding("koi8-r").GetBytes(option));
        }
    }
}
