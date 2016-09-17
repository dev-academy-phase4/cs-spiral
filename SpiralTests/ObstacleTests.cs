using Spiral;
using Xunit;

namespace SpiralTests
{
    public class ObstacleTests
    {
        [Fact]
        public void ObstacleHasCorrectCoordinates ()
        {
            // Arrange & Act
            var obstacle = new Obstacle(1, 2);

            // Assert
            Assert.Equal(1, obstacle.Row);
            Assert.Equal(2, obstacle.Col);
        }
    }
}
