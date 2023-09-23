/* Description: Starship Class focusing on games spaceship, Author: Humberto Garcia */
//CLASS IMPLEMENTATION FILE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//namespace System.Windows.Forms allows use of Windows.Forms controls/properties

//Project/Namespace InfinityStarship
namespace InfinityStarship
{
    //Class Starship
    class Starship
    {
        //Objects
        //Instantiations/Attributes Properties
        public PictureBox spaceship;
        public int spaceshipSpeed { get; set; }
        public playScreenForm form;

        //Constructor
        public Starship (playScreenForm form)//1 parameter
        {
            //Attribute Initializations
            this.form = form;//store form(parameter) into this(Starship) form
            spaceshipSpeed = 5;//store 5 into spaceshipSpeed
            spaceship = new PictureBox();//store new class PictureBox into spaceship object

            //Call Function Init
            Init();
        }

        //Function Init to hold all methods within one
        private void Init()
        {
            //TODO
        }
    }
}
