using NUnit.Framework;
using levelup;

namespace levelup
{
    [TestFixture]
    public class MapTest
    {
        private Map? testObj;

        [Test]
        public void IsPositionFound()
        {
            testObj=new Map();// create a fake map
            var result=testObj.getPositions();

            Assert.Equals(0, result.xCoordinate);
            Assert.Equals(0, result.yCoordinate);
        }
        [Test]
        public void IsPositionCalculated()
        {
            testObj=new Map();// create a fake map
            testObj.coordinates.xCoordinate = 0;
            testObj.coordinates.yCoordinate = 0;

            testObj.calculatePosition(testObj, NORTH)

            Assert.Equals(0, testObj.coordinates.xCoordinate)
            Assert.Equals(1, testObj.coordinates.yCoordinate)
        }
        [Test]
        public void IsPositionValid()
        {
            testObj=new Map();// create a fake map
            testObj.coordinates.xCoordinate

            Assert.IsTrue(IsPositionValid(Position positionCoordinates));
            Assert.IsTrue(positionCoordinates.coordinates.xCoordinate <= 9);
            Assert.IsTrue(positionCoordinates.coordinates.yCoordinate >= 0);
            Assert.IsTrue(positionCoordinates.coordinates.yCoordinate <= 9);
        }
        [Test]
        public void IsTotalPositionsFound()
        {
            testGetTotalPositions
        }
    }
}
