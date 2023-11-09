
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
            // playScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "playScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play Screen Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.playScreenForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.playScreenForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_playScreenForm;
        public System.Windows.Forms.ImageList imageList_enemies;
    }
}

