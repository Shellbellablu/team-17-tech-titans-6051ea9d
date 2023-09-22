using NUnit.Framework;
using levelup;
using LevelUpGame.levelup;
using levelup.cli;
using static levelup.GameController;

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

        [Test]
        public void move()
        {
            DIRECTION direction = DIRECTION.EAST;
            testObj = new Character();
            var startPosition = testObj.getPosition();
            testObj.move(direction);
            var endPosition = testObj.getPosition();


            //Assert.AreEqual(startPosition.coordinates.X + 1, endPosition.coordinates.Y);
        }


[Test]
        public void enterMap(Map controllerMap)
        {
            testObj.enterMap(controllerMap); 
        }


    }
}