using BumbleSort;

namespace SortingTests.SortingTests
{
    public class BumbleSortTests
    {
        [Fact]
        public void Sort_SortsArrayCorrectly()
        {
            // Arrange
            int[] array = { 12, 5, 18, 1, 20, 7, 11, 15, 3, 16, 9, 6, 14, 2, 10, 13, 8, 17, 4, 19 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            // Act
            BubbleSorter.Sort(array);

            // Assert
            Assert.Equal(expected, array);
        }

        [Fact]
        public void Sort_EmptyArray_NoException()
        {
            // Arrange
            int[] array = Array.Empty<int>();

            // Act
            BubbleSorter.Sort(array);

            // Assert
            Assert.Empty(array);
        }

        [Fact]
        public void Sort_SingleElementArray_NoChange()
        {
            // Arrange
            int[] array = { 42 };

            // Act
            BubbleSorter.Sort(array);

            // Assert
            Assert.Single(array);
            Assert.Equal(42, array[0]);
        }
    }
}
