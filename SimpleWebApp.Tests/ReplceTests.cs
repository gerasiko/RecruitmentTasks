using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleWebApp.Logic.Replacing;
using System;

namespace SimpleWebApp.Tests
{
    [TestClass]
    public class ReplceTests
    {
        [TestMethod]
        public void ReplaceNumber()
        {
            NumberReplacement numberNormalizationStrategy = new NumberReplacement();
            Assert.AreEqual(numberNormalizationStrategy.ReplaceOption(Int64.MaxValue.ToString()), "0x7FFFFFFFFFFFFFFF");
        }

        [TestMethod]
        public void ReplaceLetter()
        {
            LetterReplacement letterNormalizationStrategy = new LetterReplacement();
            Assert.AreEqual(letterNormalizationStrategy.ReplaceOption("πÊÍ≥ÒÛúøü•∆ £—”åØè"), "acelnoszzACELNOSZZ");
        }
    }
}
