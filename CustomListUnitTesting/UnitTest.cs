using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListUnitTest
{
    [TestClass]
    public class UnitTest
    {
        // ADD TESTS--------------------------------------------------

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

        // REMOVE TESTS--------------------------------------------------

        [TestMethod]
        public void Remove_IntFromList_ReturnsInt()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 17;

            // Act
            list.Add(16);
            list.Add(17);
            list.Add(18);
            list.Add(40);
            list.Remove(16);

            // Assert
            Assert.AreEqual(expected, list[0]);
        }

        [TestMethod]
        public void Remove_IntFromList_ReturnsInt2()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 30;

            // Act
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            list.Add(60);
            list.Add(70);
            list.Add(80);
            list.Remove(20);

            // Assert
            Assert.AreEqual(expected, list[1]);
        }

        [TestMethod]
        public void Remove_IntFromList_ReturnsInt3()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 40;

            // Act
            list.Add(16);
            list.Add(17);
            list.Add(18);
            list.Add(40);
            list.Remove(17);
            list.Remove(18);
            

            // Assert
            Assert.AreEqual(expected, list[1]);
        }


        [TestMethod]
        public void Remove_TwoStringsFromList_ReturnsOneString()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>();
            string expected = "goose";

            // Act
            list.Add("maverick");
            list.Add("iceman");
            list.Add("goose");
            list.Remove("maverick");
            list.Remove("iceman");

            // Assert
            Assert.AreEqual(expected, list[0]);
        }

        [TestMethod]
        public void Remove_StringFromList_Remove1String()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>();
            string expected = "String 2.";

            // Act
            list.Add("String 1.");
            list.Add("String 2.");
            list.Add("String 3.");
            list.Add("String 4.");
            list.Remove("String 1."); //Removes matching item and remaining content shifts forward on list.


            // Assert
            Assert.AreEqual(expected, list[0]); //Content at index after removing one item.
        }

        [TestMethod]

        public void ToString_ConvertIntToString_ReturnsString()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            string expected = "4 20";
            int num1 = 4;
            int num2 = 20;

            // Act
            list.Add(num1);
            list.Add(num2);
            string intoWords = list.ToString();

            // Assert
            Assert.AreEqual(expected, intoWords);


        }
    }
}
