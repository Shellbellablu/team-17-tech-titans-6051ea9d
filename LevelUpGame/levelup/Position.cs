using System.Drawing;

namespace LevelUpGame.levelup
{
    public class Position
    {
        public Point coordinates;

        public Position(int xCoordinates, int yCoordinates)
        {
            coordinates.X = xCoordinates;
            coordinates.Y = yCoordinates;
        }   
    }
}
