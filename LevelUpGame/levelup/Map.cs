using System.Drawing;

namespace levelup
{
    public class Map
    {
        int numPositions=100;
        public Position getPositions()
        {
            testCalculatePosition
        }
        public void calculatePosition(Position startingPosition, DIRECTION direction)
        {
            switch(direction) 
            {
                case NORTH:
                    if IsPositionValid(startingPosition.coordinates.yCoordinates++) 
                        startingPosition.coordinates.yCoordinates++;
                break;
                case SOUTH:
                    startingPosition.coordinates.yCoordinates--
                break;
                case EAST:
                    startingPosition.coordinates.xCoordinates++
                break;
                case WEST:
                    startingPosition.coordinates.xCoordinates--
                break;
            }
        }
        public bool IsPositionValid(Position positionCoordinates)
        {
            Assert.Equal(0, positionCoordinates.coordinates.xCoordinates >= 0);
        }
        public int GetTotalPositions()
        {
            
        }
    }
}