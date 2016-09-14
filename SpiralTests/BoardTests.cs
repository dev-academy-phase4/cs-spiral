using Spiral;
using Xunit;

namespace SpiralTests
{
    public class BoardTests
    {
        [Fact]
        public void BoardGeneratedWithCorrectDimensions ()
        {
            // Arrange & Act
            var board = new Board(5, 5);

            // Assert
            Assert.Equal(5, board.Cells.Length);
            Assert.Equal(5, board.Cells[0].Length);
        }
    }
}
