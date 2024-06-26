﻿/* Description: Laser Class focusing on games shooting system, Author: Humberto Garcia */
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
        public List<PictureBox> lasersToDestroy;
        public Starship spaceship_Starship;
        public UFO enemies_UFO;

        //Constructor
        public Laser (playScreenForm form, Starship spaceship, UFO enemies)//3 parameter
        {
            //Objects/Attributes Initializations
            this.form = form;//store form(parameter) into this(Laser) form
            laserSpeed = 8;//store 8 into laserSpeed
            lasers = new List<PictureBox>();//store new class PictureBox obj collection List into lasers
            lasersToDestroy = new List<PictureBox>();//store new class PictureBox obj collection List into lasersToDestroy
            this.spaceship_Starship = spaceship;//store spaceship(Starship parameter) into this(spaceship_Starship) obj instance in our class(Laser)
            this.enemies_UFO = enemies;//store enemies(UFO parameter) into this(enemies_UFO) obj instance in our class(Laser)

            //Call Function Init
            Init();
        }

        //Function Init to hold all methods within one
        private void Init()
        {
            //Store new class PictureBox into laser object
            laser = new PictureBox()
            {//laser Properties Constructor(Placeholder)
                BackColor = Color.Red,//PictureBox Backcolor of Red
                Width = 10,//PictureBox Width of 10
                Height = 30,//PictureBox Height of 30
                Visible = false,//Temporary PictureBox Visibility at false
                Left = (form.ClientSize.Width - 10) / 2,//Temporary PictureBox at Left of ClientSize form - 10 / 2(Position Middle Horizontally)
                Top = (form.ClientSize.Height - 100)//Temporary PictureBox at Top of ClientSize form - 100(Position Bottom Vertically)
            };

            //Call Function Add to Property of form(playScreenForm)
            form.Controls.Add(laser);//adding laser PictureBox as a available control to the form(frmArkanoid)
        }

        //Function moveLaserControl to Control movement of the laser(similarly to 'Starship' class's spaceship)
        public void moveLaserControl(KeyEventArgs e)
        {
            //If/Else If Statement if Left Key is being pressed...else if
            if (e.KeyCode == Keys.Left)
            {
                //Store compound subtraction of laserSpeed into Left Property of laser(Goes Left)
                laser.Left -= laserSpeed;
            }
            else if (e.KeyCode == Keys.Right)//Right Key is being pressed
            {
                //Store compound addition of laserSpeed into Left Property of laser(Making it go Right)
                laser.Left += laserSpeed;
            }

            //If/Else If Statement if spaceship of 'Starship' hits/collides the Left Edge(Laser should stop)...else if
            if (laser.Left <= 45)
            {
                //Store 45 into Left
                laser.Left = 45;
            }
            else if (laser.Right >= form.ClientSize.Width - 45)//spaceship of 'Starship' hits/collides the Right Edge(Laser should stop)
            {
                //Store Width Property of ClientSize form - Width Property of laser - 45 into Left(Goes Right) Property of laser
                laser.Left = form.ClientSize.Width - laser.Width - 45;
            }

            //If Statement if Space Key is being pressed
            if (e.KeyCode == Keys.Space)
            {
                //If Statement if lasers count Property is less than 1(Allows one laser at a time until destroyed from list)
                if (lasers.Count < 1)
                {
                    //Call Function Add of lasers(To store new class PictureBox into lasers list)
                    lasers.Add(new PictureBox()
                    {//lasers list Properties Constructor(Actual) similarly to laser
                        BackColor = Color.Red,
                        Width = 10,
                        Height = 30,
                        Visible = true,
                        Left = laser.Location.X,
                        Top = laser.Location.Y,
                    });

                    //Call Function AddRange to Property of form(playScreenForm)
                    form.Controls.AddRange(lasers.ToArray());//adding lasers to an array as available controls to the form(playScreenForm)
                }
            }
        }

        //Function shootLaser to Control movement behaviors of the lasers(Vertically)
        public void shootLaser()
        {
            //Foreach loop foreach type(laser) in lasers
            foreach(PictureBox laser in lasers)
            {
                //Store compound subtraction of -17 value into Top Property of laser type(Making lasers go Up)
                laser.Top -= 17;

                //If Statement if any laser hits/collides the Top Edge
                if (laser.Top < 0)
                {
                    //Call Function Add to lasersToDestroy List collection
                    lasersToDestroy.Add(laser);
                }
            }

            //Call Function destroyEnemyAndLaser
            destroyEnemyAndLaser();
        }

        //Function destroyEnemyAndLaser to Destroy/Remove enemies/lasers upon any interactive hit/collision
        public void destroyEnemyAndLaser()
        {
            //Foreach loop foreach type(laser) in lasers
            foreach (PictureBox laser in lasers)
            {
                //Foreach loop foreach type(item) in form using Call Function OfType
                foreach (var item in form.Controls.OfType<PictureBox>())
                {
                    //If Statement if "Enemy" is Tag of current item.
                    if (item.Tag == "Enemy")
                    {
                        //If Statement if laser Bounds using Call Function IntersectsWith item Bounds
                        if (laser.Bounds.IntersectsWith(item.Bounds))
                        {
                            //Call Function calculateScore of Class Score
                            Score.calculateScore(item, form);

                            //Call Function Remove to visually destroy current item of form
                            form.Controls.Remove(item);
                            //Call Function Remove to logically destroy item of enemies list
                            enemies_UFO.enemies.Remove(item);
                            //Store 0 - laser.Height into Top Property of laser type(Makes it stop moving Up)
                            laser.Top = 0 - laser.Height;
                        }
                    }
                }
            }

            //Foreach loop foreach type(laser) in lasersToDestroy
            foreach (var laser in lasersToDestroy)
            {
                //Call Function Remove to logically destroy item of enemies list
                lasers.Remove(laser);
                //Call Function Remove to visually destroy current item of form
                form.Controls.Remove(laser);
            }
        }
    }
}
