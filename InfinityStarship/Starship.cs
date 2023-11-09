/* Description: Starship Class focusing on games spaceship, Author: Humberto Garcia */
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
    //Class Starship
    class Starship
    {
        //Objects Instantiation & Attributes Properties Functions(Declarations)
        public PictureBox spaceship;
        public int spaceshipSpeed { get; set; }
        public playScreenForm form;

        //Constructor
        public Starship (playScreenForm form)//1 parameter
        {
            //Objects/Attributes Initializations
            this.form = form;//store form(parameter) into this(Starship) form
            spaceshipSpeed = 5;//store 5 into spaceshipSpeed

            //Call Function Init
            Init();
        }

        //Function Init to hold all methods within one
        private void Init()
        {
            //Call Function spawnSpaceship
            spawnSpaceship();
        }

        //Function spawnSpaceship to build and Spawn spaceship(Starship)
        private void spawnSpaceship()
        {
            //Local Instantiation
            PictureBox pictureBox = form.pictureBox_spaceship;

            //Store new class PictureBox into spaceship object
            spaceship = new PictureBox()
            {//spaceship Properties Constructor
                Image = pictureBox.Image,//Use Image of pictureBox_spaceship
                Width = 100,//PictureBox Width of 100
                Height = 75,//PictureBox Height of 75
                Visible = true,//PictureBox Visibility at true
                Left = (form.ClientSize.Width - 100) / 2,//PictureBox at Left of ClientSize form - 100 / 2(Position Middle Horizontally)
                Top = (form.ClientSize.Height - 100)//PictureBox at Top of ClientSize form - 100(Position Bottom Vertically)
            };

            //Call Function Add to Property of form(playScreenForm)
            form.Controls.Add(spaceship);//adding spaceship PictureBox as a available control to the form(frmArkanoid)
        }

        //Function moveControl to Control movement of the spaceship(arrow keys to move)
        public void moveControl(KeyEventArgs e)
        {
            //If/Else If Statement if Left Key is being pressed...else if
            if (e.KeyCode == Keys.Left)
            {
                //Store compound subtraction of spaceshipSpeed into Left Property of spaceship(Goes Left)
                spaceship.Left -= spaceshipSpeed;
            }
            else if (e.KeyCode == Keys.Right)//Right Key is being pressed
            {
                //Store compound addition of spaceshipSpeed into Left Property of spaceship(Making it go Right)
                spaceship.Left += spaceshipSpeed;
            }

            //If/Else If Statement if spaceship hits/collides the Left Edge...else if
            if (spaceship.Left <= 0)
            {
                //Store 0 into Left
                spaceship.Left = 0;
            }
            else if (spaceship.Right >= form.ClientSize.Width)//spaceship hits/collides the Right Edge
            {
                //Store Width Property of ClientSize form - Width Property of spaceship into Left(Goes Right) Property of spaceship
                spaceship.Left = form.ClientSize.Width - spaceship.Width;
            }
        }
    }
}
