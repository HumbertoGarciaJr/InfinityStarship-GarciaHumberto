/* Description: UFO Class focusing on games enemies, Author: Humberto Garcia */
//CLASS IMPLEMENTATION FILE

using System;
using System.Collections.Generic;
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
            //TODO
        }

        //Function Init to hold all methods within one
        private void Init()
        {

        }
    }
}
