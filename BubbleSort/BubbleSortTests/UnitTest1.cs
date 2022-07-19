namespace BubbleSortTests
{
    public class Tests
    {
        

        [Test]
        public void GivenEmptyArray_BubbleSort_ReturnsEmptyArray()
        {
            var emptyArray = new int[0] ;

            Assert.That(Program.BubbleSort(emptyArray), Is.EqualTo(new int[0]));
        }

        [Test]
        public void GivenNumbersFrom0To5Ascending_BubbleSort_ReturnsInput()
        {
            var array1 = new int[] {0,1,2,3,4,5};
            Assert.That(Program.BubbleSort(array1), Is.EqualTo(array1));
        }

        [Test]
        public void GivenNumbersFrom0To5Decending_BubbleSort_Returns0To5Ascending()
        {
            var array2 = new int[] { 5,4,3,2,1,0 };
            Assert.That(Program.BubbleSort(array2), Is.EqualTo(new int[] {0,1,2,3,4,5}));
        }

        [Test]
        public void GivenArraysOf5Zeros_BubbleSort_ReturnsInput()
        {
            var array3 = new int[5];
            Assert.That(Program.BubbleSort(array3), Is.EqualTo(array3));
        }
    }
}