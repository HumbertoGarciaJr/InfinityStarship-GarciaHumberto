
namespace InfinityStarship
{
    partial class playerIDEntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playerIDEntryForm));
            this.label_description = new System.Windows.Forms.Label();
            this.label_playerID = new System.Windows.Forms.Label();
            this.textBox_playerID = new System.Windows.Forms.TextBox();
            this.textBox_leaderboard = new System.Windows.Forms.TextBox();
            this.label_rank = new System.Windows.Forms.Label();
            this.label_leaderboard = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_description.Font = new System.Drawing.Font("Nachlieli CLM", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_description.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_description.Location = new System.Drawing.Point(401, 67);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(271, 37);
            this.label_description.TabIndex = 0;
            this.label_description.Text = "NAME       SCORE";
            // 
            // label_playerID
            // 
            this.label_playerID.AutoSize = true;
            this.label_playerID.Font = new System.Drawing.Font("Nachlieli CLM", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_playerID.ForeColor = System.Drawing.Color.White;
            this.label_playerID.Location = new System.Drawing.Point(37, 84);
            this.label_playerID.Name = "label_playerID";
            this.label_playerID.Size = new System.Drawing.Size(292, 82);
            this.label_playerID.TabIndex = 1;
            this.label_playerID.Text = "ENTER PLAYER \r\nNAME:";
            this.label_playerID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_playerID
            // 
            this.textBox_playerID.Font = new System.Drawing.Font("Nachlieli CLM", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_playerID.Location = new System.Drawing.Point(34, 169);
            this.textBox_playerID.Name = "textBox_playerID";
            this.textBox_playerID.Size = new System.Drawing.Size(295, 64);
            this.textBox_playerID.TabIndex = 2;
            this.textBox_playerID.Text = "ABC";
            this.textBox_playerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_leaderboard
            // 
            this.textBox_leaderboard.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_leaderboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_leaderboard.Font = new System.Drawing.Font("Nachlieli CLM", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_leaderboard.Location = new System.Drawing.Point(401, 104);
            this.textBox_leaderboard.Multiline = true;
            this.textBox_leaderboard.Name = "textBox_leaderboard";
            this.textBox_leaderboard.ReadOnly = true;
            this.textBox_leaderboard.Size = new System.Drawing.Size(271, 328);
            this.textBox_leaderboard.TabIndex = 3;
            this.textBox_leaderboard.Text = "ABC";
            // 
            // label_rank
            // 
            this.label_rank.Font = new System.Drawing.Font("Nachlieli CLM", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_rank.ForeColor = System.Drawing.Color.White;
            this.label_rank.Location = new System.Drawing.Point(350, 104);
            this.label_rank.Name = "label_rank";
            this.label_rank.Size = new System.Drawing.Size(55, 328);
            this.label_rank.TabIndex = 4;
            this.label_rank.Text = "1.\r\n2.\r\n3.\r\n4.\r\n5.\r\n6.\r\n7.\r\n8.\r\n9.\r\n10.";
            this.label_rank.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_leaderboard
            // 
            this.label_leaderboard.AutoSize = true;
            this.label_leaderboard.Font = new System.Drawing.Font("Nachlieli CLM", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_leaderboard.ForeColor = System.Drawing.Color.White;
            this.label_leaderboard.Location = new System.Drawing.Point(397, 28);
            this.label_leaderboard.Name = "label_leaderboard";
            this.label_leaderboard.Size = new System.Drawing.Size(275, 39);
            this.label_leaderboard.TabIndex = 5;
            this.label_leaderboard.Text = "LEADERBOARD:";
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Nachlieli CLM", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_save.Location = new System.Drawing.Point(93, 278);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(180, 50);
            this.button_save.TabIndex = 6;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // playerIDEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label_leaderboard);
            this.Controls.Add(this.textBox_leaderboard);
            this.Controls.Add(this.textBox_playerID);
            this.Controls.Add(this.label_playerID);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_rank);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "playerIDEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player ID Entry Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Label label_playerID;
        private System.Windows.Forms.TextBox textBox_playerID;
        private System.Windows.Forms.TextBox textBox_leaderboard;
        private System.Windows.Forms.Label label_rank;
        private System.Windows.Forms.Label label_leaderboard;
        private System.Windows.Forms.Button button_save;
    }
}