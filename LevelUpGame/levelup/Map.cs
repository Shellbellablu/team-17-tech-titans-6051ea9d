using LevelUpGame.levelup;
using static levelup.GameController;

namespace levelup
{
    public class Map
    {
        private int numPositions=100;
        public List<Position> positions =new List<Position>();

        public List<Position> getPositions()
        {
            return positions;
        }
        public void calculatePosition(Position startingPosition, DIRECTION direction)
        {
            var temp = new Position(startingPosition.coordinates.X, startingPosition.coordinates.Y);
            var validMove = false;

            switch(direction) 
            {
                case DIRECTION.NORTH:
                    temp.coordinates.Y++;
                    if (IsPositionValid(temp))
                    {
                        startingPosition.coordinates.Y++;
                        validMove = true;
                    }
                    break;
                case DIRECTION.SOUTH:
                    temp.coordinates.Y--;
                    if (IsPositionValid(temp))
                    {
                        startingPosition.coordinates.Y--;
                        validMove = true;
                    }
                    break;
                case DIRECTION.EAST:
                    temp.coordinates.X++;
                    if (IsPositionValid(temp))
                    {
                        startingPosition.coordinates.X++;
                        validMove = true;
                    }
                    break;
                case DIRECTION.WEST:
                    temp.coordinates.X--;
                    if (IsPositionValid(temp))
                    {
                        startingPosition.coordinates.X--;
                        validMove = true;
                    }
                    break;
            }

            if (validMove) positions.Add(startingPosition);
        }
        public bool IsPositionValid(Position positionCoordinates)
        {
            
            //TODO: check
           if (positionCoordinates.coordinates.X>=0 &
            positionCoordinates.coordinates.X<=9 &
            positionCoordinates.coordinates.Y>=0 &
            positionCoordinates.coordinates.Y<=9)
            {
               return true;
            }
            return false;
            }
        public int GetTotalPositions()
        {
            return numPositions;
        }
    }
}