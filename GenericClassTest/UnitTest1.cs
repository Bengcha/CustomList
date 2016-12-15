using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomeList;
namespace GenericClassTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddIntObject()
        {
            //Arrange
            GenericClass<int> myList = new GenericClass<int>();
            int expectedResult = 4;

            //Act
            myList.AddingObjectToList(expectedResult);
            int actualResult = myList.CustomArrayList[0];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void AddStringObject()
        {
            //Arrange
            GenericClass<string> mylist = new GenericClass<string>();
            string expectedResult = "DevCampCode";

            //Act
            mylist.AddingObjectToList(expectedResult);
            string acutalResult = mylist.CustomArrayList[0];


            //Assert
            Assert.AreEqual(expectedResult, acutalResult);

        }
        [TestMethod]
        public void AddDoubleObject()
        {
            //Arrange
            GenericClass<double> mylist = new GenericClass<double>();
            double expectedResult = 10.99;

            //Act
            mylist.AddingObjectToList(expectedResult);
            double acutalResult = mylist.CustomArrayList[0];


            //Assert
            Assert.AreEqual(expectedResult, acutalResult);

        }
        [TestMethod]
        public void AddDecimalObject()
        {
            //Arrange
            GenericClass<decimal> mylist = new GenericClass<decimal>();
            decimal expectedResult = 10.666m;

            //Act
            mylist.AddingObjectToList(expectedResult);
            decimal acutalResult = mylist.CustomArrayList[0];


            //Assert
            Assert.AreEqual(expectedResult, acutalResult);
        }
        [TestMethod]

        public void SubtractIntObject()
        {
            //Arrange
            GenericClass<int> mylist = new GenericClass<int>();
            int number10 = 10;
            int number11 = 11;
            mylist.AddingObjectToList(number10);
            mylist.AddingObjectToList(number11);
            int list = mylist.CustomArrayList[0];

            //Act
            mylist.RemoveObjectFromList(number10);
            int result = mylist.CustomArrayList[0];
            
            //Assert
            Assert.AreNotEqual(result, list);

        }
        [TestMethod]

        public void SubtractStringObject()
        {
            //Arrange
            GenericClass<string> mylist = new GenericClass<string>();
            string one = "Hello";
            string two = "Bye";
            mylist.AddingObjectToList(one);
            mylist.AddingObjectToList(two);
            string list = mylist.CustomArrayList[0];

            //Act
            mylist.RemoveObjectFromList(one);
            string result = mylist.CustomArrayList[0];

            //Assert
            Assert.AreNotEqual(result, list);

        }
        [TestMethod]

        public void SubtractDoubleObject()
        {
            //Arrange
            GenericClass<double> mylist = new GenericClass<double>();
            double number10 = 10.10;
            double number11 = 11.11;
            mylist.AddingObjectToList(number10);
            mylist.AddingObjectToList(number11);
            double list = mylist.CustomArrayList[0];

            //Act
            mylist.RemoveObjectFromList(number10);
            double result = mylist.CustomArrayList[0];

            //Assert
            Assert.AreNotEqual(result, list);

        }
        [TestMethod]

        public void SubtractDecimalIntObject()
        {
            //Arrange
            GenericClass<decimal> mylist = new GenericClass<decimal>();
            decimal number10 = .10101010m;
            decimal number11 = .11111111m;
            mylist.AddingObjectToList(number10);
            mylist.AddingObjectToList(number11);
            decimal list = mylist.CustomArrayList[0];

            //Act
            mylist.RemoveObjectFromList(number10);
            decimal result = mylist.CustomArrayList[0];

            //Assert
            Assert.AreNotEqual(result, list);

        }
        [TestMethod]
        public void DisplayIntList()
        {
            //Arrange
            GenericClass<int> mylist = new GenericClass<int>();
            int number1 = 1;
            int number2 = 2;
            int number3 = 3;
            mylist.AddingObjectToList(number1);
            mylist.AddingObjectToList(number2);
            mylist.AddingObjectToList(number3);
            int list = mylist.CustomArrayList[0];

            //Act
            mylist.DisplayObjectInList();
            int result = mylist.CustomArrayList[0];

            //Assert
            Assert.AreEqual(list, result);
        }
        [TestMethod]
        public void DisplayStringList()
        {
            //Arrange
            GenericClass<string> mylist = new GenericClass<string>();
            string car1 = "Acura";
            string car2 = "Lexus";
            string car3 = "Infiniti";
            mylist.AddingObjectToList(car1);
            mylist.AddingObjectToList(car2);
            mylist.AddingObjectToList(car3);
            string list = mylist.CustomArrayList[0];

            //Act
            mylist.DisplayObjectInList();
            string result = mylist.CustomArrayList[0];

            //Assert
            Assert.AreEqual(list, result);
        }
        [TestMethod]

        public void CountIntObjectInList()
        {
            GenericClass<int> mylist = new GenericClass<int>();
            //Arrange
            int number1 = 1;
            int number2 = 2;
            int number3 = 3;
            mylist.AddingObjectToList(number1);
            mylist.AddingObjectToList(number2);
            mylist.AddingObjectToList(number3);
            int list = mylist.CustomArrayList[0];

            //Act
            int result = mylist.Count;
            Assert.AreEqual(result, 3);
        }
        [TestMethod]

        public void CountStringObjectInList()
        {
            GenericClass<string> mylist = new GenericClass<string>();
            //Arrange
            string shoe1 = "NIKE";
            string shoe2 = "ADIDAS";
            string shoe3 = "JORDAN";
            mylist.AddingObjectToList(shoe1);
            mylist.AddingObjectToList(shoe2);
            mylist.AddingObjectToList(shoe3);
            string list = mylist.CustomArrayList[0];

            //Act
            int result = mylist.Count;
            Assert.AreEqual(result, 3);
        }
    }
}
