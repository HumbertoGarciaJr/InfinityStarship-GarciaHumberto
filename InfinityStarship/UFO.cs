/* Description: UFO Class focusing on games enemies, Author: Humberto Garcia */
//CLASS IMPLEMENTATION FILE

using System;
using System.Collections.Generic;
using System.Drawing;//Using namespace System.Drawing to allow use of Drawing controls/properties
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//Using namespace System.Windows.Forms allows use of Windows.Forms controls/properties

//Project/Namespace InfinityStarship
namespace InfinityStarship
{
    //Class UFO
    class UFO
    {
        //Objects Instatiation & Attribute Properties Function(Declarations)
        public PictureBox enemy;
        public int enemySpeedX { get; set; }
        public int enemySpeedY { get; set; }
        public int increasedSpeed;
        playScreenForm form;
        public List<PictureBox> enemies;

        //Constructor
        public UFO(playScreenForm form)//1 parameter
        {
            //Objects/Attributes Initializations
            this.form = form;//store form(parameter) into this(UFO) form
            enemySpeedX = 5;//store 5 into enemySpeedX(5 pixels per tick)
            enemySpeedY = 5;//store 5 into enemySpeedY(5 pixels per tick)
            increasedSpeed = 0;//store 0 into increasedSpeed(default speed should not be increased)

            //Call Function Init
            Init();
        }

        //Function Init to hold all methods within one
        private void Init()
        {
            //Call Function spawnEnemyWave
            spawnEnemyWave();
        }

        //Function spawnEnemyWave to build and spawn enemies(UFOs)
        private void spawnEnemyWave()
        {
            //TODO
        }
    }
}
