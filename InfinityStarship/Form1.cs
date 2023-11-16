/* Description: playScreenForm(Form1) Form Class that handles the UI window screen for playing the game, Author: Humberto Garcia */
//CLASS IMPLEMENTATION FILE

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Project/Namespace InfinityStarship
namespace InfinityStarship
{
    //Class playScreenForm
    public partial class playScreenForm : Form
    {
        //Objects Instantiation
        Starship spaceship;//declare spaceship obj of Class Starship
        UFO enemies;//declare enemies obj of Class UFO
        Laser lasers;//declare lasers obj of Class Laser

        //Variables
        int enemiesCurrentMs = 0;//enemies current starting running milliseconds

        //Default Constructor
        public playScreenForm()
        {
            //Default Call Function
            InitializeComponent();
        }

        //Function event playScreenForm_Load to Load on Startup of playScreenForm form
        private void playScreenForm_Load(object sender, EventArgs e)
        {
            //Store new Class Starship into spaceship
            spaceship = new Starship(this);//initialize spaceship obj accessing Class Starship in this(playScreenForm) form
            //Store new Class UFO into enemies
            enemies = new UFO(this);//initialize enemies obj accessing Class UFO in this(playScreenForm) form
            //Store new Class Laser into lasers
            lasers = new Laser(this, spaceship, enemies);//initialize lasers obj accessing Class Laser in this(playScreenForm) form
        }

        //Function event playScreenForm_KeyDown to Occur when the Key is being pressed down
        private void playScreenForm_KeyDown(object sender, KeyEventArgs e)
        {
            //Call Function moveControl of spaceship
            spaceship.moveControl(e);
            //Call Function moveLaserControl of lasers
            lasers.moveLaserControl(e);
        }

        //Function event playScreenForm_Tick to Run Timer constantly updating game's behaviors of playScreenForm form
        private void playScreenForm_Tick(object sender, EventArgs e)
        {
            //Switch Case based on current given level
            switch (enemies.increasedLevelSpeed)
            {
                case (1):
                    //Store +100 compound addition from each previous level(starting from Default 100 value of level 1) into enemiesCurrentMs
                    enemiesCurrentMs += 100;
                    break;
                case (2):
                    enemiesCurrentMs += 200;
                    break;
                case (3):
                    enemiesCurrentMs += 300;
                    break;
                case (4):
                    enemiesCurrentMs += 400;
                    break;
                case (5):
                    enemiesCurrentMs += 500;
                    break;
                case (6):
                    enemiesCurrentMs += 600;
                    break;
                case (7):
                    enemiesCurrentMs += 700;
                    break;
                case (8):
                    enemiesCurrentMs += 800;
                    break;
                case (9):
                    enemiesCurrentMs += 900;
                    break;
                case (10):
                    enemiesCurrentMs += 1000;
                    break;
                case (11):
                    enemiesCurrentMs += 1100;
                    break;
                case (12):
                    enemiesCurrentMs += 1200;
                    break;
                case (13):
                    enemiesCurrentMs += 1300;
                    break;
                case (14):
                    enemiesCurrentMs += 1400;
                    break;
                default:
                    enemiesCurrentMs += 1500;
                    break;
            }

            //If Statement if enemiesCurrentMs is greater than or equal to 3000
            if (enemiesCurrentMs >= 3000)//enables enemies to move at their own adjusted speed
            {
                //Call Function moveEnemyWave of enemies
                enemies.moveEnemyWave();
                //Store 0 into enemiesCurrentMs
                enemiesCurrentMs = 0;//reset to 0 milliseconds everytime a new tick is reached
            }

            //Call Function shootLaser of lasers
            lasers.shootLaser();

            //Store string value + totalScore of Class Score into label_score Property
            label_score.Text = "SCORE: " + Score.totalScore;
            //Store string value + increasedLevelSpeed of enemies into label_level Property
            label_level.Text = "LEVEL: " + enemies.increasedLevelSpeed;

            //If Statement if gameOver of Class Score is true
            if (Score.gameOver == true)
            {
                //Store bool value false into timer_playScreenForm Property
                timer_playScreenForm.Enabled = false;                
                //Call Function Show of MessageBox to display game's over with final score
                MessageBox.Show("         Game Over\n" +
                                "     Final Score: " + Score.totalScore);
            }
        }
    }
}
