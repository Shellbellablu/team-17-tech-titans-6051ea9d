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
    }
}