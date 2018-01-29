using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;


namespace SimpleWebApp.Logic.Replacing
{
    class Replacer : IReplacer
    {
        private ReplacementOption replacementOptions;

        public Replacer()
        {
            replacementOptions = new ReplacementOption();
        }

        public string GetReplacedOption(string option)
        {
            StringBuilder newOption = new StringBuilder();
            char[] splitedOption = option.ToCharArray();
            int i = 0;
            while (i < option.Length)
            {
                if (Char.IsDigit(splitedOption[i]))
                    newOption.Append(replacementOptions.Replace(OptionPartTypes.NUMBER, GetWholeNumber(ref i, splitedOption)));
                else
                    newOption.Append(replacementOptions.Replace(OptionPartTypes.WORD, GetWholeWord(ref i, splitedOption)));
            }

            return newOption.ToString();
        }

        private string GetWholeNumber(ref int index, char[] splitedOption)
        {
            StringBuilder numberOption = new StringBuilder();
            do
            {
                if (!Char.IsDigit(splitedOption[index]))
                    break;
                numberOption.Append(splitedOption[index]);
                index++;
            } while (index < splitedOption.Length);

            return numberOption.ToString();
        }

        private string GetWholeWord(ref int index, char[] splitedOption)
        {
            StringBuilder wordOption = new StringBuilder();
            do
            {
                if (Char.IsDigit(splitedOption[index]))
                    break;
                wordOption.Append(splitedOption[index]);
                index++;
            } while (index < splitedOption.Length);

            return wordOption.ToString();
        }
    }
}
