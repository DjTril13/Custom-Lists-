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
        public void Add_AddItemToListCountIsOne_InputEqualsActual()
        {
            //arrange
            CustList<int> TestList = new CustList<int>();
            int inputValue = 5;

            //act
            TestList.Add(inputValue);
            int actualCount = TestList.count;
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
            int actualValue = TestList.arr[0];
            //assert
            Assert.AreEqual(5, actualValue);
        }

        [TestMethod]
        public void Add_CountIsNotExceeded_InputEqualsActual()
        {
            //arrange
            CustList<int> TestList = new CustList<int>();
            int  = 5;
            int originalCount = TestList.count;
            //act
            TestList.Add(inputValue);
            int actualCount = TestList.count;

            //assert
            Assert.AreEqual(1, actualCount);
        }

        /// <summary>
        /// //////////////////Removing Index 
        /// </summary>

        [TestMethod]
        public void Remove_CountCantGoBelowZero_InputEqualsActual()
        {
            //arrange
            CustList<int> TestList = new CustList<int>();   // TestList is an empty arrray 
            int originalCount = 0;
            //act
            TestList.Remove();                                // this should not be able to happen
            int endCount = 0;
            int actualEndCount;

            //assert
            Assert.AreNotEqual(actualEndCount, endCount);
        }

        public void Remove_TakesIndexAway_InputEqualsActual()
        {
            //arrange
            CustList<int> TestList = new CustList<int>();  // TestList is an empty arrray 
            
            //act
            TestList.Remove();                                // this should not be able to happen
            expectedResult = TestList{2}

            //assert
            Assert.AreNotEqual(originalCount, actualCount);
        }

    }
    }

