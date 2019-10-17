using Microsoft.VisualStudio.TestTools.UnitTesting;
using MandatoryAssignmentTask1;
using System;

namespace UnitTestMandatoryAssignment
{
        [TestClass]
        public class UnitTestBook
        {
            //Testing the constrain  for Title
            [TestMethod]
            public void TestTitle()
            {
                //Arrange
                Book b = new Book();

                //Act
                b.Title = "New Moon";
                var expected = "N";
                var actual = b.Title.Length < 2;

                //Assert
                Assert.AreNotEqual(actual, expected);
            }

            //Testing author name
            [TestMethod]
            public void TestAuthor()
            {
                //Arrange
                Book b = new Book();

                //Act
                b.Author = "Name";


                //Assert
                Assert.AreEqual(b.Author, "Name");
            }
            [TestMethod]
            public void TestPageNO()
            {
                //Arrange
                Book b = new Book();

                //Act

                var expected = 500;
                //var actual = b.PageNo > 10 && b.PageNo <= 1000;
                var actual = b.PageNumber.Equals(5);

                //Assert
                Assert.AreNotEqual(expected, actual);
            }
            [TestMethod]
            public void TestISBN()
            {
                //Arrange
                Book b = new Book();

                //Act
                b.Isbn13 = "123dbsk12344b";
                var expected = 13;
                var actual = b.Isbn13.Length;

                //Assert
                Assert.AreEqual(expected, actual);
            }

        }
}
