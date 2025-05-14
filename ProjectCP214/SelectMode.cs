using MySql.Data.MySqlClient;
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
    public partial class SelectMode : Form
    {
        public static SelectMode instace;
        public string ModeSelect;
        private string name = WelcomeScreen.instance.playername;

        private string connetionString = "server=noontanissorn.thanawich.com;database=ThaiFoodApp;uid=CP214Project;pwd=0878200658;";    //string เพื่อเตรียมเชื่อมต่อกับฐานข้อมูล
        private MySqlConnection cnn;        //เตรียมติดต่อฐานข้อมูล

        public SelectMode()
        {
            InitializeComponent();
            queryScore();
            SetTextLabel();
        }

        public HardMode HardMode
        {
            get => default;
            set
            {
            }
        }

        public NormalMode NormalMode
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

        private void SetTextLabel()
        {
            String name = WelcomeScreen.instance.playername;        //กำหนดชื่อผู้เล่น เพื่อนำมาแสดง
            label1.Text += " " + name;
        }
        private void queryScore()
        {
            string queryScore = "select PlayerScore from Players WHERE Playername ='" + name + "' ORDER BY PlayerScore DESC LIMIT 1";    //Query เพื่อดึงชื่อผู้เล่นที่ได้คะแนนสูงสุด
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();                                             //ทำการติดต่อฐานข้อมูล เพื่อดึงข้อมูล
                MySqlCommand cmd = new MySqlCommand(queryScore, cnn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                int NoRes = adapter.Fill(ds);                           
                if(NoRes > 0) {                                 //ตรวจสอบว่า ผู้เล่นที่ชื่อเดียวกัน เคยทำคะแนนสูงสุดไว้เท่าใด
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        PreviousScore.Text = name+", Your high score is " + (Convert.ToString(row[0]));     //ให้แสดงว่า ผู้เล่นชื่อที่เคยเล่นมาแล้ว ได้คะแนนสูงสุดที่เท่าใด
                    }
                }
                else
                {
                    PreviousScore.Text = "You're the first time to play, from the people name "+name; //ถ้าชื่อนี้ ไม่เคยเล่นมาก่อน ก็เป็นการพูดต้อนรับ
                   /* Players record = new Players();
                    record.PlayerName = name;
                    string query = @"INSERT INTO Players (PlayerName) VALUES (@prefix_name)";
                    MySqlParameter sqlParams = new MySqlParameter();
                    sqlParams.Append(new MySqlParameter("@prefix_name", name)); งงจัง*/ 
                }

                cnn.Close();                                //ปิดการเชื่อมต่อ ในรอบงานนี้
            }
            catch (Exception ex)
            {

            }
        }
        private void EasyButton_Click(object sender, EventArgs e)       //ทำการแสดงหน้าโหมด Normal
        {
            NormalMode normal = new NormalMode();
            this.Hide();
            normal.ShowDialog();

        }

        private void HardButton_Click(object sender, EventArgs e)       //ทำการแสดงหน้าโหมด Hard
        {
            HardMode hard = new HardMode();
            this.Hide();
            hard.ShowDialog();

        }

        private void settingBtn_Click(object sender, EventArgs e)       //เมื่อคลิก ให้แสดงหน้าปรับระดับเสียง
        {
            Option option = new Option();
            option.ShowDialog();
        }
    }
}
