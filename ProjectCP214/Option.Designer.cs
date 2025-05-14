namespace ProjectCP214
{
    partial class Option
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
            this.SoundBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.SoundBar)).BeginInit();
            this.SuspendLayout();
            // 
            // SoundBar
            // 
            this.SoundBar.Location = new System.Drawing.Point(39, 26);
            this.SoundBar.Maximum = 100;
            this.SoundBar.Name = "SoundBar";
            this.SoundBar.Size = new System.Drawing.Size(196, 45);
            this.SoundBar.TabIndex = 1;
            this.SoundBar.Scroll += new System.EventHandler(this.SoundBar_Scroll);
            // 
            // Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(56)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(274, 92);
            this.Controls.Add(this.SoundBar);
            this.Name = "Option";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volume Control";
            ((System.ComponentModel.ISupportInitialize)(this.SoundBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar SoundBar;
    }
}