using LinkedList.Class;
using System;
using Xunit;

namespace linkListTest
{
    public class UnitTest1
    {
        //Tesing for the includes method
        [Fact]
        public void Find()
        {
            //arrange
            LList list = new LList();
            list.Insert(2);

            //act
            bool found = list.Includes(2);

            //assert
            Assert.True(found);
        }

        [Fact]

        public void Find2()
        {
            //arrange
            LList list = new LList();
            list.Insert(2);

            //act
            bool found = list.Includes(2);

            //assert
            Assert.True(found);
        }

        [Fact]
        public void Find3()
        {
            //arrange
            LList list = new LList();
            list.Insert(3);

            //act
            bool found = list.Includes(3);

            //assert
            Assert.True(found);
        }


        [Fact]
        public void AddNumber()
        {
            //arrange
            LList list = new LList();
            list.Insert(2);

            //act
            bool found = list.Includes(2);

            //assert
            Assert.True(found);
        }

        //testing insert method

        [Fact]
        public void NodeValueIsTwo()
        {
            LList testList = new LList();
            testList.Insert(2);
            Assert.True(testList.Head.Value == 2);
        }

        [Fact]
        public void LastInsertIsHead()
        {
            LList testList = new LList();
            testList.Insert(4);
            testList.Insert(2);
            bool isHead = testList.Head.Value == 2;
            Assert.True(isHead);
        }

        [Fact]
        public void NodeHasNoCurrent()
        {
            LList testList = new LList();
            testList.Insert(1);
            bool current = testList.Current == null;
            Assert.True(current);
        }

    }
}