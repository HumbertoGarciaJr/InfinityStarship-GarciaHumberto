
namespace InfinityStarship
{
    partial class playScreenForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playScreenForm));
            this.timer_playScreenForm = new System.Windows.Forms.Timer(this.components);
            this.imageList_enemies = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox_spaceship = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_spaceship)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_playScreenForm
            // 
            this.timer_playScreenForm.Enabled = true;
            this.timer_playScreenForm.Interval = 25;
            this.timer_playScreenForm.Tick += new System.EventHandler(this.playScreenForm_Tick);
            // 
            // imageList_enemies
            // 
            this.imageList_enemies.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_enemies.ImageStream")));
            this.imageList_enemies.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_enemies.Images.SetKeyName(0, "UFO.png");
            // 
            // pictureBox_spaceship
            // 
            this.pictureBox_spaceship.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_spaceship.Image")));
            this.pictureBox_spaceship.Location = new System.Drawing.Point(350, 365);
            this.pictureBox_spaceship.Name = "pictureBox_spaceship";
            this.pictureBox_spaceship.Size = new System.Drawing.Size(100, 75);
            this.pictureBox_spaceship.TabIndex = 0;
            this.pictureBox_spaceship.TabStop = false;
            this.pictureBox_spaceship.Visible = false;
            // 
            // playScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox_spaceship);
            this.Name = "playScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play Screen Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.playScreenForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.playScreenForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_spaceship)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_playScreenForm;
        public System.Windows.Forms.ImageList imageList_enemies;
        public System.Windows.Forms.PictureBox pictureBox_spaceship;
    }
}

