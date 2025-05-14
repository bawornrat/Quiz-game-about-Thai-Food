using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjectCP214
{
    public partial class PlayerScore: Form
    {
        private string connetionString = "server=noontanissorn.thanawich.com;database=ThaiFoodApp;uid=CP214Project;pwd=0878200658;";    //string เพื่อเตรียมเชื่อมต่อกับฐานข้อมูล
        private MySqlConnection cnn;
        public PlayerScore()
        {
            InitializeComponent();
            ShowScore();
            LoadTable();
        }

        public void ShowScore()
        {
            string queryScore = "select PlayerScore from Players ORDER BY PlayerScore DESC";                  //Query เพื่อดึงข้อมูลวัตถุดิบทั้งหมด
            cnn = new MySqlConnection(connetionString);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void LoadTable()
        {
            string connetionString = "server=noontanissorn.thanawich.com;database=ThaiFoodApp;uid=CP214Project;pwd=0878200658;";    //string เพื่อเตรียมเชื่อมต่อกับฐานข้อมูล
            MySqlConnection cnn = new MySqlConnection(connetionString);       //เตรียมติดต่อฐานข้อมูล
            try
            {
                cnn.Open();                                         //เปิดการเชื่อมต่อ
                string query = "SELECT Playername AS 'ชื่อผู้เล่น', PlayMode AS 'โหมดที่เล่น', PlayerScore AS 'คะแนนที่ได้', CONVERT_TZ(PlayTime,'+00:00','+07:00') AS 'เวลาที่เล่น' FROM Players ORDER BY PlayTime DESC";             //เตรียม QUery ที่จะใช้
                MySqlCommand cmd = new MySqlCommand(query, cnn);    //Query คำสั่งขึ้นฐานข้อมูล
                MySqlDataReader reader = cmd.ExecuteReader();       //สร้าง Reader เพื่อรับข้อมูลที่ Query มาได้
                DataTable dt = new DataTable();                     //สร้าง Object DataTable เพื่อรอเอาข้อมูลที่ Query มาได้ ทำเป็นตาราง
                dt.Load(reader);                                    //นำข้อมูลที่ Query มาได้ ใส่ในตาราง dt
                ScoreBoard.DataSource = dt;                      //นำข้อมูลในตาราง มาใส่ใน DataGridView

                cnn.Close();                                        //ปิดการเชื่อมต่อ
            } catch (Exception ex){
                MessageBox.Show("เกิดข้อผิดพลาด"+ex.Message, "ไม่นะ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            Option option = new Option();
            option.ShowDialog();
        }
    }
}
