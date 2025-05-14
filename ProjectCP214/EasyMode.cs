using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;

namespace ProjectCP214
{
    public partial class EasyMode : UserControl
    {
        public double score = 0;
        public int rightChoice = 0;
        public int choice1_c= 0;
        public int choice2_c= 0;
        public int choice3_c= 0;
        public int choice4_c= 0;
        public int choice5_c= 0;
        int questionNum = 1;
        public int correctAnswer1;
        public int correctAnswer2;
        public int correctAnswer3;

        public EasyMode()
        {
            InitializeComponent();
            SetPlayerName();
            SetScore();
            askQuestion(questionNum);

        }

        public void SetScore()
        {
            Score.Text = $"Score : {score}";
        }

        public void SetPlayerName()
        {
            //WelcomeScreen wsc = new WelcomeScreen();
            string playernamewsc = WelcomeScreen.instance.playername;
            Player_Name.Text += playernamewsc;
        }
        private void Player_Name_Click(object sender, EventArgs e)
        {

        }

        private void Score_Click(object sender, EventArgs e)
        {

        }

        private void Food_Picture_Click(object sender, EventArgs e)
        {

        }

        private void Food_Name_Click(object sender, EventArgs e)
        {

        }

        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    Food_Picture.Image = Properties.Resources.thai_style_pork_omelets_06;
                    Food_Name.Text = "ไข่เจียว";
                    choice1.Text = "ถูก";
                    choice2.Text = "ผิด";
                    choice3.Text = "ถูก";
                    choice4.Text = "ผิด";
                    choice5.Text = "ถูก";

                    



                    break;
                case 2:
                    Food_Picture.Image = Properties.Resources._990020_1;
                    Food_Name.Text = "ไข่ดาว";
                    choice1.Text = "ผิด";
                    choice2.Text = "ถูก";
                    choice3.Text = "ผิด";
                    choice4.Text = "ถูก";
                    choice5.Text = "ถูก";

                    

                    break;
            }
        }

        private void right1_Click(object sender, EventArgs e)
        {
            if(choice1_c == 0)
            {
                if(choice1.Text == "ถูก")
                {
                    rightChoice += 1;
                }
                choice1_c = 1;
                choice1.BackColor = Color.Red;
                
            }
            else if(choice1_c == 1)
            {
                if (choice1.Text == "ถูก")
                {
                    rightChoice -= 1;
                }
                choice1_c = 0;
                choice1.BackColor = Color.White;
            }
        }

        private void right2_Click(object sender, EventArgs e)
        {
            if (choice2_c == 0)
            {
                if (choice2.Text == "ถูก")
                {
                    rightChoice += 1;
                }
                choice2_c = 1;
                choice2.BackColor = Color.Red;
            }
            else if (choice2_c == 1)
            {
                if (choice2.Text == "ถูก")
                {
                    rightChoice -= 1;
                }
                choice2_c = 0;
                choice2.BackColor = Color.White;
            }
        }

        private void right3_Click(object sender, EventArgs e)
        {
            if (choice3_c == 0)
            {
                if (choice3.Text == "ถูก")
                {
                    rightChoice += 1;
                }
                choice3_c = 1;
                choice3.BackColor = Color.Red;
            }
            else if (choice3_c == 1)
            {
                if (choice3.Text == "ถูก")
                {
                    rightChoice -= 1;
                }
                choice3_c = 0;
                choice3.BackColor = Color.White;
            }
        }

        private void wrong1_Click(object sender, EventArgs e)
        {
            if (choice4_c == 0)
            {
                if (choice4.Text == "ถูก")
                {
                    rightChoice += 1;
                }
                choice4_c = 1;
                choice4.BackColor = Color.Red;
            }
            else if (choice4_c == 1)
            {
                if (choice4.Text == "ถูก")
                {
                    rightChoice -= 1;
                }
                choice4_c = 0;
                choice4.BackColor = Color.White;
            }
        }

        private void wrong2_Click(object sender, EventArgs e)
        {
            if (choice5_c == 0)
            {
                if (choice5.Text == "ถูก")
                {
                    rightChoice += 1;
                }
                choice5_c = 1;
                choice5.BackColor = Color.Red;
            }
            else if (choice5_c == 1)
            {
                if (choice5.Text == "ถูก")
                {
                    rightChoice -= 1;
                }
                choice5_c = 0;
                choice5.BackColor = Color.White;
            }
        }

        public void resetButton()
        {
            choice1.BackColor = Color.White;
            choice2.BackColor = Color.White;
            choice3.BackColor = Color.White;
            choice4.BackColor = Color.White;
            choice5.BackColor = Color.White;
            choice1_c = 0;
            choice2_c = 0;
            choice3_c = 0;
            choice4_c = 0;
            choice5_c = 0;
            rightChoice = 0;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            score += rightChoice;
            questionNum += 1;
            askQuestion(questionNum);
            resetButton();  
            SetScore();
        }

        private void EasyMode_Load(object sender, EventArgs e)
        {

        }
    }
}
