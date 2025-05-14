namespace ProjectCP214
{
    partial class NormalMode
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Player_Name = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.Food_Name = new System.Windows.Forms.Label();
            this.Food_Picture = new System.Windows.Forms.PictureBox();
            this.choice1 = new System.Windows.Forms.Button();
            this.choice2 = new System.Windows.Forms.Button();
            this.choice3 = new System.Windows.Forms.Button();
            this.choice4 = new System.Windows.Forms.Button();
            this.choice5 = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.settingBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Food_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Player_Name
            // 
            this.Player_Name.AutoSize = true;
            this.Player_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Player_Name.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold);
            this.Player_Name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Player_Name.Location = new System.Drawing.Point(34, 28);
            this.Player_Name.Name = "Player_Name";
            this.Player_Name.Size = new System.Drawing.Size(132, 38);
            this.Player_Name.TabIndex = 0;
            this.Player_Name.Text = "Player : ";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Score.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.Score.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Score.Location = new System.Drawing.Point(36, 90);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(112, 35);
            this.Score.TabIndex = 1;
            this.Score.Text = "Score : ";
            // 
            // Food_Name
            // 
            this.Food_Name.AutoSize = true;
            this.Food_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Food_Name.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold);
            this.Food_Name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Food_Name.Location = new System.Drawing.Point(118, 479);
            this.Food_Name.Name = "Food_Name";
            this.Food_Name.Size = new System.Drawing.Size(178, 51);
            this.Food_Name.TabIndex = 2;
            this.Food_Name.Text = "ชื่ออาหาร";
            this.Food_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Food_Picture
            // 
            this.Food_Picture.BackgroundImage = global::ProjectCP214.Properties.Resources.BG_WelcomeScreen;
            this.Food_Picture.Location = new System.Drawing.Point(81, 147);
            this.Food_Picture.Name = "Food_Picture";
            this.Food_Picture.Size = new System.Drawing.Size(407, 329);
            this.Food_Picture.TabIndex = 3;
            this.Food_Picture.TabStop = false;
            // 
            // choice1
            // 
            this.choice1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(157)))), ((int)(((byte)(39)))));
            this.choice1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.choice1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(48)))), ((int)(((byte)(21)))));
            this.choice1.Location = new System.Drawing.Point(595, 216);
            this.choice1.Name = "choice1";
            this.choice1.Size = new System.Drawing.Size(151, 64);
            this.choice1.TabIndex = 4;
            this.choice1.Tag = "1";
            this.choice1.Text = "1";
            this.choice1.UseVisualStyleBackColor = false;
            this.choice1.Click += new System.EventHandler(this.choice1_Click);
            // 
            // choice2
            // 
            this.choice2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(157)))), ((int)(((byte)(39)))));
            this.choice2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.choice2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.choice2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(48)))), ((int)(((byte)(21)))));
            this.choice2.Location = new System.Drawing.Point(799, 216);
            this.choice2.Name = "choice2";
            this.choice2.Size = new System.Drawing.Size(151, 64);
            this.choice2.TabIndex = 5;
            this.choice2.Tag = "2";
            this.choice2.Text = "2";
            this.choice2.UseVisualStyleBackColor = false;
            this.choice2.Click += new System.EventHandler(this.choice2_Click);
            // 
            // choice3
            // 
            this.choice3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(157)))), ((int)(((byte)(39)))));
            this.choice3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.choice3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.choice3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(48)))), ((int)(((byte)(21)))));
            this.choice3.Location = new System.Drawing.Point(595, 315);
            this.choice3.Name = "choice3";
            this.choice3.Size = new System.Drawing.Size(151, 64);
            this.choice3.TabIndex = 6;
            this.choice3.Tag = "3";
            this.choice3.Text = "3";
            this.choice3.UseVisualStyleBackColor = false;
            this.choice3.Click += new System.EventHandler(this.choice3_Click);
            // 
            // choice4
            // 
            this.choice4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(157)))), ((int)(((byte)(39)))));
            this.choice4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.choice4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.choice4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(48)))), ((int)(((byte)(21)))));
            this.choice4.Location = new System.Drawing.Point(799, 315);
            this.choice4.Name = "choice4";
            this.choice4.Size = new System.Drawing.Size(151, 64);
            this.choice4.TabIndex = 7;
            this.choice4.Tag = "4";
            this.choice4.Text = "4";
            this.choice4.UseVisualStyleBackColor = false;
            this.choice4.Click += new System.EventHandler(this.choice4_Click);
            // 
            // choice5
            // 
            this.choice5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(157)))), ((int)(((byte)(39)))));
            this.choice5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.choice5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.choice5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(48)))), ((int)(((byte)(21)))));
            this.choice5.Location = new System.Drawing.Point(699, 411);
            this.choice5.Name = "choice5";
            this.choice5.Size = new System.Drawing.Size(151, 64);
            this.choice5.TabIndex = 8;
            this.choice5.Tag = "5";
            this.choice5.Text = "5";
            this.choice5.UseVisualStyleBackColor = false;
            this.choice5.Click += new System.EventHandler(this.choice5_Click);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.SandyBrown;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Next.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.Next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(48)))), ((int)(((byte)(21)))));
            this.Next.Location = new System.Drawing.Point(849, 592);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(111, 46);
            this.Next.TabIndex = 9;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // settingBtn
            // 
            this.settingBtn.BackColor = System.Drawing.Color.Transparent;
            this.settingBtn.FlatAppearance.BorderSize = 0;
            this.settingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingBtn.ForeColor = System.Drawing.Color.Transparent;
            this.settingBtn.Image = global::ProjectCP214.Properties.Resources.Cog;
            this.settingBtn.Location = new System.Drawing.Point(899, 12);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(63, 65);
            this.settingBtn.TabIndex = 19;
            this.settingBtn.UseVisualStyleBackColor = false;
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // NormalMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.BackgroundImage = global::ProjectCP214.Properties.Resources.BG_Easy_Mode;
            this.ClientSize = new System.Drawing.Size(974, 656);
            this.Controls.Add(this.settingBtn);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.choice5);
            this.Controls.Add(this.choice4);
            this.Controls.Add(this.choice3);
            this.Controls.Add(this.choice2);
            this.Controls.Add(this.choice1);
            this.Controls.Add(this.Food_Picture);
            this.Controls.Add(this.Food_Name);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Player_Name);
            this.Name = "NormalMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Normal Mode";
            ((System.ComponentModel.ISupportInitialize)(this.Food_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Player_Name;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label Food_Name;
        private System.Windows.Forms.PictureBox Food_Picture;
        private System.Windows.Forms.Button choice1;
        private System.Windows.Forms.Button choice2;
        private System.Windows.Forms.Button choice3;
        private System.Windows.Forms.Button choice4;
        private System.Windows.Forms.Button choice5;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button settingBtn;
    }
}
