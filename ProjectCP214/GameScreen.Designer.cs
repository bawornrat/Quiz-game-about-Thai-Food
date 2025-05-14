namespace ProjectCP214
{
    partial class GameScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.hardMode1 = new ProjectCP214.HardMode();
            this.easyMode1 = new ProjectCP214.EasyMode();
            this.SuspendLayout();
            // 
            // hardMode1
            // 
            this.hardMode1.Location = new System.Drawing.Point(0, -1);
            this.hardMode1.Name = "hardMode1";
            this.hardMode1.Size = new System.Drawing.Size(804, 455);
            this.hardMode1.TabIndex = 0;
            // 
            // easyMode1
            // 
            this.easyMode1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("easyMode1.BackgroundImage")));
            this.easyMode1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.easyMode1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.easyMode1.Location = new System.Drawing.Point(0, -1);
            this.easyMode1.Margin = new System.Windows.Forms.Padding(0);
            this.easyMode1.Name = "easyMode1";
            this.easyMode1.Size = new System.Drawing.Size(804, 455);
            this.easyMode1.TabIndex = 1;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.easyMode1);
            this.Controls.Add(this.hardMode1);
            this.Name = "GameScreen";
            this.Text = "Game Screen";
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private HardMode hardMode1;
        private EasyMode easyMode1;
    }
}