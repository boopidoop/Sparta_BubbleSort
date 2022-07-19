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

        [Test]
        public void GivenRandomNumbers_BubbleSort_Returns0To5Ascending()
        {
            var array4 = new int[] { 4, 3, 5, 2, 0, 1 };
            Assert.That(Program.BubbleSort(array4), Is.EqualTo(new int[] { 0, 1, 2, 3, 4, 5 }));
        }

        [Test]
        public void GivenRandomNumbers_BubbleSort_Returns0To10Ascending()
        {
            var array5= new int[] { 8,4, 3, 5, 9, 7, 6,2, 0, 1 };
            Assert.That(Program.BubbleSort(array5), Is.EqualTo(new int[] { 0, 1, 2, 3, 4, 5, 6, 7,8,9, }));
        }

        [Test]
        public void GivenRandomNumbersWithin100_BubbleSort_ReturnsAscendingNumbers()
        {
            var array5 = new int[] { 80, 4, 3, 50, 97, 7, 65, 2, 0, 16 };
            Assert.That(Program.BubbleSort(array5), Is.EqualTo(new int[] { 0, 2, 3, 4, 7, 16, 50, 65, 80, 97 }));
        }
    }
}