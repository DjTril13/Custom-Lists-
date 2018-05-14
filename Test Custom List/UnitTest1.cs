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
        public void Remove_CountDecreasesByOne_InputEqualsActual()
        {
            //arrange
            CustList<int> TestList = new CustList<int>();   // Testing to that the index count after is what one less than original, maybe this could also test that capacity remained the same
            TestList.Add(0);
            TestList.Add(1);
            TestList.Add(2);
            TestList.Add(3);
            //act
            TestList.Remove(1);             
            int endCount = 3;                             
            int actualEndCount = TestList.Count;      //index count should be 3, capacity still 4
            //assert
            Assert.AreEqual(endCount, actualEndCount);
        }

        public void Remove_TakesCorrectIndexAway_InputEqualsActual()
        {
            //arrange
            CustList<string> TestList = new CustList<string>();  // Testing that the indexs are shifted to the left in the array (decreased an index)
            TestList.Add("a");
            TestList.Add("b");
            TestList.Add("c");
            TestList.Add("d");
            //act
            TestList.Remove("b");           // new array shoudl be [a, c, d, ,]

            string expectedString = TestList[1];
            //assert
            Assert.AreEqual(expectedString, "c");
            string expectedString2 = TestList[2];
            Assert.AreEqual(expectedString, "d");
            string expectedString3 = TestList[2];
            Assert.AreEqual(expectedString, " ");     // This test is the capacity remain 4 as well 
        }

        //      TESTS FOR ITERATION   -- By creating/testing your COUNT propetrty



        // TEST TO OVERLOAD THE + OPERATOR
        // TEST TO OVERLOAD THE - OPERATOR

        // TEST TO>STRING

        // TEST FOR ZIPPER 

        // BONUS !! TEST ABILITY TO SORT
        // BONUS !! EASTER EGG USER STORY 

    }
}

