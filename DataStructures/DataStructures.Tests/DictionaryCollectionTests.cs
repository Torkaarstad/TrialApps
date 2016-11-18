using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DataStructures.Tests
{
    [TestClass]
    public class DictionaryCollectionTests
    {
        //Key is unique
        //Good at searching
        [TestMethod]
        public void Dictionary_Test01_()
        {
            var employeeByName = new Dictionary<string, List<Employee>>();

            employeeByName.Add("Tor", new List<Employee>() {new Employee {Name = "Tor"} });

            Assert.AreEqual("Tor", employeeByName["Tor"][0].Name);
        }

        [TestMethod]
        public void Dictionary_Can_Use_Dictionary_As_Map()
        {
            //Map string to int
            var map = new Dictionary<int, string>();
            map.Add(1, "one");
            map.Add(2, "two");

            Assert.AreEqual("one", map[1]);
        }

        [TestMethod]
        public void Dictionary_Can_Search_Key_With_ContainsKey()
        {
            var map = new Dictionary<int, string>();
            map.Add(1, "one");
            map.Add(2, "two");

            Assert.IsTrue(map.ContainsKey(2));
        }

        [TestMethod]
        public void Dictionary_Can_Remove_By_Key()
        {
            var map = new Dictionary<int, string>();
            map.Add(1, "one");
            map.Add(2, "two");

            map.Remove(1);

            Assert.AreEqual(1, map.Count);
        }
    }
}