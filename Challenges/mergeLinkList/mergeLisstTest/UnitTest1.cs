using mergeLinkList;
using LinkedList.Class;
using System;
using Xunit;

namespace mergeLinkList
{
    public class UnitTest1
    {
        [Fact]
        public void MergeWorks()
        {
            //arrange
            LList list = new LList();
            list.Insert(1);

            LList list2 = new LList();
            list2.Insert(2);

            //act
            LList newL = Program.Merge(list, list2);
            newL.Current = newL.Head;

            //assert
            Assert.Equal(1, newL.Current.Value);
        }

        [Fact]
        public void MergeWorksTwo()
        {
            //arrange
            LList list = new LList();
            list.Insert(2);

            LList list2 = new LList();
            list2.Insert(1);

            //act
            LList newL = Program.Merge(list, list2);
            newL.Current = newL.Head;

            //assert
            Assert.Equal(2, newL.Current.Value);
        }

        [Fact]
        public void MergeWorksThree()
        {
            //arrange
            LList list = new LList();
            list.Insert(3);

            LList list2 = new LList();
            list2.Insert(1);

            //act
            LList newL = Program.Merge(list, list2);
            newL.Current = newL.Head;

            //assert
            Assert.Equal(3, newL.Current.Value);
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