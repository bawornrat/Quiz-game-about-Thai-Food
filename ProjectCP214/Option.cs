using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace ProjectCP214
{
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
            int volume = WelcomeScreen.wplayer.settings.volume;//สร้างตัวแปรมารับค่าระดับเสียงของ Windows Media Player
            SoundBar.Value = volume;//ตั้งให้ SoundBar ตอนเริ่มนั้นมีระดับเท่ากับระดับเสียง (ถ้าไม่ตั้งไว้จะทำให้ SoundBar เริ่มที่ 0 แม้จเปิดมาตั้งค่าแล้วปิดใหม่ก็ตาม)
        }

        private void SoundBar_Scroll(object sender, EventArgs e)
        {
            WelcomeScreen.wplayer.controls.play();
            WelcomeScreen.wplayer.settings.volume = SoundBar.Value;//ตั้งให้เสียงของเพลงดังตามค่าที่ได้รับจาก trackbar 
        }
    }
}
