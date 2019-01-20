using mergeLinkList;
using LinkedList.Class;
using System;
using Xunit;

namespace mergeLinkList
{
    public class UnitTest1
    {
        [Fact]
        public void CanMerge()

        {

            LList list = new LList();
            list.Insert(2);

            LList listTwo = new LList();
            listTwo.Insert(3);

            LList newList = Program.Merge(list, listTwo);
            newList.Current = newList.Head;

            Assert.Equal(1, newList.Current.Value);
        }

        [Fact]
        public void PlaceFromEndWorksAga()
        {
            //Arrange
            int value = 1;

            //Act
            int result = Program.PlaceFromEnd(value);

            //Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void PlaceFromEndWorks()
        {
            //Arrange
            int value = 2;

            //Act
            int result = Program.PlaceFromEnd(value);

            //Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void PlaceFromEndWorksAgain()
        {
            //Arrange
            int value = 3;

            //Act
            int result = Program.PlaceFromEnd(value);

            //Assert
            Assert.Equal(4, result);
        }

    }
    }