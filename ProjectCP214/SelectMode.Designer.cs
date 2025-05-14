namespace ProjectCP214
{
    partial class SelectMode
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
            this.NormalButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HardButton = new System.Windows.Forms.Button();
            this.PreviousScore = new System.Windows.Forms.Label();
            this.settingBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NormalButton
            // 
            this.NormalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NormalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NormalButton.FlatAppearance.BorderSize = 0;
            this.NormalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NormalButton.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NormalButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NormalButton.Location = new System.Drawing.Point(231, 333);
            this.NormalButton.Name = "NormalButton";
            this.NormalButton.Size = new System.Drawing.Size(209, 75);
            this.NormalButton.TabIndex = 0;
            this.NormalButton.Text = "Normal";
            this.NormalButton.UseVisualStyleBackColor = false;
            this.NormalButton.Click += new System.EventHandler(this.EasyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(216, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 90);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(264, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(484, 67);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please Select Mode";
            // 
            // HardButton
            // 
            this.HardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.HardButton.FlatAppearance.BorderSize = 0;
            this.HardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HardButton.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HardButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HardButton.Location = new System.Drawing.Point(231, 462);
            this.HardButton.Name = "HardButton";
            this.HardButton.Size = new System.Drawing.Size(209, 75);
            this.HardButton.TabIndex = 3;
            this.HardButton.Text = "Hard";
            this.HardButton.UseVisualStyleBackColor = false;
            this.HardButton.Click += new System.EventHandler(this.HardButton_Click);
            // 
            // PreviousScore
            // 
            this.PreviousScore.AutoSize = true;
            this.PreviousScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousScore.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousScore.Location = new System.Drawing.Point(15, 578);
            this.PreviousScore.Name = "PreviousScore";
            this.PreviousScore.Size = new System.Drawing.Size(67, 27);
            this.PreviousScore.TabIndex = 4;
            this.PreviousScore.Text = "label3";
            // 
            // settingBtn
            // 
            this.settingBtn.BackColor = System.Drawing.Color.Transparent;
            this.settingBtn.FlatAppearance.BorderSize = 0;
            this.settingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingBtn.ForeColor = System.Drawing.Color.Transparent;
            this.settingBtn.Image = global::ProjectCP214.Properties.Resources.Cog;
            this.settingBtn.Location = new System.Drawing.Point(894, 12);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(63, 65);
            this.settingBtn.TabIndex = 19;
            this.settingBtn.UseVisualStyleBackColor = false;
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // SelectMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectCP214.Properties.Resources.BG_SelectMode;
            this.ClientSize = new System.Drawing.Size(969, 620);
            this.Controls.Add(this.settingBtn);
            this.Controls.Add(this.PreviousScore);
            this.Controls.Add(this.HardButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NormalButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SelectMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Mode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NormalButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button HardButton;
        private System.Windows.Forms.Label PreviousScore;
        private System.Windows.Forms.Button settingBtn;
    }
}