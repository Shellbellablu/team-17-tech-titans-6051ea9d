using NUnit.Framework;
using levelup;

namespace levelup
{
    [TestFixture]
    public class GameControllerTest
    {
        private GameController? testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new GameController();
        }

        [Test]
        public void IsGameResultInitialized()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            Assert.IsNotNull(testObj.GetStatus());
        }
        [Test]
        public void test_move()
        {
        }
        [Test]
        public void test_createCharacter()   
        {
        }
        [Test]
        public void test_startGame()
        {

        }
        [Test]
        public void test_getStatus()
        {

        }
        [Test]
        public void test_setCharacterPosition()
        {

        }
       
    }
}