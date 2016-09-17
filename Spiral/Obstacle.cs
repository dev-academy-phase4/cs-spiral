namespace Spiral
{
    public class Obstacle
    {
        public int Row { get; set; }
        public int Col { get; set; }

        public Obstacle (int row, int col)
        {
            Row = row;
            Col = col;
        }
    }
}
