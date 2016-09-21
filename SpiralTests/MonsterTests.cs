using Spiral;
using Xunit;

namespace SpiralTests
{
    public class MonsterTests
    {
        [Fact]
        public void MonsterStartsAtCorrectCoordinates ()
        {
            // Arrange & Act
            var monster = new Monster(1, 2);

            // Assert
            Assert.Equal(1, monster.Row);
            Assert.Equal(2, monster.Col);
        }
    }
}
