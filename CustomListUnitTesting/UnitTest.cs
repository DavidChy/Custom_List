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

        [TestMethod]
        public void AddOperator_CheckCombine()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list2.Add(4);
            list2.Add(5);
            list2.Add(6);
            int expectedResult = 1;

            //Act
            CustomList<int> actualResult = list1 + list2;

            //Assert
            Assert.AreEqual(expectedResult, actualResult[0]);
        }

        [TestMethod]
        public void AdditionOperator_CheckIfListsCombineCorrectlyAtIndex1()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3 = new CustomList<int>();
            test1.Add(1);
            test1.Add(2);
            test1.Add(3);
            test2.Add(4);
            test2.Add(5);
            test2.Add(6);
            int expectedResult = 2;

            //Act
            test3 = test1 + test2;
            int actualResult = test3[1];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AdditionOperator_CheckIfListsCombineCorrectlyAtIndex3()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3 = new CustomList<int>();
            test1.Add(1);
            test1.Add(2);
            test1.Add(3);
            test2.Add(4);
            test2.Add(5);
            test2.Add(6);
            int expectedResult = 4;

            //Act
            test3 = test1 + test2;
            int actualResult = test3[3];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AdditionOperator_CheckIfListsCombineCorrectlyAtIndex5()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3 = new CustomList<int>();
            test1.Add(1);
            test1.Add(2);
            test1.Add(3);
            test2.Add(4);
            test2.Add(5);
            test2.Add(6);
            int expectedResult = 6;

            //Act
            test3 = test1 + test2;
            int actualResult = test3[5];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AdditionOperator_CheckIfListsCombineCorrectlyAtIndex12()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3 = new CustomList<int>();
            test1.Add(1);
            test1.Add(2);
            test1.Add(3);
            test2.Add(4);
            test2.Add(5);
            test2.Add(6);
            test1.Add(7);
            test1.Add(8);
            test1.Add(9);
            test2.Add(10);
            test2.Add(11);
            test2.Add(12);
            test2.Add(13);
            int expectedResult = 13;

            //Act
            test3 = test1 + test2;
            int actualResult = test3[12];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SubtractOperator_CheckIfListsSubractCorrectlyAtIndex0()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3;
            test1.Add(1);
            test1.Add(2);
            test1.Add(3);
            test1.Add(4);
            test2.Add(2);
            test2.Add(4);
            test2.Add(6);
            test2.Add(8);
            int expectedResult = 0;

            //Act
            test3 = test1 - test2;
            int actualResult = test3[0];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SubtractOperator_CheckIfListsSubractCorrectlyAtIndex1()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3;
            test1.Add(1);
            test1.Add(2);
            test1.Add(3);
            test1.Add(4);
            test2.Add(2);
            test2.Add(4);
            test2.Add(6);
            test2.Add(8);
            test2.Add(10);
            test2.Add(12);
            int expectedResult = 12;

            //Act
            test3 = test1 - test2;
            int actualResult = test3[1];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SubtractOperator_CheckIfListsSubractCorrectlyAtIndex1Again()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3;
            test1.Add(1);
            test1.Add(2);
            test1.Add(3);
            test1.Add(4);
            test1.Add(5);
            test1.Add(7);
            test2.Add(2);
            test2.Add(4);
            test2.Add(6);
            test2.Add(8);
            int expectedResult = 7;

            //Act
            test3 = test1 - test2;
            int actualResult = test3[1];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SubtractOperator_CheckIfListsSubractCorrectlyAtIndex5()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3;
            test1.Add(1);
            test1.Add(2);
            test1.Add(3);
            test1.Add(4);
            test2.Add(5);
            test2.Add(6);
            test2.Add(7);
            test2.Add(8);
            test2.Add(2);
            test2.Add(4);
            test2.Add(6);
            test2.Add(8);
            test2.Add(10);
            test2.Add(12);
            int expectedResult = 12;

            //Act
            test3 = test1 - test2;
            int actualResult = test3[5];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToString_CheckIfCombinesCorrectly1()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            test1.Add(1);
            test1.Add(2);
            test1.Add(3);
            string expectedValue = "123";

            //Act
            string actualValue = test1.ToString();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void ToString_CheckIfCombinesCorrectly2()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            test1.Add(1);
            test1.Add(2);
            test1.Add(3);
            test1.Add(4);
            test1.Add(5);
            test1.Add(6);
            test1.Add(7);
            test1.Add(8);
            test1.Add(9);
            string expectedValue = "123456789";

            //Act
            string actualValue = test1.ToString();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Zip_CheckAtIndex1()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3 = new CustomList<int>();
            test1.Add(1);
            test1.Add(3);
            test1.Add(5);
            test2.Add(2);
            test2.Add(4);
            test2.Add(6);
            int expectedValue = 2;

            //Act
            test3 = test1.Zip(test2);
            int actualValue = test3[1];

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Zip_CheckAtIndex4()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3 = new CustomList<int>();
            test1.Add(1);
            test1.Add(3);
            test1.Add(5);
            test2.Add(2);
            test2.Add(4);
            test2.Add(6);
            int expectedValue = 5;

            //Act
            test3 = test1.Zip(test2);
            int actualValue = test3[4];

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Zip_ListsOfDifferentSizesAtIndex7()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3 = new CustomList<int>();
            test1.Add(1);
            test1.Add(3);
            test1.Add(5);
            test2.Add(2);
            test2.Add(4);
            test2.Add(6);
            test2.Add(7);
            test2.Add(8);
            int expectedValue = 8;

            //Act
            test3 = test1.Zip(test2);
            int actualValue = test3[7];

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Zip_ListsOfDifferentSizesAtIndex12()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3 = new CustomList<int>();
            test1.Add(1);
            test1.Add(3);
            test1.Add(5);
            test2.Add(2);
            test2.Add(4);
            test2.Add(6);
            test2.Add(7);
            test2.Add(8);
            test2.Add(9);
            test2.Add(10);
            test2.Add(11);
            test2.Add(12);
            test2.Add(13);
            int expectedValue = 13;

            //Act
            test3 = test1.Zip(test2);
            int actualValue = test3[12];

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Zip_ListsOfDifferentSizesAtIndex16()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3 = new CustomList<int>();
            test1.Add(1);
            test1.Add(3);
            test1.Add(5);
            test2.Add(2);
            test2.Add(4);
            test2.Add(6);
            test2.Add(7);
            test2.Add(8);
            test2.Add(9);
            test2.Add(10);
            test2.Add(11);
            test2.Add(12);
            test2.Add(13);
            test2.Add(14);
            test2.Add(15);
            test2.Add(16);
            test2.Add(17);
            int expectedValue = 17;

            //Act
            test3 = test1.Zip(test2);
            int actualValue = test3[16];

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
