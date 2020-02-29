using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public class Level
    {
        public static int levelNumber = 0;
        public static int LevelNumber
        {
            get { return ++levelNumber; } 
        }        
        
        internal int NumberOfEnemies
        {
            get { return (levelNumber * 2); }
        }

        internal int EnemyInitialHealth
        {
            get { return ((levelNumber * 2) + 1); } 
        }

        public Level(int xPos, int yPos, int score=0, int playerHealth=100) 
        {
            GameForm f = new GameForm(xPos, yPos, LevelNumber, score, NumberOfEnemies);
            f.Visible = true;
            f.player.PlayerHealth = playerHealth;


        }
    }
}
