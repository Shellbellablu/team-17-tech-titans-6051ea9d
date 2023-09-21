using NUnit.Framework;
using levelup;
using LevelUpGame.levelup;

namespace LevelUpGame.Test.levelup
{
    [TestFixture]
    
    public class PositionTest
    {
        [Test]
        public void Position()
        {
            var positionObj = new Position(0, 0);

            Assert.AreEqual(0, positionObj.coordinates.xCoordinates);
            Assert.AreEqual(0, positionObj.coordinates.yCoordinates);
        }
    }
}
