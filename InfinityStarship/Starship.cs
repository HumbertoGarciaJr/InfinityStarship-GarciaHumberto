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
        //Objects
        //Instantiations/Attributes Properties Functions(Declarations)
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
            //Store new class PictureBox into spaceship object
            spaceship = new PictureBox()
            {//spaceship Properties Constructor
                BackColor = Color.Black,//Temporary PictureBox Backcolor of Black
                Width = 100,//PictureBox Width of 100
                Height = 75,//PictureBox Height of 75
                Visible = true,//PictureBox Visibility at true
                Left = (form.ClientSize.Width - 100) / 2,//PictureBox at Left of ClientSize form - 100 / 2(Position Middle Horizontally)
                Top = (form.ClientSize.Height - 100)//PictureBox at Top of ClientSize form - 100(Position Bottom Vertically)
            };

            //Call Function Add to Property of form(playScreenForm)
            form.Controls.Add(spaceship);//adding spaceship PictureBox as a available control to the form(frmArkanoid)
        }

        //TODO
    }
}
