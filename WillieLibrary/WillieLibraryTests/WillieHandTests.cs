using Microsoft.VisualStudio.TestTools.UnitTesting;
using WillieLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillieLibrary.Tests
{
    [TestClass()]
    public class WillieHandTests
    {
        //Part A
        [TestMethod()]
        public void NineJackTest()
        {
            //Arrange
            int one = 9;
            int two = 11;
            WillieHand target = new WillieHand(one, two);

            //Act
            int expected = 19;
            int actual = target.Willie;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AceQueenTest()
        {
            //Arrange
            int one = 1;
            int two = 12;
            WillieHand target = new WillieHand(one, two);

            //Act
            int expected = 11;
            int actual = target.Willie;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void KingJackTest()
        {
            //Arrange
            int one = 13;
            int two = 11;
            WillieHand target = new WillieHand(one, two);

            //Act
            int expected = 20;
            int actual = target.Willie;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SevenTwoTest()
        {
            //Arrange
            int one = 7;
            int two = 2;
            WillieHand target = new WillieHand(one, two);

            //Act
            int expected = 9;
            int actual = target.Willie;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void QueenNineTest()
        {
            //Arrange
            int one = 12;
            int two = 9;
            WillieHand target = new WillieHand(one, two);

            //Act
            int expected = 19;
            int actual = target.Willie;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TenKingTest()
        {
            //Arrange
            int one = 10;
            int two = 13;
            WillieHand target = new WillieHand(one, two);

            //Act
            int expected = 20;
            int actual = target.Willie;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Part B
        [TestMethod()]
        public void JackTest()
        {
            //Arrange
            int one = 11;
            WillieHand target = new WillieHand(one);

            //Act
            int expected = 10;
            int actual = target.Willie;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TenTest()
        {
            //Arrange
            int one = 10;
            WillieHand target = new WillieHand(one);

            //Act
            int expected = 10;
            int actual = target.Willie;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NineTest()
        {
            //Arrange
            int one = 9;
            WillieHand target = new WillieHand(one);

            //Act
            int expected = 9;
            int actual = target.Willie;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AceTest()
        {
            //Arrange
            int one = 1;
            WillieHand target = new WillieHand(one);

            //Act
            int expected = 1;
            int actual = target.Willie;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}