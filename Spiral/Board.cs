using System.Linq;
using System.Collections.Generic;

namespace Spiral
{
    public class Board
    {
        private int _rows;
        private int _cols;

        public char[][] Cells { get; set; }
        public Player Player { get; set; }
        public IEnumerable<Obstacle> Obstacles { get; set; }

        public Board(int rows, int cols)
        {
            InitialiseCells(rows, cols);
            Player = new Player();
            Obstacles = new List<Obstacle>();
        }

        public Board(int rows, int cols, IEnumerable<Obstacle> obstacles)
        {
            InitialiseCells(rows, cols);
            Player = new Player();
            Obstacles = obstacles;
        }

        private void InitialiseCells (int rows, int cols)
        {
            _rows = rows;
            _cols = cols;
            Cells = new char[rows][];
            for (int i = 0; i < rows; i++)
            {
                Cells[i] = new char[_cols];
            } 
            BlankBoard();
        }

        public void BlankBoard ()
        {
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    Cells[i][j] = '.';
                }
            }
        }

        public void Update()
        {
            BlankBoard();
            Cells[Player.Row][Player.Col] = '@';
        }

        public bool MoveIsValid (string direction)
        {
            var p = new Player();
            p.Row = Player.Row;
            p.Col = Player.Col;
            p.Move(direction);
            bool insideBoundaries = p.Row < _rows && p.Row >= 0 && p.Col < _cols && p.Col >= 0;
            bool notOnObstacle= !Obstacles.Any(o => o.Col == p.Col && o.Row == p.Row);
            return insideBoundaries && notOnObstacle;
        }

        public void MovePlayer (string direction)
        {
            if (MoveIsValid(direction))
            {
                Player.Move(direction);
            }
        }

        public override string ToString()
        {
            return Cells
                .Select(row => new string(row) + "\n")
                .Aggregate((a, b) => a + b)
                .ToString();
        }
    }
}
