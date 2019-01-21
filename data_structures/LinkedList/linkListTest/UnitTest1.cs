using System;
using Xunit;
using LinkedList.Class;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanFind()
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
            list.Insert(3);

            //act
            bool found = list.Includes(3);

            //assert
            Assert.True(found);
        }

        [Fact]

        public void Find3()

        {
            //arrange
            LList list = new LList();
            list.Insert(2);

            //act
            bool found = list.Includes(9);

            //assert
            Assert.False(found);
        }

        [Fact]
        public void CanAdd1()
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
        public void CanAdd2()
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
        public void CanAdd3()
        {
            //arrange
            LList list = new LList();
            list.Insert(4);

            //act
            bool found = list.Includes(4);

            //assert
            Assert.True(found);
        }

        [Fact]
        public void CanAppend1()
        {
            //arrange
            LList list = new LList();
            list.Insert(4);
            list.Insert(5);
            list.Append(6);

            //act
            bool found = list.Includes(6);

            //assert
            Assert.True(found);
        }

        [Fact]
        public void CanAppend2()
        {
            //arrange
            LList list = new LList();
            list.Insert(4);
            list.Insert(5);
            list.Append(23);

            //act
            bool found = list.Includes(23);

            //assert
            Assert.True(found);
        }

        [Fact]
        public void CanAppend3()
        {
            //arrange
            LList list = new LList();
            list.Insert(4);
            list.Insert(5);
            list.Append(26);

            //act
            bool found = list.Includes(26);

            //assert
            Assert.True(found);
        }

        [Fact]
        public void CanAddBefore1()
        {
            //arrange
            LList list = new LList();
            list.Insert(4);
            list.Insert(6);
            list.InsertBefore(5, 6);

            //act
            bool found = list.Includes(5);

            //assert
            Assert.True(found);
        }

        [Fact]
        public void CanAddBefore2()
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
        public void CanAddBefore3()
        {
            //arrange
            LList list = new LList();
            list.Insert(4);
            list.Insert(5);
            list.Insert(5);
            list.InsertBefore(5, 22);

            //act
            bool found = list.Includes(22);

            //assert
            Assert.True(found);
        }

        [Fact]
        public void CanAddAfter()
        {
            //arrange
            LList list = new LList();
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);
            list.InsertAfter(5, 22);

            //act
            bool found = list.Includes(22);

            //assert
            Assert.True(found);
        }

        [Fact]
        public void CanAddAfter1()
        {
            //arrange
            LList list = new LList();
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);
            list.InsertAfter(5, 23);

            //act
            bool found = list.Includes(23);

            //assert
            Assert.True(found);
        }

        [Fact]
        public void CanAddAfter3()
        {
            //arrange
            LList list = new LList();
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);
            list.Insert(7);
            list.InsertAfter(6, 18);

            //act
            bool found = list.Includes(18);

            //assert
            Assert.True(found);
        }
    }
}