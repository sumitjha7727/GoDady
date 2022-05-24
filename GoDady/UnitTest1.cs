using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DemoQASite;
using NUnit.Framework;

namespace GoDaddy
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            MaximizeBrowser maximizeBrowser = new MaximizeBrowser();
            maximizeBrowser.MaxAndClose();
        }
    }
}
