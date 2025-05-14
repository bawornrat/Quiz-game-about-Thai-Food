namespace ProjectCP214
{
    partial class EasyMode
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
            this.choice1 = new System.Windows.Forms.Button();
            this.choice2 = new System.Windows.Forms.Button();
            this.choice3 = new System.Windows.Forms.Button();
            this.choice5 = new System.Windows.Forms.Button();
            this.choice4 = new System.Windows.Forms.Button();
            this.Food_Picture = new System.Windows.Forms.PictureBox();
            this.Food_Name = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.Score = new System.Windows.Forms.Label();
            this.Player_Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Food_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // choice1
            // 
            this.choice1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(157)))), ((int)(((byte)(39)))));
            this.choice1.FlatAppearance.BorderSize = 0;
            this.choice1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choice1.Location = new System.Drawing.Point(1244, 402);
            this.choice1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.choice1.Name = "choice1";
            this.choice1.Size = new System.Drawing.Size(256, 106);
            this.choice1.TabIndex = 0;
            this.choice1.Tag = "1";
            this.choice1.Text = "ถูก1";
            this.choice1.UseVisualStyleBackColor = false;
            this.choice1.Click += new System.EventHandler(this.right1_Click);
            // 
            // choice2
            // 
            this.choice2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(157)))), ((int)(((byte)(39)))));
            this.choice2.FlatAppearance.BorderSize = 0;
            this.choice2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choice2.Location = new System.Drawing.Point(1606, 402);
            this.choice2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.choice2.Name = "choice2";
            this.choice2.Size = new System.Drawing.Size(256, 106);
            this.choice2.TabIndex = 1;
            this.choice2.Tag = "2";
            this.choice2.Text = "ถูก2";
            this.choice2.UseVisualStyleBackColor = false;
            this.choice2.Click += new System.EventHandler(this.right2_Click);
            // 
            // choice3
            // 
            this.choice3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(157)))), ((int)(((byte)(39)))));
            this.choice3.FlatAppearance.BorderSize = 0;
            this.choice3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choice3.Location = new System.Drawing.Point(1244, 581);
            this.choice3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.choice3.Name = "choice3";
            this.choice3.Size = new System.Drawing.Size(256, 106);
            this.choice3.TabIndex = 2;
            this.choice3.Tag = "3";
            this.choice3.Text = "ถูก3";
            this.choice3.UseVisualStyleBackColor = false;
            this.choice3.Click += new System.EventHandler(this.right3_Click);
            // 
            // choice5
            // 
            this.choice5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(157)))), ((int)(((byte)(39)))));
            this.choice5.FlatAppearance.BorderSize = 0;
            this.choice5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choice5.Location = new System.Drawing.Point(1244, 754);
            this.choice5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.choice5.Name = "choice5";
            this.choice5.Size = new System.Drawing.Size(256, 106);
            this.choice5.TabIndex = 3;
            this.choice5.Tag = "5";
            this.choice5.Text = "ผิด2";
            this.choice5.UseVisualStyleBackColor = false;
            this.choice5.Click += new System.EventHandler(this.wrong2_Click);
            // 
            // choice4
            // 
            this.choice4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(157)))), ((int)(((byte)(39)))));
            this.choice4.FlatAppearance.BorderSize = 0;
            this.choice4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choice4.Location = new System.Drawing.Point(1606, 581);
            this.choice4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.choice4.Name = "choice4";
            this.choice4.Size = new System.Drawing.Size(256, 106);
            this.choice4.TabIndex = 4;
            this.choice4.Tag = "4";
            this.choice4.Text = "ผิด1";
            this.choice4.UseVisualStyleBackColor = false;
            this.choice4.Click += new System.EventHandler(this.wrong1_Click);
            // 
            // Food_Picture
            // 
            this.Food_Picture.Image = global::ProjectCP214.Properties.Resources.thai_style_pork_omelets_06;
            this.Food_Picture.Location = new System.Drawing.Point(172, 319);
            this.Food_Picture.Margin = new System.Windows.Forms.Padding(0);
            this.Food_Picture.Name = "Food_Picture";
            this.Food_Picture.Size = new System.Drawing.Size(680, 523);
            this.Food_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Food_Picture.TabIndex = 5;
            this.Food_Picture.TabStop = false;
            this.Food_Picture.Click += new System.EventHandler(this.Food_Picture_Click);
            // 
            // Food_Name
            // 
            this.Food_Name.AutoSize = true;
            this.Food_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Food_Name.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Food_Name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Food_Name.Location = new System.Drawing.Point(326, 879);
            this.Food_Name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Food_Name.Name = "Food_Name";
            this.Food_Name.Size = new System.Drawing.Size(438, 103);
            this.Food_Name.TabIndex = 6;
            this.Food_Name.Text = "ข้าวผัดใส่ไข่";
            this.Food_Name.Click += new System.EventHandler(this.Food_Name_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(1678, 1100);
            this.Next.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(184, 85);
            this.Next.TabIndex = 7;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Score.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Score.Location = new System.Drawing.Point(72, 169);
            this.Score.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(225, 67);
            this.Score.TabIndex = 8;
            this.Score.Text = "Score : ";
            this.Score.Click += new System.EventHandler(this.Score_Click);
            // 
            // Player_Name
            // 
            this.Player_Name.AutoSize = true;
            this.Player_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Player_Name.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_Name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Player_Name.Location = new System.Drawing.Point(70, 77);
            this.Player_Name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Player_Name.Name = "Player_Name";
            this.Player_Name.Size = new System.Drawing.Size(261, 74);
            this.Player_Name.TabIndex = 9;
            this.Player_Name.Text = "Player : ";
            this.Player_Name.Click += new System.EventHandler(this.Player_Name_Click);
            // 
            // EasyMode
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::ProjectCP214.Properties.Resources.BG_Easy_Mode;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Player_Name);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Food_Name);
            this.Controls.Add(this.Food_Picture);
            this.Controls.Add(this.choice4);
            this.Controls.Add(this.choice5);
            this.Controls.Add(this.choice3);
            this.Controls.Add(this.choice2);
            this.Controls.Add(this.choice1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EasyMode";
            this.Size = new System.Drawing.Size(985, 659);
            this.Load += new System.EventHandler(this.EasyMode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Food_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button choice1;
        private System.Windows.Forms.Button choice2;
        private System.Windows.Forms.Button choice3;
        private System.Windows.Forms.Button choice5;
        private System.Windows.Forms.Button choice4;
        private System.Windows.Forms.PictureBox Food_Picture;
        private System.Windows.Forms.Label Food_Name;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label Player_Name;
    }
}
