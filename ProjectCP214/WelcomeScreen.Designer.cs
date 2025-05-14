namespace ProjectCP214
{
    partial class WelcomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeScreen));
            this.PlayerNameTextField = new System.Windows.Forms.TextBox();
            this.Thx_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.settingBtn = new System.Windows.Forms.Button();
            this.Music = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.Music)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerNameTextField
            // 
            this.PlayerNameTextField.BackColor = System.Drawing.Color.White;
            this.PlayerNameTextField.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNameTextField.Location = new System.Drawing.Point(570, 351);
            this.PlayerNameTextField.Multiline = true;
            this.PlayerNameTextField.Name = "PlayerNameTextField";
            this.PlayerNameTextField.Size = new System.Drawing.Size(154, 29);
            this.PlayerNameTextField.TabIndex = 14;
            // 
            // Thx_button
            // 
            this.Thx_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(28)))), ((int)(((byte)(22)))));
            this.Thx_button.FlatAppearance.BorderSize = 0;
            this.Thx_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Thx_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Thx_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Thx_button.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thx_button.ForeColor = System.Drawing.Color.White;
            this.Thx_button.Location = new System.Drawing.Point(843, 557);
            this.Thx_button.Name = "Thx_button";
            this.Thx_button.Size = new System.Drawing.Size(90, 29);
            this.Thx_button.TabIndex = 16;
            this.Thx_button.Text = "Thank You";
            this.Thx_button.UseVisualStyleBackColor = false;
            this.Thx_button.Click += new System.EventHandler(this.Thx_button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(28)))), ((int)(((byte)(22)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(547, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 67);
            this.button1.TabIndex = 12;
            this.button1.Text = "Start Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // settingBtn
            // 
            this.settingBtn.BackColor = System.Drawing.Color.Transparent;
            this.settingBtn.FlatAppearance.BorderSize = 0;
            this.settingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingBtn.ForeColor = System.Drawing.Color.Transparent;
            this.settingBtn.Image = global::ProjectCP214.Properties.Resources.Cog;
            this.settingBtn.Location = new System.Drawing.Point(870, 35);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(63, 65);
            this.settingBtn.TabIndex = 18;
            this.settingBtn.UseVisualStyleBackColor = false;
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // Music
            // 
            this.Music.Enabled = true;
            this.Music.Location = new System.Drawing.Point(451, 63);
            this.Music.Name = "Music";
            this.Music.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Music.OcxState")));
            this.Music.Size = new System.Drawing.Size(227, 46);
            this.Music.TabIndex = 19;
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectCP214.Properties.Resources.BG_WelcomeScreen1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(969, 620);
            this.Controls.Add(this.Music);
            this.Controls.Add(this.settingBtn);
            this.Controls.Add(this.Thx_button);
            this.Controls.Add(this.PlayerNameTextField);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "WelcomeScreen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หิว A เกม";
            ((System.ComponentModel.ISupportInitialize)(this.Music)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PlayerNameTextField;
        private System.Windows.Forms.Button Thx_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button settingBtn;
        private AxWMPLib.AxWindowsMediaPlayer Music;
    }
}

