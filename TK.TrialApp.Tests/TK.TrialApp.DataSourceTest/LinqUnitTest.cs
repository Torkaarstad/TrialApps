using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TK.TrialApp.DataSource;

namespace TK.TrialApp.DataSourceTest
{
    [TestClass]
    public class LinqUnitTest
    {
        private LinqSamples _samples;

        [TestInitialize]
        public void Setup()
        {
            _samples = new LinqSamples();
        }

        [TestMethod]
        public void TestMethod1()
        {
            _samples.Linq102();
        }
    }
}
