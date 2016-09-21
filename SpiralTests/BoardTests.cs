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
            var board = new Board(5, 5);

            // Assert
            Assert.Equal(5, board.Cells.Length);
            Assert.Equal(5, board.Cells[0].Length);
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

        [Fact]
        public void BoardCanHaveObstacles ()
        {
            // Arrange
            var obstacles = new List<Obstacle> { new Obstacle(0, 0) };

            // Act
            var board = new Board(1, 1, obstacles);

            // Assert
            Assert.Equal(1, board.Obstacles.Count());
        }

        [Fact]
        public void BoardWontMovePlayerOntoObstacle ()
        {
            // Arrange
            var board = new Board(2, 1, new List<Obstacle> { new Obstacle(1, 0) });

            // Act
            board.MovePlayer("s");

            // Assert
            Assert.Equal(0, board.Player.Row);
            Assert.Equal(0, board.Player.Col);
        }

        [Fact]
        public void ThrowsIfObstaclesOutsideBoard ()
        {
            // Arrange
            var o = new Obstacle(2, 0);

            // Act & Assert
            Assert.Throws<System.ArgumentOutOfRangeException>(() => 
                new Board(1, 1, new List<Obstacle> { o }));
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
