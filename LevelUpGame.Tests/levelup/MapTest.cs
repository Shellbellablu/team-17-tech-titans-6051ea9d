using NUnit.Framework;
using levelup;
using LevelUpGame.levelup;
using static levelup.GameController;
using System.Linq;

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

            Assert.Equals(1, result.Count);
        }
        [Test]
        public void IsPositionCalculated()
        {
            testObj=new Map();// create a fake map
            var temp = new Position(0, 0);

            testObj.calculatePosition(temp, DIRECTION.NORTH);

            Assert.Equals(0, testObj.positions.First().coordinates.X);
            Assert.Equals(1, testObj.positions.First().coordinates.Y);
        }

        [Test]
        public void IsPositionValid()
        {
            testObj=new Map();// create a fake map

            Assert.IsTrue(testObj.IsPositionValid(new Position(0, 0)));
            Assert.IsTrue(testObj.IsPositionValid(new Position(0, 9)));
            Assert.IsTrue(testObj.IsPositionValid(new Position(9, 0)));
            Assert.IsTrue(testObj.IsPositionValid(new Position(9, 9)));
        }
        [Test]
        public void IsTotalPositionsFound()
        {
            
        }
    }
}
