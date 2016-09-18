using Spiral;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SpiralTests
{
    public class MapLoaderTests
    {
        [Fact]
        public void GetObstaclesFromRowSimpleInput ()
        {
            // Arrange & Act
            IEnumerable<Obstacle> actual = MapLoader.GetObstaclesFromRow(".#", 0);

            // Assert
            Assert.Equal(0, actual.First().Row);
            Assert.Equal(1, actual.First().Col);
        }

        [Fact]
        public void GetObstaclesFromArray ()
        {
            // Arrange
            string[] map =
            {
                "..#",
                "#.."
            };

            // Act
            IEnumerable<Obstacle> actual = MapLoader.GetObstacles(map);

            // Assert
            Assert.Equal(0, actual.First().Row);
            Assert.Equal(2, actual.First().Col);
            Assert.Equal(1, actual.Last().Row);
            Assert.Equal(0, actual.Last().Col);
        }
    }
}
