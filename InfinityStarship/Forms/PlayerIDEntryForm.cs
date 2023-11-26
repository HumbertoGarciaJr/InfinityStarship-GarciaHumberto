/* Description: playerIDEntryForm Form Class that handles the UI window screen to prompt player to save and show their data
 * in the Leaderboard Store/Database system, Author: Humberto Garcia */
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
    //Class playerIDEntryForm
    public partial class playerIDEntryForm : Form
    {
        //Default Constructor
        public playerIDEntryForm()
        {
            InitializeComponent();
        }

        //Function event playerIDEntryForm_Load to Load on Startup of playerIDEntryForm form
        private void playerIDEntryForm_Load(object sender, EventArgs e)
        {

        }

        //Function event playerIDEntryForm_Save_Click to Save player input data(Name, Points)
        private void playerIDEntryForm_Save_Click(object sender, EventArgs e)
        {
            //Store bool value false into button_save Property
            button_save.Enabled = false;
            //Store textBox_playerID Property + totalScore of Class Score into textBox_leaderboard Property
            textBox_leaderboard.Text = textBox_playerID.Text + "\t   " + Score.getScore;//temporary hardcoded string values(change to small database flatfile)
        }
    }
}
