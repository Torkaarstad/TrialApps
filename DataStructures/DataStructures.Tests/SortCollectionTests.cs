using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Tests
{
    [TestClass]
    public class SortCollectionTests
    {

        [TestMethod]
        public void SortedDictionary()
        {
            //Efficient insert and removal
            var employeeByName = new SortedDictionary<string, List<Employee>>();

            employeeByName.Add("Sales", new List<Employee>() { new Employee(), new Employee(), new Employee() });
            employeeByName.Add("Engineering", new List<Employee>() { new Employee(), new Employee()});

            Assert.AreEqual(2, employeeByName["Engineering"].Count);
            Assert.AreEqual("Engineering", employeeByName.First().Key);
        }
        [TestMethod]
        public void SortList_Can_Use_Sorted_List()
        {
            //Efficient in looping...
            var list = new SortedList<int, string>();

            list.Add(3, "three");
            list.Add(1, "one");
            list.Add(2, "two");

            Assert.AreEqual(0, list.IndexOfKey(1));
            Assert.AreEqual(1, list.IndexOfValue("two"));
        }

        [TestMethod]
        public void SortSet_Can_Use_Sorted_Set()
        {
            var set = new SortedSet<int>();

            set.Add(3);
            set.Add(1);
            set.Add(2);

            var enumerator = set.GetEnumerator();
            enumerator.MoveNext();
            Assert.AreEqual(enumerator.Current, 1);
        }
    }
}
