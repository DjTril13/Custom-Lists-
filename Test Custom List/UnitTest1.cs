using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using Custom_List;

namespace Test_Custom_List
{
    [TestClass]
    public class CustList
    {

        [TestMethod]
        public void Add_AddItemToListCountIsOne_InputEqualsActual()   //
        {
            //arrange
            CustList<int> TestList = new CustList<int>();
            int inputValue = 5;

            //act
            TestList.Add(inputValue);
            int actualCount = TestList.Count;
            //assert
            Assert.AreEqual(1, actualCount);
        }

        [TestMethod]
        public void Add_AddedItemToListCountIsFive_InputEqualsActual()
        {
            //arrange
            CustList<int> TestList = new CustList<int>();
            int inputValue = 5;

            //act
            TestList.Add(inputValue);
            int actualValue = TestList[0];
            //assert
            Assert.AreEqual(5, actualValue);
        }

        [TestMethod]
        public void Add_CountIsNotExceeded_InputEqualsActual()
        {
            //arrange
            CustList<int> TestList = new CustList<int>();
            int originalCount = TestList.Count; // this is 4
            TestList.Add(0);
            TestList.Add(1);
            TestList.Add(2);
            TestList.Add(3);
            //act
            TestList.Add(4);                    // this shouldnt be able to happen 
            int newCount = TestList.Count;
            //assert
            Assert.AreEqual(4, newCount);
        }

        //                   We need a test for .add that increased the capacity of the array if you try to .add more than it can currently accept

        /// //////////////////Removing Index 

        [TestMethod]
        public void Remove_CountCantGoBelowZero_InputEqualsActual()
        {
            //arrange
            CustList<int> TestList = new CustList<int>();   // Testing to that the index count after is what one less than original, maybe this could also test that capacity remained the same
            TestList.Add(0);
            TestList.Add(1);
            TestList.Add(2);
            TestList.Add(3);
            //act
            TestList.Remove(1);             // this should not be able to happen after index 0
            int endCount = 0;
            int actualEndCount = TestList.Count;
            //assert
            Assert.AreEqual(endCount, actualEndCount);
        }

        public void Remove_TakesIndexAway_InputEqualsActual()
        {
            //arrange
            CustList<int> TestList = new CustList<int>();  // Testing that the returned remove is the one you wanted to remove
            TestList.Add(3);
            TestList.Add(4);
            //act
            TestList.Remove();
            int expectedValue = TestList[1];
            //assert
            Assert.AreEqual(expectedValue, 3);
        }





    }
    }

