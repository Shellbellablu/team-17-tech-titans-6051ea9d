using NUnit.Framework;
using levelup;

namespace levelup
{
    [TestFixture]
    public class CharacterTest
    {
        private Character? testObj;

        [Test]
        public void EmptyCharacter()
        {
            testObj = new Character();
            string result = testObj.getName();

            Assert.AreEqual("Thor", result);
        }

        [Test]
        public void NameCharacter()
        {
            string Name = "Carole";
            testObj = new Character(Name);
            string result = testObj.getName();

            Assert.AreEqual(Name, result);
        }

        [Test] //move
        public void move()
        {
            DIRECTION direction = "EAST";
            testObj = new Character();
            var startPosition = testObj.getPosition();
            testObj.move(direction);
            var endPosition = testObj.getPosition();


            Assert.AreEqual(startPosition.coordinates.xCoordinates + 1, endPosition.coordinates.yCoordinates);
        }

    }
}