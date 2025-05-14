using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCP214
{
    public partial class GameScreen : Form
    {
        private string gamemode;
        public GameScreen(string mode)
        {
            InitializeComponent();
            gamemode = mode;
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            if(gamemode.Equals("Normal",StringComparison.OrdinalIgnoreCase))
            {
                hardMode1.Hide();
                easyMode1.Show();
                easyMode1.BringToFront();
            }
            else if (gamemode.Equals("Hard", StringComparison.OrdinalIgnoreCase))
            {
                easyMode1.Hide();
                hardMode1.Show();
                hardMode1.BringToFront();
            }
        }
    }
}
