using Luhn.Core;
using NUnit.Framework;

namespace Luhn.Test
{
    [TestFixture]
    public class LuhnCheckerTests
    {
        [TestCase("hello world", false)]
        [TestCase("4062001210012105", true)]
        [TestCase("5454545454545454", true)]
        [TestCase("5454545454545455", false)]
        [TestCase(null, false)]
        public void Validate(string input, bool expectValid)
        {
            Assert.AreEqual(expectValid, LuhnChecker.Validate(input));
        }
    }
}