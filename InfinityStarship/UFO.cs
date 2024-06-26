﻿/* Description: UFO Class focusing on games enemies, Author: Humberto Garcia */
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
        public int increasedLevelSpeed { get; set; }
        playScreenForm form;
        public List<PictureBox> enemies;

        //Constructor
        public UFO(playScreenForm form)//1 parameter
        {
            //Objects/Attributes Initializations
            this.form = form;//store form(parameter) into this(UFO) form
            enemySpeedX = 25;//store 25 into enemySpeedX(25 pixels per tick)
            enemySpeedY = 100;//store 100 into enemySpeedY(100 pixels per tick)
            increasedLevelSpeed = 1;//store 1 into increasedLevelSpeed(default speed should begin by level 1)
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
            //Local Instantiation
            ImageList imageList = form.imageList_enemies;

            //For Loop running i 12 times
            for (int i = 0; i <= 11; i++)
            {
                //Call Function Add of enemies(To store new class PictureBox into enemies list)
                enemies.Add(new PictureBox()
                {//enemies list Properties Constructor
                    Image = imageList.Images[0],//Use Image at index 0 of imageList_enemies
                    BackColor = Color.Transparent,//Use Transparent BackColor
                    Width = 75,//Image Width of 75
                    Height = 75,//Image Height of 75
                    Visible = true,//Image Visibility at true
                    Left = 725,//Image at Left of 725(Default)
                    Top = 100,//Image at Top of 100(Default)
                    Tag = "Enemy",//Image Tag of "Enemy" for each enemies list enemy index
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
            //Local Variables
            bool xReverseFlag = false;

            //For Loop running i based on count Property of enemies list(12 enemies)
            for (int i = 0; i < enemies.Count; i++)
            {
                //If/Else If Statement if current enemySpeedX is greater than 0(any positive enemySpeedX value goes horizontally right)...else if
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

                //If Statement if current enemies index Left Property is less than or equal to 0, Or
                //current enemies index is greater than or equal to Width Property of ClientSize form
                if (enemies[i].Left <= 0 || enemies[i].Right >= form.ClientSize.Width)
                {
                    //Store bool value true into xReverseFlag
                    xReverseFlag = true;//allows every enemies index to loop properly before any next procedure.
                }
            }
            //If Statement if xReverseFlag equals true
            if (xReverseFlag == true)
            {
                //Store value -1 into enemySpeedX
                enemySpeedX *= -1;//speed reverses to opposite value, switching horizontally its x moving direction from edge to edge

                //For Loop running i based on count Property of enemies list(12 enemies)
                for (int i = 0; i < enemies.Count; i++)
                {
                    //Store compound addition of current enemySpeedX value into Left Property of enemies index(stops enemies x moving direction once per edge)
                    enemies[i].Left += enemySpeedX;
                    //Store compound addition of current enemySpeedY value into Top Property of enemies index(allows to move enemies y direction once per edge)
                    enemies[i].Top += enemySpeedY;
                }
            }

            //Call Function nextEnemyWave
            nextEnemyWave();
            //Call Function gameOver
            gameOver();
        }

        //Function nextEnemyWave to build and spawn the next wave of enemies(UFOs)
        private void nextEnemyWave()
        {
            //If Statement if enemies count Property equals 0(All enemies have been destroyed)
            if (enemies.Count == 0)
            {
                //Process calculation increasedLevelSpeed postfix increment
                increasedLevelSpeed++;

                //If Statement if enemySpeedX is less than 0
                if (enemySpeedX < 0)
                {
                    //Store value -1 into enemySpeedX
                    enemySpeedX *= -1;//makes every next enemy wave start going right
                }

                //If Statement if enemySpeedX is less than 80
                if (enemySpeedX < 80)
                {
                    //Process calculation enemySpeedX postfix increment
                    enemySpeedX++;//makes every next enemy wave jump by one increasing pixel, conveying acceleration to further increase difficulty
                }

                //Call Function spawnEnemyWave
                spawnEnemyWave();
            }
        }

        //Function gameOver to End/Stop the current game when descending enemies reach spaceship
        private void gameOver()
        {
            //For Loop running i based on count Property of enemies list(12 enemies)
            for (int i = 0; i < enemies.Count; i++)
            {
                //If statement if current enemies index Top Property equals 900(Relative spaceship vertical location)
                if (enemies[i].Top == 900)
                {
                    //Store bool value true into gameOver value of Class Score
                    Score.gameOver = true;

                    return;//Exit Function
                }
            }
        }
    }
}
