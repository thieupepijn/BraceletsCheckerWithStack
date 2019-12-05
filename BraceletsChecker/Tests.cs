using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BraceletsChecker
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void ValidBraceletLinesTest()
        {
            Assert.IsTrue(Util.CorrectlyFormedBraceletsLine("[()]"));
            Assert.IsTrue(Util.CorrectlyFormedBraceletsLine("[()][[]]()"));
            Assert.IsTrue(Util.CorrectlyFormedBraceletsLine("([()][[]]())"));
        }
        [TestMethod]
        public void InValidBraceletLinesTest()
        {
            Assert.IsFalse(Util.CorrectlyFormedBraceletsLine("[()]["));
            Assert.IsFalse(Util.CorrectlyFormedBraceletsLine("[()][[]]()("));
            Assert.IsFalse(Util.CorrectlyFormedBraceletsLine(")"));
            Assert.IsFalse(Util.CorrectlyFormedBraceletsLine("())"));
            Assert.IsFalse(Util.CorrectlyFormedBraceletsLine("((([[999"));
            Assert.IsFalse(Util.CorrectlyFormedBraceletsLine("()99"));
        }



    }
}
