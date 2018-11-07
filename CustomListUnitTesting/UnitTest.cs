using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListUnitTest
{
    [TestClass]
    public class UnitTest
    {

        [TestMethod]
        public void AddTestMethod1()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 1;

            // Act
            list.Add(16);

            // Assert
            Assert.AreEqual(expected, list.Count);
        }

        [TestMethod]
        public void AddTestMethod2()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 17;

            // Act
            list.Add(16);
            list.Add(17);

            // Assert
            Assert.AreEqual(expected, list[1]);
        }

        [TestMethod]
        public void AddTestMethod3()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 16;

            // Act
            list.Add(16);
            list.Add(17);

            // Assert
            Assert.AreEqual(expected, list[0]);
        }

        [TestMethod]
        public void AddTestMethod4()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 18;

            // Act
            list.Add(16);
            list.Add(17);
            list.Add(18);

            // Assert
            Assert.AreEqual(expected, list[2]);
        }

        [TestMethod]
        public void AddTestMethod5()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 40;

            // Act
            list.Add(16);
            list.Add(17);
            list.Add(18);
            list.Add(40);

            // Assert
            Assert.AreEqual(expected, list[3]);
        }

        [TestMethod]
        public void AddValue_CheckIndex0_ReturnsSameValue()
        {
            // Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 10;

            // Act
            myList.Add(value);

            // Assert
            Assert.AreEqual(value, myList[0]);
        }

        //[TestMethod]
        //public void Indexer_GetValue_ReturnGetValue()
        //{
        //    // Arrange
        //    CustomList<int> testList = new CustomList<int>();
        //    int i = 0;

        //    //Act
        //    testList.Add(1);

        //    //Assert
        //    Assert.AreEqual(1, testList[i]);
        //}
    }
}
