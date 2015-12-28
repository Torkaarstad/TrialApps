using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TK.TrialApp.DataSource;
using Moq;

namespace TK.TrialApp.DataSourceTest
{
    [TestClass]
    public class LinqUnitTest
    {
        private static readonly NLog.Logger _log = NLog.LogManager.GetCurrentClassLogger();
        private LinqSamples _samples;

        [TestInitialize]
        public void Setup()
        {
            _samples = new LinqSamples();
        }

        [TestMethod]
        public void TestMethod102()
        {
            _samples.Linq102();
        }

        [TestMethod]
        public void TestMethod999()
        {
            _samples.Linq999();
        }

        [TestMethod]
        public void BuildIntSequenceTest()
        {
            RegisterBuilder listBuilder = new RegisterBuilder();

            var result = listBuilder.BuildIntegerSequence();

            foreach (var item in result)
                _log.Info(item);

            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void BuildStringSequenceTest()
        {
            RegisterBuilder listBuilder = new RegisterBuilder();

            var result = listBuilder.BuildStringSequence();

            foreach (var item in result)
                _log.Info(item);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void BuildCompareSequenceTest()
        {
            RegisterBuilder listBuilder = new RegisterBuilder();

            var result = listBuilder.CompareSequence();

            foreach (var item in result)
                _log.Info(item);

            Assert.IsNotNull(result);
        }



    }
}
