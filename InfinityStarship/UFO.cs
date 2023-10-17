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
            enemySpeedX = 25;//store 25 into enemySpeedX(25 pixels per tick)
            enemySpeedY = 5;//store 5 into enemySpeedY(5 pixels per tick)
            increasedSpeed = 0;//store 0 into increasedSpeed(default speed should not be increased)
            enemies = new List<PictureBox>();//store new class PictureBox obj collection List into enemies

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
            //For Loop running i 12 times
            for (int i = 0; i <= 11; i++)
            {

                //Call Function Add of enemies(To store new class PictureBox into enemies list)
                enemies.Add(new PictureBox()
                {//enemies list Properties Constructor
                    BackColor = Color.ForestGreen,//Temporary PictureBox Backcolor of ForestGreen
                    Width = 75,//PictureBox Width of 75
                    Height = 75,//PictureBox Height of 75
                    Visible = true,//PictureBox Visibility at true
                    Left = 725,//PictureBox at Left of 725(Default)
                    Top = 100,//PictureBox at Top of 100(Default)
                });

                //Switch Case based on given current index
                switch (i)
                {
                    case (1):
                        //Store +125 from each previous Left value(starting from Default value) into Left of enemies index i(current index of for loop) &
                        //Store +100 from each previous Top value(starting from Default value) intot Top of enemies index i(current index of for loop)
                        enemies[i].Left = 850;
                        break;
                    case (2):
                        enemies[i].Left = 975;
                        break;
                    case (3):
                        enemies[i].Left = 1100;
                        break;
                    case (4):
                        enemies[i].Left = 725;
                        enemies[i].Top = 200;
                        break;
                    case (5):
                        enemies[i].Left = 850;
                        enemies[i].Top = 200;
                        break;
                    case (6):
                        enemies[i].Left = 975;
                        enemies[i].Top = 200;
                        break;
                    case (7):
                        enemies[i].Left = 1100;
                        enemies[i].Top = 200;
                        break;
                    case (8):
                        enemies[i].Left = 725;
                        enemies[i].Top = 300;
                        break;
                    case (9):
                        enemies[i].Left = 850;
                        enemies[i].Top = 300;
                        break;
                    case (10):
                        enemies[i].Left = 975;
                        enemies[i].Top = 300;
                        break;
                    case (11):
                        enemies[i].Left = 1100;
                        enemies[i].Top = 300;
                        break;
                }

                //Call Function Add to Property of form(playScreenForm)
                form.Controls.Add(enemies[i]);//adding enemy index to enemies list of PictureBoxes as a available controls to the form(playScreenForm)
            }
        }

        //Function moveEnemyWave to Control movement behaviors of the enemies(Computer Automated Movement Horizontally/Vertically)
        public void moveEnemyWave()
        {
            //For Loop running i based on count Property of enemies list(12 enemies)
            for (int i = 0; i < enemies.Count; i++)
            {
                //If/Else If statement if current enemySpeedX is greater than 0(any positive enemySpeedX value goes horizontally right)...else if
                if (enemySpeedX > 0)
                {
                    //Store compound addition of positive enemySpeedX value into Left Property of enemies index(Making enemies go Right)
                    enemies[i].Left += enemySpeedX;
                }
                else if (enemySpeedX < 0)//current enemySpeedX is less than 0(any negative enemySpeedX value goes horizontally left)
                {
                    //Store compound addition of negative enemySpeedX value into Left Property of enemies index(Making enemies go Left)
                    enemies[i].Left += enemySpeedX;
                }
                //TODO
            }
        }
    }
}
