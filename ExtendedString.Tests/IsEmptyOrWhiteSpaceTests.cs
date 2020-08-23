using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExtendedString.Tests
{
    [TestClass]
    public class IsEmptyOrWhiteSpaceTests
    {
        [TestMethod]
        public void IsEmptyOrWhiteSpace_Should_ReturnTrue()
        {
            Assert.IsTrue("   ".IsWhiteSpace());
        }
    }
}
