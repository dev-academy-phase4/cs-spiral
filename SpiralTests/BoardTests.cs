using Spiral;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SpiralTests
{
    public class BoardTests
    {
        [Fact]
        public void BoardGeneratedFiveByFive ()
        {
            // Arrange & Act
            var board = new Board(new string[] { ".....", ".....", ".....", ".....", "....." });

            // Assert
            Assert.Equal(5, board.Cells.Length);
            Assert.Equal(5, board.Cells[0].Length);
        }

        [Fact]
        public void MovePlayerMovesPlayer ()
        {
            // Arrange
            var board = new Board(new string[] { "...", "...", "..." });

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
            var board = new Board(new string[] { "." });

            // Act
            board.MovePlayer("s");

            // Assert
            Assert.Equal(0, board.Player.Row);
            Assert.Equal(0, board.Player.Col);
        }

        [Fact]
        public void BoardCanHaveObstacles ()
        {
            // Arrange & Act
            var board = new Board(new string[] { ".#" });

            // Assert
            Assert.Equal(1, board.Obstacles.Count());
        }

        [Fact]
        public void BoardWontMovePlayerOntoObstacle ()
        {
            // Arrange
            var board = new Board(new string[] { ".", "#" });

            // Act
            board.MovePlayer("s");

            // Assert
            Assert.Equal(0, board.Player.Row);
            Assert.Equal(0, board.Player.Col);
        }

        [Fact]
        public void ThrowsIfObstaclesOutsideBoard ()
        {
            // Arrange, Act & Assert
            Assert.Throws<System.ArgumentOutOfRangeException>(() => 
                new Board(new string[] { "...", "...", "...    #" }));
        }

        [Fact]
        public void ConstructBoardFromArray ()
        {
            // Arrange
            var map = new string[]
            {
                "....#",
                "...#.",
                "..#..",
                ".#...",
                "#...."
            };
            var expected = "....#\n...#.\n..#..\n.#...\n#....\n";

            // Act
            var board = new Board(map);
            board.Update();

            // Assert
            Assert.Equal(expected, board.ToString());
        }
    }
}
