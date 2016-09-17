namespace Spiral
{
    public class Player
    {
        public int Row { get; set; }
        public int Col { get; set; }

        public Player ()
        {
            Row = 0;
            Col = 0;
        }

        public void Move(string direction)
        {
            switch (direction)
            {
                case "s":
                    Row++;
                    break;

                case "e":
                    Col++;
                    break;

                case "n":
                    Row--;
                    break;

                case "w":
                    Col--;
                    break;

                case "se":
                    Row++;
                    Col++;
                    break;

                case "sw":
                    Row++;
                    Col--;
                    break;

                case "ne":
                    Row--;
                    Col++;
                    break;

                case "nw":
                    Row--;
                    Col--;
                    break;
            }
        }
    }
}
