using LinkedList.Class;
using System;
using Xunit;

namespace linkListTest
{
    public class UnitTest1
    {
            [Fact]
            public void Finds()
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