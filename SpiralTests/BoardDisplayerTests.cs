using Spiral;
using Xunit;

namespace SpiralTests
{
    public class BoardDisplayerTests
    {
        [Fact]
        public void AddsSpaces ()
        {
            // Arrange
            string board = "..#\n.#.";
            string expected = ". . # \n. # . ";

            // Act
            var actual = BoardDisplayer.AddSpaces(board);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
