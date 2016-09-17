using Spiral;
using Xunit;

namespace SpiralTests
{
    public class BoardTests
    {
        [Fact]
        public void BoardGeneratedFiveByFive ()
        {
            // Arrange & Act
            var board = new Board(5, 5);

            // Assert
            Assert.Equal(5, board.Cells.Length);
            Assert.Equal(5, board.Cells[0].Length);
        }

        [Fact]
        public void BoardGeneratedSixByTwo ()
        {
            // Arrange
            string expected = "..\n..\n..\n..\n..\n..\n";

            // Act
            var board = new Board(6, 2);
            var actual = board.ToString();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PlayerDisplays ()
        {
            // Arrange
            var board = new Board(3, 3);
            string expected = "@..\n...\n...\n";

            // Act
            board.Update();

            // Assert
            Assert.Equal(expected, board.ToString());
        }

        [Fact]
        public void MovePlayerMovesPlayer ()
        {
            // Arrange
            var board = new Board(3, 3);

            // Act
            board.MovePlayer("e");

            // Assert
            Assert.Equal(0, board.Player.Row);
            Assert.Equal(1, board.Player.Col);
        }

        [Fact]
        public void MovePlayerRespectsBoardBoundaries ()
        {
            // Arrange
            var board = new Board(1, 1);

            // Act
            board.MovePlayer("s");

            // Assert
            Assert.Equal(0, board.Player.Row);
            Assert.Equal(0, board.Player.Col);
        }
    }
}
