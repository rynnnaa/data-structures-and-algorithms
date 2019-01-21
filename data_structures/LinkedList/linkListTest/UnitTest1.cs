using LinkedList.Class;
using System;
using Xunit;

namespace linkListTest
{
    public class UnitTest1
    {
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




    }
    }