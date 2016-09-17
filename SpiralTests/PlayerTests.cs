using Spiral;
using Xunit;

namespace SpiralTests
{
    public class PlayerTests
    {
        [Fact]
        public void PlayerStartsAt0 ()
        {
            // Arrange & Act
            var player = new Player();

            // Assert
            Assert.Equal(0, player.Row);
            Assert.Equal(0, player.Col);
        }

        [Fact]
        public void MoveSouth ()
        {
            // Arrange
            var player = new Player();

            // Act
            player.Move("s");

            // Assert
            Assert.Equal(1, player.Row);
            Assert.Equal(0, player.Col);
        }

        [Fact]
        public void MoveEast ()
        {
            // Arrange
            var player = new Player();

            // Act
            player.Move("e");

            // Assert
            Assert.Equal(0, player.Row);
            Assert.Equal(1, player.Col);
        }

        [Fact]
        public void MoveNorth ()
        {
            // Arrange
            var player = new Player();
            player.Row = 1;

            // Act
            player.Move("n");

            // Assert
            Assert.Equal(0, player.Row);
            Assert.Equal(0, player.Col);
        }

        [Fact]
        public void MoveWest ()
        {
            // Arrange
            var player = new Player();
            player.Col = 1;

            // Act
            player.Move("w");

            // Assert
            Assert.Equal(0, player.Row);
            Assert.Equal(0, player.Col);
        }

        [Fact]
        public void MoveSouthEast ()
        {
            // Arrange
            var player = new Player();

            // Act
            player.Move("se");

            // Assert
            Assert.Equal(1, player.Row);
            Assert.Equal(1, player.Col);
        }

        [Fact]
        public void MoveSouthWest ()
        {
            // Arrange
            var player = new Player();
            player.Col = 1;

            // Act
            player.Move("sw");

            // Assert
            Assert.Equal(1, player.Row);
            Assert.Equal(0, player.Col);
        }

        [Fact]
        public void MoveNorthEast ()
        {
            // Arrange
            var player = new Player();
            player.Row = 1;

            // Act
            player.Move("ne");

            // Assert
            Assert.Equal(0, player.Row);
            Assert.Equal(1, player.Col);
        }

        [Fact]
        public void MoveNorthWest ()
        {
            // Arrange
            var player = new Player();
            player.Row = 1;
            player.Col = 1;

            // Act
            player.Move("nw");

            // Assert
            Assert.Equal(0, player.Row);
            Assert.Equal(0, player.Col);
        }
    }
}
