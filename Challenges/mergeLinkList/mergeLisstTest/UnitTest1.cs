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
        public void CanMergeTwo()
        {
            //arrange
            LList list = new LList();
            list.Insert(4);

            LList listTwo = new LList();
            listTwo.Insert(5);

            //act
            LList newList = Program.Merge(list, listTwo);
            newList.Current = newList.Head;

            //assert
            Assert.Equal(2, newList.Current.Value);
        }
    }
}
