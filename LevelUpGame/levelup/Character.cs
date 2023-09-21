using System.Drawing;

namespace levelup
{
    public class Character
    {
        private readonly string DEFAULT_CHARACTER_NAME = "Thor";
        private string Name;

        public Character()
        {
            Name = DEFAULT_CHARACTER_NAME;
        }

        public Character(string newName)
        {
            Name = newName;
        }

        public string getName() 
        {
            return Name;
        }


    }
}