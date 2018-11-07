using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListUnitTesting
{
    [TestClass]
    public class AddTestMethod
    {

        [TestMethod]
        public void AddTestMethod1()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 1;

            //Act
            list.Add(16);

            //Assert
            Assert.AreEqual(expected, list.Count);
        }

        [TestMethod]
        public void AddTestMethod2()
        {
            CustomList<int> list = new CustomList<int>();
            int expected = 17;

            list.Add(16);
            list.Add(17);

            Assert.AreEqual(expected, list[1]);
        }

        [TestMethod]
        public void AddVariable_CheckIndex0_ReturnsSameVariable()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 10;

            //Act
            myList.Add(value);

            //Assert
            Assert.AreEqual(value, myList[0]);
        }
        //[TestMethod]
        //public void Indexer_GetValue_ReturnGetValue()
        //{
        //    //Arrange
        //    CustomList<int> testList = new CustomList<int>();
        //    int i = 0;

        //    //Act
        //    testList.Add(1);

        //    //Assert
        //    Assert.AreEqual(1, testList[i]);
        //}
    }
}
