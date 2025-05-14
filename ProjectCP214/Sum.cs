using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCP214
{
    public partial class Sum: Form
    {
        private int score;
        private string name;
        private string mode;
        public Sum(string playname, int scoreget, string mode)
        {
            this.score = scoreget;
            this.name = playname;
            this.mode = mode;
            InitializeComponent();
            SetTextLabel();
            UploadScoreToDB();
        }

        public PlayerScore PlayerScore
        {
            get => default;
            set
            {
            }
        }

        public Option Option
        {
            get => default;
            set
            {
            }
        }

        public ThxScreen ThxScreen
        {
            get => default;
            set
            {
            }
        }

        private void SetTextLabel()
        {
            Namelabel.Text = "Player: " + name;
            Scorelabel.Text = score.ToString();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            ThxScreen thx = new ThxScreen();
            thx.ShowDialog();
            
        }

        private void ViewScorebutton_Click(object sender, EventArgs e)
        {
            PlayerScore PlayerScore = new PlayerScore();
            PlayerScore.ShowDialog();
        }

        private void UploadScoreToDB()
        {
            string connetionString = "server=noontanissorn.thanawich.com;database=ThaiFoodApp;uid=CP214Project;pwd=0878200658;";    //string เพื่อเตรียมเชื่อมต่อกับฐานข้อมูล
            MySqlConnection cnn;        //เตรียมติดต่อฐานข้อมูล
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                string query = "INSERT INTO Players(PlayerName, PlayerScore, Playmode, PlayTime) VALUES (@nameDB,@scoreDB,@modeDB, @timeDB)";       //เตรียม Query เพื่อเพิ่มข้อมูลผู้เล่นลงฐานข้อมูล
                MySqlCommand command = new MySqlCommand(query, cnn);                                
                command.Parameters.Add("@nameDB", MySqlDbType.VarChar).Value = this.name;            //ผูกค่าที่จะใส่ เข้ากับ Parameter ใน Query ที่สร้างไว้
                command.Parameters.Add("@scoreDB", MySqlDbType.Int64).Value = this.score;
                command.Parameters.Add("@modeDB", MySqlDbType.VarChar).Value = this.mode;
                command.Parameters.Add("@timeDB", MySqlDbType.DateTime).Value = DateTime.UtcNow;
                command.ExecuteNonQuery();                                                          //สั่งเพิ่มข้อมูลลงไปในฐานข้อมูล

                cnn.Close();            //ปิดการเชื่อมต่อ เมื่อเพิ่มข้อมูลสำเร็จ
            } catch (Exception ex)
            {
                MessageBox.Show("ไม่สามารถเพิ่มข้อมูลได้ เพราะ\n"+ex.ToString(),"เกิดข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error );      //แสดง Pop-up หากไม่สามารถเพิ่มข้อมูลได้
            }
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            WelcomeScreen welcome = new WelcomeScreen();
            this.Hide();
            welcome.ShowDialog();   
            

        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            Option option = new Option();
            option.ShowDialog();
        }
    }
}
