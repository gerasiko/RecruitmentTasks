using SimpleWebApp.Logic.Replacing;
using System;
using System.Text;
using System.Runtime.CompilerServices;
using SimpleWebApp.Logic.Loging;

[assembly: InternalsVisibleTo("SimpleWebApp.Tests")]

namespace SimpleWebApp.Logic
{
    public class OptionGenerator : IOptionGenerator
    {
        private IReplacer _replacer;
        private ILogger _logger;

        public OptionGenerator(string filePathForLogger)
        {
            _replacer = new Replacer();
            _logger = new Logger(filePathForLogger);
        }

        public string GenerateOption(string option)
        {
            string newOption = String.Empty;
            try
            {
                newOption = _replacer.GetReplacedOption(option);
                _logger.SaveLog(new DateTimeDecorator(new SavingLog(option, newOption)));
            }
            catch (Exception ex)
            {
                _logger.SaveLog(new DateTimeDecorator(new ExceptionLog(ex)));
            }
            return newOption;
        }


    }
}
