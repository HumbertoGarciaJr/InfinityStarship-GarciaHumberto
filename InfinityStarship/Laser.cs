/* Description: Laser Class focusing on games shooting system, Author: Humberto Garcia */
//CLASS IMPLEMENTATION FILE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//Using namespace System.Windows.Forms allows use of Windows.Forms controls/properties

//Project/Namespace Infinity Starship
namespace InfinityStarship
{
    //Class Laser
    class Laser
    {
        //Objects Instantiation & Attribute Properties Function(Declarations)
        public PictureBox laser;
        public int laserSpeed { get; set; }
        public playScreenForm form;

        //Constructor
        public Laser (playScreenForm form)//1 parameter
        {
            //TODO
        }

        //Function Init to hold all methods within one
        private void Init()
        {

        }
    }
}
