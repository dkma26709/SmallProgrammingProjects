using Abtion_WordSorting_Assignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        WordSorting sorter;

        [TestInitialize]
        public void Initialize()
        {
            sorter = new WordSorting();
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("appyhay", sorter.OneConsonantSortV1("happy"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("appyhay", sorter.OneConsonantSortV2("happy"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("happyay", sorter.TwoConsonantSort("happy"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual("appyhhay", sorter.TwoConsonantSort("hhappy"));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual("appyhay", sorter.ConsonantSort(1,"happy"));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual("happyay", sorter.ConsonantSort(2, "happy"));
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual("appyhhay", sorter.ConsonantSort(2, "hhappy"));
        }
    }
}
