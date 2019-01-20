using System;
using Xunit;
using LinkedList.Class;

namespace LinkedList_TEST
{
    public class UnitTest1
    {
        [Fact]
        public void InsertValue()
        {
            int num = 9;
            LList test = new LList();
            test.Insert(num);
            Assert.Equal(, test.Head.Value);
        }


        [Fact]
        public void NonExistentValueTest()
        {

            LList test = new LList();
            test.Insert(55);
            Assert.False(test.Includes(5));
        }


        [Fact]
        public void AppendValueTest()
        {
            LList test = new LList();
            test.Insert(34);
            test.Append(66);
            bool Booltest = test.Includes(66);
            Assert.Equal(66, test.Head.Next.Value);
        }

        [Fact]
        public void InsertBeforeTest()
        {
            LList test = new LList();
            test.Insert(13);
            test.Insert(11);
            test.InsertBefore(13, 12);
            bool Booltest = test.Includes(12);
            Assert.Equal(12, test.Head.Next.Value);
        }

        [Fact]
        public void InserAfterTest()
        {
            LList test = new LList();
            test.Insert(13);
            test.Insert(11);
            test.InsertAfter(11, 12);
            bool Booltest = test.Includes(12);
            Assert.Equal(12, test.Head.Next.Value);
        }


    }
}