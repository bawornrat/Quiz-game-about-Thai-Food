namespace ProjectCP214
{
    partial class PlayerScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerScore));
            this.ScoreBoard = new System.Windows.Forms.DataGridView();
            this.settingBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreBoard
            // 
            this.ScoreBoard.BackgroundColor = System.Drawing.Color.White;
            this.ScoreBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScoreBoard.Location = new System.Drawing.Point(138, 146);
            this.ScoreBoard.Name = "ScoreBoard";
            this.ScoreBoard.RowHeadersWidth = 51;
            this.ScoreBoard.Size = new System.Drawing.Size(706, 449);
            this.ScoreBoard.TabIndex = 0;
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
            this.settingBtn.TabIndex = 20;
            this.settingBtn.UseVisualStyleBackColor = false;
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // PlayerScore
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(969, 620);
            this.Controls.Add(this.settingBtn);
            this.Controls.Add(this.ScoreBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PlayerScore";
            ((System.ComponentModel.ISupportInitialize)(this.ScoreBoard)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.DataGridView ScoreBoard;
        private System.Windows.Forms.Button settingBtn;
    }
}