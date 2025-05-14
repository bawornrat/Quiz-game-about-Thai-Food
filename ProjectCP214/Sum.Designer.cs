namespace ProjectCP214
{
    partial class Sum
    {



        /// <summary>
        /// Required designer variable.
        /// </summary>


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ViewScorebutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Scorelabel = new System.Windows.Forms.Label();
            this.restartBtn = new System.Windows.Forms.Button();
            this.settingBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewScorebutton
            // 
            this.ViewScorebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(28)))), ((int)(((byte)(22)))));
            this.ViewScorebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ViewScorebutton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewScorebutton.ForeColor = System.Drawing.Color.White;
            this.ViewScorebutton.Location = new System.Drawing.Point(392, 518);
            this.ViewScorebutton.Name = "ViewScorebutton";
            this.ViewScorebutton.Size = new System.Drawing.Size(126, 52);
            this.ViewScorebutton.TabIndex = 0;
            this.ViewScorebutton.Text = "All Ranks";
            this.ViewScorebutton.UseVisualStyleBackColor = false;
            this.ViewScorebutton.Click += new System.EventHandler(this.ViewScorebutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(28)))), ((int)(((byte)(22)))));
            this.Exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exitbutton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.ForeColor = System.Drawing.Color.White;
            this.Exitbutton.Location = new System.Drawing.Point(712, 518);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(126, 51);
            this.Exitbutton.TabIndex = 1;
            this.Exitbutton.Text = "Thank You";
            this.Exitbutton.UseVisualStyleBackColor = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Namelabel.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Namelabel.Location = new System.Drawing.Point(12, 9);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(213, 45);
            this.Namelabel.TabIndex = 2;
            this.Namelabel.Text = "player_name";
            // 
            // Scorelabel
            // 
            this.Scorelabel.AutoSize = true;
            this.Scorelabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Scorelabel.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scorelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(56)))), ((int)(((byte)(24)))));
            this.Scorelabel.Location = new System.Drawing.Point(561, 344);
            this.Scorelabel.Name = "Scorelabel";
            this.Scorelabel.Size = new System.Drawing.Size(116, 135);
            this.Scorelabel.TabIndex = 3;
            this.Scorelabel.Text = "0";
            this.Scorelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // restartBtn
            // 
            this.restartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(28)))), ((int)(((byte)(22)))));
            this.restartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.restartBtn.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartBtn.ForeColor = System.Drawing.Color.White;
            this.restartBtn.Location = new System.Drawing.Point(551, 518);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(126, 52);
            this.restartBtn.TabIndex = 4;
            this.restartBtn.Text = "Restart";
            this.restartBtn.UseVisualStyleBackColor = false;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // settingBtn
            // 
            this.settingBtn.BackColor = System.Drawing.Color.Transparent;
            this.settingBtn.FlatAppearance.BorderSize = 0;
            this.settingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingBtn.ForeColor = System.Drawing.Color.Transparent;
            this.settingBtn.Location = new System.Drawing.Point(894, 12);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(63, 65);
            this.settingBtn.TabIndex = 21;
            this.settingBtn.UseVisualStyleBackColor = false;
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // Sum
            // 
            this.BackgroundImage = global::ProjectCP214.Properties.Resources.BG_Sum1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(969, 620);
            this.Controls.Add(this.settingBtn);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.Scorelabel);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.ViewScorebutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Sum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Summary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button ViewScorebutton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label Scorelabel;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.Button settingBtn;
    }
}