using System;
using System.Linq;
using System.Collections.Generic;

namespace Spiral
{
    public class Board
    {
        private int _rows;
        private int _cols;

        public char[][] Cells { get; set; }
        public bool Exit { get; set; }
        public Player Player { get; set; }
        public IEnumerable<Obstacle> Obstacles { get; set; }

        public Board(int rows, int cols)
        {
            Exit = true;
            InitialiseCells(rows, cols);
            Player = new Player();
            Obstacles = new List<Obstacle>();
        }

        public Board (int rows, int cols, IEnumerable<Obstacle> obstacles)
        {
            Exit = true;
            InitialiseCells(rows, cols);
            Player = new Player();
            if (obstacles.Any(o => o.Row >= rows || o.Col >= cols))
            {
                throw new System.ArgumentOutOfRangeException("Obstacle outside board boundaries!");
            }
            Obstacles = obstacles;
        }

        public Board (string[] rows)
        {
            Exit = true;
            InitialiseCells(rows);
            Player = new Player();
            Obstacles = MapLoader.GetObstacles(rows);
            if (Obstacles.Any(o => o.Row >= rows.Length || o.Col >= rows[0].Length))
            {
                throw new System.ArgumentOutOfRangeException("Obstacle outside board boundaries!");
            }
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
        }

        private void InitialiseCells (string[] rows)
        {
            _rows = rows.Length;
            _cols = rows[0].Length;
            Cells = new char[rows.Length][];
            for (int i = 0; i < Cells.Length; i++)
            {
                Cells[i] = rows[i].ToCharArray();
            } 
        }

        public void Update()
        {
            Player.Write();
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
            if (direction == "x" && Cells[Player.Row][Player.Col] == 'X')
            {
                Exit = true;
                return;
            }
            if (MoveIsValid(direction))
            {
                ClearPlayerPosition();
                Player.Move(direction);
                Player.Write();
                DisplayMessages();
            }
        }

        public void DisplayMessages ()
        {
            switch(Cells[Player.Row][Player.Col])
            {
                case 'X':
                    MessageDisplayer.Alert("Hit 'x' to exit!");
                    break;

                case '$':
                    MessageDisplayer.Alert("Look at all that wealth! To... redistribute among the poor...");
                    break;
            }
        }

        public void ClearPlayerPosition ()
        {
            BoardDisplayer.OutputCell(Cells[Player.Row][Player.Col], Player.DisplayCol, Player.DisplayRow);
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
