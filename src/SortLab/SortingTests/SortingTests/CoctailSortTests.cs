using CoctailSort;

namespace SortingTests.SortingTests
{
    public class CoctailSortTests
    {
        [Fact]
        public void Sort_SortsArrayCorrectly()
        {
            // Arrange
            int[] array = { 12, 5, 18, 1, 20, 7, 11, 15, 3, 16, 9, 6, 14, 2, 10, 13, 8, 17, 4, 19 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            // Act
            CoctailSorter.Sort(array);

            // Assert
            Assert.Equal(expected, array);
        }
    }
}
