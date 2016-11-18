using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Tests
{
    [TestClass]
    public class LinkedListCollectionTests
    {
        //Strength: Methods for inserting and removing.
        [TestMethod]
        public void LinkedList_AddItems()
        {
            var list = new LinkedList<int>();
            list.AddFirst(1);
            list.AddLast(99);
            list.AddAfter(list.First, 2);

            //1, 2, 99
            Assert.AreEqual(2, list.First.Next.Value);
        }

        [TestMethod]
        public void LinkedList_Can_Add_After()
        {
            var list = new LinkedList<string>();
            list.AddFirst("Hello");
            list.AddLast("World");
            list.AddAfter(list.First, "there");

            //Hello, there, World
            Assert.AreEqual("there", list.First.Next.Value);
        }

        [TestMethod]
        public void LinkedList_Can_Remove_Last()
        {
            var list = new LinkedList<string>();
            list.AddFirst("Hello");
            list.AddLast("World");
            list.RemoveLast();

            Assert.AreEqual(list.First, list.Last);
        }

        [TestMethod]
        public void LinkedList_Can_Find_Items()
        {
            var list = new LinkedList<string>();
            list.AddFirst("Hello");
            list.AddLast("World");

            Assert.IsTrue(list.Contains("Hello"));
        }
    }
}