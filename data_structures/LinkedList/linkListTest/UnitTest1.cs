using System;
using Xunit;
using LinkedList.Class;

namespace XUnitTestProject1
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

        public void CanFind2()
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
        public void CanFind3()
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

        // Tests the Append() method
        [Fact]
        public void AppendToList()
        {
            LList testList = new LList();
            testList.Insert(1);
            testList.Insert(2);
            testList.Insert(3);
            testList.Append(25);
            testList.Current = testList.Head;
            while (testList.Current.Next != null)
            {
                testList.Current = testList.Current.Next;
            }
            Assert.True(testList.Current.Value == 25);
        }

        [Fact]
        public void AppendToEmptyList()
        {
            LList testList = new LList();
            testList.Append(10);
            Assert.True(testList.Head.Value == 10);
        }

        [Fact]
        public void AppendValue()
        {
            LList test = new LList();
            test.Insert(34);
            test.Append(66);
            bool Booltest = test.Includes(66);
            Assert.Equal(66, test.Head.Next.Value);
        }

        //testing insert before method

        [Fact]
        public void InsertBefore()
        {
            //arrange
            LList list = new LList();
            list.Insert(5);
            list.Insert(6);
            list.InsertBefore(6, 4);

            //act
            bool found = list.Includes(3);

            //assert
            Assert.True(found);
        }

        [Fact]
        public void InsertBefore2()
        {
            //arrange
            LList list = new LList();
            list.Insert(4);
            list.Insert(5);
            list.InsertBefore(4, 3);

            //act
            bool found = list.Includes(3);

            //assert
            Assert.True(found);
        }

        [Fact]
        public void InsertBefore3()
        {
            //arrange
            LList list = new LList();
            list.Insert(8);
            list.Insert(9);
            list.InsertBefore(8, 7);

            //act
            bool found = list.Includes(3);

            //assert
            Assert.True(found);
        }

        //testing insert after method

        [Fact]
        public void InsertsAfterHead()
        {
            LList testList = new LList();
            testList.Insert(9);
            testList.Insert(10);
            testList.Insert(30);
            testList.InsertAfter(30, 5);
            testList.Current = testList.Head;
            Assert.True(testList.Current.Value == 30);
            Assert.True(testList.Current.Next.Value == 5);
        }
        [Fact]
        public void InsertsAfterLast()
        {
            LList testList = new LList();
            testList.Insert(40);
            testList.Insert(56);
            testList.Insert(57);
            testList.Insert(68);
            testList.InsertAfter(40, 0);
            testList.Current = testList.Head;
            while (testList.Current.Next != null)
            {
                testList.Current = testList.Current.Next;
            }
            Assert.True(testList.Current.Value == 0);
        }

        [Fact]
        public void InsertAfter()
        {
            //arrange
            LList list = new LList();
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);
            list.InsertAfter(5, 42);

            //act
            bool found = list.Includes(42);

            //assert
            Assert.True(found);
        }

    }
}