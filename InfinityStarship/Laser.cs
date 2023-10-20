/* Description: Laser Class focusing on games shooting system, Author: Humberto Garcia */
//CLASS IMPLEMENTATION FILE

using System;
using System.Collections.Generic;
using System.Drawing;//Using namespace System.Drawing to allow use of Drawing controls/properties
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
        public List<PictureBox> lasers;

        //Constructor
        public Laser (playScreenForm form)//1 parameter
        {
            this.form = form;//store form(parameter) into this(Laser) form
            laserSpeed = 5;//store 5 into laserSpeed
            lasers = new List<PictureBox>();//store new class PictureBox obj collection List into lasers

            //Call Function Init
            Init();
        }

        //Function Init to hold all methods within one
        private void Init()
        {
            //Store new class PictureBox into laser object
            laser = new PictureBox()
            {//laser Properties Constructor
                BackColor = Color.Red,//PictureBox Backcolor of Red
                Width = 10,//PictureBox Width of 10
                Height = 50,//PictureBox Height of 50
                Visible = false,//Temporary PictureBox Visibility at true
                Left = (form.ClientSize.Width - 10) / 2,//Temporary PictureBox at Left of ClientSize form - 10 / 2(Position Middle Horizontally)
                Top = (form.ClientSize.Height - 150)//Temporary PictureBox at Top of ClientSize form - 150(Position Bottom Vertically)
            };

            //Call Function Add to Property of form(playScreenForm)
            form.Controls.Add(laser);//adding laser PictureBox as a available control to the form(frmArkanoid)
        }

        //TODO
    }
}
