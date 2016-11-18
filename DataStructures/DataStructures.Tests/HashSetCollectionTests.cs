using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DataStructures;

namespace DataStructures.Tests
{
    [TestClass]
    public class HashSetCollectionTests
    {
        //HshSet is:
        //UNIQ item in collection. Does not allow duplicates
        [TestMethod]
        public void HashSet_Create_Sets()
        {
            var set = new HashSet<int>();
            bool b = set.Add(1);
            Assert.IsTrue(b);

            b = set.Add(2);
            Assert.IsTrue(b);

            b = set.Add(2); //This will not be added since it already exsist in the collection
            Assert.IsFalse(b);

            int i = 0;
            foreach (var item in set)
            {
                //Do something
                i++;
                //
            }
            Assert.AreEqual(set.Count, 2);
            Assert.IsTrue(set.SetEquals(new[] { 1, 2 }));
        }

        [TestMethod]
        public void HashSet_Intersect_Sets()
        {
            //UNIQ item in collection. Does not allow duplicates
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.IntersectWith(set2);

            Assert.IsTrue(set1.SetEquals(new[] { 2, 3 }));
        }

        [TestMethod]
        public void HashSet_Union_Sets()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.UnionWith(set2);

            Assert.IsTrue(set1.SetEquals(new[] { 1, 2, 3, 4 }));
        }

        [TestMethod]
        public void HashSet_SymmetricExceptWith_Sets()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.SymmetricExceptWith(set2);

            Assert.IsTrue(set1.SetEquals(new[] { 1, 4 }));
        }

        [TestMethod]
        public void HashSet_Add2DifferentEmployee_Sets()
        {
            var set = new HashSet<Employee>();

            bool b = set.Add(new Employee { Name = "Tor" });
            Assert.IsTrue(b);

            //NOTE: Equal content is added to HasSet!!!
            //BECAUSE: Two different objects/references. 
            //HashSet does not know how to compare

            b = set.Add(new Employee { Name = "Tor" });
            Assert.IsTrue(b);

            //SAME OBJECT REFERENCE:
        }
        [TestMethod]
        public void HashSet_AddSameEmployeeTwice_Sets()
        {
            var set = new HashSet<Employee>();

            var employee = new Employee {Name = "Tor"};
            bool b = set.Add(employee);
            Assert.IsTrue(b);

            b = set.Add(employee);
            Assert.IsFalse(b); //SAME OBJECT REFERENCE
        }
    }
}
