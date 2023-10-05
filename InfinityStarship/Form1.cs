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

        //Variables

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
        }

        //Function event playScreenForm_KeyDown to Occur when the Key is being pressed down
        private void playScreenForm_KeyDown(object sender, KeyEventArgs e)
        {
            //Call Function moveControl of spaceship
            spaceship.moveControl(e);
        }
    }
}
