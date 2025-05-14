using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Media;
using WMPLib;
using AxWMPLib;
using Google.Protobuf.WellKnownTypes;

namespace ProjectCP214
{
    public partial class WelcomeScreen : Form
    {


        public static WelcomeScreen instance;
        public String playername;

        public static WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer(); 

        public WelcomeScreen()
        {
            InitializeComponent();
            instance = this;
            wplayer.URL = (@"http://noontanissorn.thanawich.com/projectCP214/Music/HomeScreenMusic.wav"); //ระบุ path ของไฟล์เพลงที่จะเปิด
            wplayer.controls.play();//ให้เล่นเพลง
            Music.Hide();//ซ่อนหน้าต่าง Windows Media Player

        }

        public SelectMode SelectMode
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            string connetionString = null;      //เตรียม Connection String เพื่อเชื่อมต่อกับฐานข้อมูล
            MySqlConnection cnn;                //เตรียม Connection เชื่อมต่อกับฐานข้อมูล
            connetionString = "server=noontanissorn.thanawich.com;database=ThaiFoodApp;uid=CP214Project;pwd=0878200658;";   //สร้าง Connection String เชื่อมต่อกับฐานข้อมูล
            cnn = new MySqlConnection(connetionString);         //สร้าง Connection เชื่อมต่อกับฐานข้อมูล
                
            if (string.IsNullOrEmpty(PlayerNameTextField.Text))     //เข้าเงื่อนไข ถ้าไม่ได้กรอกชื่อ ให้ Pop-up ข้อความ ให้กรอกใหม่
            {
                MessageBox.Show("Please enter your name", "เดี๋ยวก่อน", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);    //Pop-up ข้อความ ให้กรอกใหม่
            }
            else
            {
                try                     //ทดลองสร้างกับการเชื่อมต่อกับฐานข้อมูล
                {
                    cnn.Open();          //เปิดการเชื่อมต่อกับฐานข้อมูล   
                    MessageBox.Show("สามารถเชื่อมต่อได้");
                    if (PlayerNameTextField.Text != null)
                    {
                        playername = PlayerNameTextField.Text;      //นำชื่อผู้เล่นที่กรอก มาเป็นชื่อผู้เล่นของเกม

                    }
                    cnn.Close();    //ปิดการเชื่อมต่อกับฐานข้อมูล


                    this.Hide();
                    SelectMode sm = new SelectMode();       //ให้แสดงหน้าเลือกโหมด เป็นขั้นตอนถัดไป
                    sm.ShowDialog();
                    this.Close();       //ปิดหน้าแรกไป


                }
                catch (Exception ex)
                {
                    MessageBox.Show("ต่อไม่ได้ ลองอ่านดู " + ex.ToString(), "ไม่นะ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Thx_button_Click(object sender, EventArgs e)       //เมื่อคลิก ให้แสดงหน้าข้อมความขอบคุณ
        {
            ThxScreen thxScreen = new ThxScreen();
            thxScreen.Show();           
        }

        

        private void settingBtn_Click(object sender, EventArgs e)       //เมื่อคลิก ให้แสดงหน้าปรับระดับเสียง
        {
            Option option = new Option();  
            option.ShowDialog();
        }
    }
}
