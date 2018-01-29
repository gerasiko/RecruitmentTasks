using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWebApp.Logic.Replacing
{
    public class ReplacementFactory
    {
        private IReplacementStrategy numberNormalizationStrategy = new NumberReplacement();
        private IReplacementStrategy letterNormalizationStrategy = new LetterReplacement();
        private IReplacementStrategy emptyNormalizationStategy = new EmptyReplacement();

        internal IReplacementStrategy GetReplacementFactoryStrategy(OptionPartTypes optionType)
        {
            switch (optionType)
            {
                case OptionPartTypes.NUMBER: return numberNormalizationStrategy;
                case OptionPartTypes.WORD: return letterNormalizationStrategy;
                default: return emptyNormalizationStategy;
            }
        }
    }
}
