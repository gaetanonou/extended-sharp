using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExtendedString.Tests
{
    [TestClass]
    public class IsEmptyTests
    {
        [TestMethod]
        public void IsEmpty_Should_ReturnTrue()
        {
            Assert.IsTrue("".IsEmpty());
        }


        [TestMethod]
        public void IsEmpty_Should_ReturnFalse()
        {
            string value = null;
            Assert.IsFalse(value.IsEmpty());
        }
    }
}
