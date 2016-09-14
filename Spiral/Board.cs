namespace Spiral
{
    public class Board
    {
        public char[][] Cells { get; set; }

        public Board(int rows, int cols)
        {
            Cells = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                Cells[i] = new char[cols];
                for (int j = 0; j < cols; j++)
                {
                    Cells[i][j] = '.';
                }
            }
        }
    }
}
