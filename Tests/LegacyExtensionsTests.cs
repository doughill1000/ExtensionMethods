using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringExtensions;


namespace Tests
{
    [TestClass]
    public class LegacyExtensionsTests
    {
        [TestMethod]
        public void ToLegacyFormat_C20()
        {
            var datetime = new DateTime(1920, 12, 31);
            Assert.AreEqual("0201231", datetime.ToLegacyFormat());
        }

        [TestMethod]
        public void ToLegacyFormat_C21()
        {
            var datetime = new DateTime(2013, 10, 31);
            Assert.AreEqual("1131031", datetime.ToLegacyFormat());
        }
    }
}
