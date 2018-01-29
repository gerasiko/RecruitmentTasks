using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWebApp.Logic.Replacing
{
    class ReplacementOption
    {
        private ReplacementFactory replacementFactory = new ReplacementFactory();
        public string Replace(OptionPartTypes optionType, string optionPart)
        {
            IReplacementStrategy replacementStrategy = replacementFactory.GetReplacementFactoryStrategy(optionType);
            return replacementStrategy.ReplaceOption(optionPart);
        }
    }
}
