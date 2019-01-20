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
            public void CanNotFound()
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