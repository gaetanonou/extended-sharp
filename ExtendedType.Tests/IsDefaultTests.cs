using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExtendedType.Tests
{
    [TestClass]
    public class IsDefaultTests
    {
        [TestMethod]
        public void IsDefault_TypeString_Should_ReturnTrue()
        {
            string valueString = null;
            Assert.IsTrue(valueString.IsDefault());
        }
    }
}
