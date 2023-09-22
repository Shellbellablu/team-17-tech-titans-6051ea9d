using System.Drawing;
using LevelUpGame.levelup;
using static levelup.GameController;


namespace levelup
{
    public class Character
    {
        private readonly string DEFAULT_CHARACTER_NAME = "Thor";
        private string Name;
        public Position currentPosition;
        public Map map;


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






        public Position getPosition() 
        {
            return currentPosition;
        }

        public void move(DIRECTION direction)
        {
            map.calculatePosition(currentPosition,direction);
        }

        public void enterMap(Map controllerMap)
        {
            map = controllerMap;
        }

    }
}