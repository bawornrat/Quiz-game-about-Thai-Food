using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCP214
{
    public partial class HardMode : Form
    {
        public int score = 0;
        public string player = WelcomeScreen.instance.playername;
        Color Orange1 = Color.FromArgb(249, 157, 39);
        private int correctChoice = 0;
        private int choice1_c = 0;
        private int choice2_c = 0;
        private int choice3_c = 0;
        private int choice4_c = 0;
        private int choice5_c = 0;
        private int questionNum = 1;
        private int[] correctAnswer = { 0, 0, 0 };
        private List<string> foodList = new List<string>();         //สร้าง List เพื่อเก็บชื่ออาหารทั้งหมดทีมีในฐานข้อมูล
        private List<string> foodListRandom = new List<string>();   //สร้าง List เพื่อเก็บชื่ออาหารที่จะเอามาใช้ในเกมแต่ละตา
        private List<string> AllIngredient = new List<string>();    //สร้าง List เพื่อเก็บชื่อวัตถุดิบทั้งหมด
        private int foodRegion = 0;// 1 = ภาคกลาง, 2 = ภาคเหนือ, 3 = ภาคใต้, 4 = ภาคอีสาน, 5 = เป็นของกินปกติของทุกภาค

        private Random random = new Random();                       //สร้าง Instance จาก Class Random เพื่อใช้สุมของต่าง ๆ

        string connetionString = "server=noontanissorn.thanawich.com;database=ThaiFoodApp;uid=CP214Project;pwd=0878200658;";
        MySqlConnection cnn;        //เตรียมติดต่อฐานข้อมูล

        public HardMode()
        {
            InitializeComponent();
            GetFoodName();
            SetPlayerName();
            SetScore();
            askQuestion(questionNum);
        }

        public Sum Sum
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

        public void GetFoodName()
        {

            string query = "select Food_name from Foods where food_origin <> 'none'";       //Query เพื่อดึงข้อมูลชื่ออาหาร
            string queryIngredient = "select ingredient from Ingredients";                  //Query เพื่อดึงข้อมูลวัตถุดิบทั้งหมด
            cnn = new MySqlConnection(connetionString);                                     //Query เพื่อดึงข้อมูลวัตถุดิบทั้งหมด
            try
            {
                cnn.Open();                                                                 //ทำการติดต่อฐานข้อมูล เพื่อดึงข้อมูล
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                foreach (DataRow row in ds.Tables[0].Rows)                                  //นำชื่ออาหารที่ดึงได้ เก็บไว้ใน List foodList
                {
                    foodList.Add(Convert.ToString(row[0]));
                }

                while (foodListRandom.Count != 5)                         //สุ่มอาหารมา 5 อย่าง จากรายการอาหารทั้งหมด เพื่อนำมาใช้ในเกม
                {
                    string rndfood = foodList[random.Next(0, foodList.Count)];  //เลือกมาทีละเมนู
                    if (!foodListRandom.Contains(rndfood))                      //ถ้าเมนูนั้น มีแล้ว ให้สุ่มใหม่
                    {
                        foodListRandom.Add(rndfood);                            //ถ้าเมนูนั้นยังไม่มี ให้เพิ่มลง List อาหารที่จะเอามาใช้ในเกม
                    }
                }


                MySqlCommand cmd2 = new MySqlCommand(queryIngredient, cnn);     //Query เพื่อดึงข้อมูลวัตถุดิบทั้งหมดมา
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd2);
                DataSet ds2 = new DataSet();
                adapter2.Fill(ds2);
                foreach (DataRow row in ds2.Tables[0].Rows)               //นำวัตถุดิบทั้งหมดที่ Query มาเก็บไว้ใน List ชื่อ  AllIngredient
                {
                    AllIngredient.Add(Convert.ToString(row[0]));
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
            }
        }

        public void SetScore()
        {
            Score.Text = $"Score : {score}";
        }

        public void SetPlayerName()
        {
            Player_Name.Text += player;
        }

        private void askQuestion(int qnum)
        {
            string Fooditem, foodregion = "";        //String เก็บข้อความชื่ออาหาร และภมิภาคอาหาร
            List<string> foodIngre;             //List เก็บวัตถุดิบอาหาร แต่ละข้อ ก็เป็นคนละ List
            switch (qnum)
            {
                case 1:
                    Fooditem = foodListRandom[0];                   //เอาชื่ออาหารจากตัวแรกใน List มา เป็นโจทย์ข้อแรก
                    cnn = new MySqlConnection(connetionString);
                    try
                    {
                        string queryIngre = "select ingredient from Foods f JOIN Foods_IngredientsUse fi ON f.Food_id = fi.food_id join Ingredients i on fi.Ingredient_id = i.Ingredient_id where Food_name ='" + Fooditem + "'"; //Query วัตถุดิบของอาหารนั้น ๆ
                        string queryRegion = "select food_origin from Foods where Food_name ='" + Fooditem + "'";       //Query ภาคอาหารที่ได้

                        cnn.Open();                                             //ทำการติดต่อฐานข้อมูล เพื่อดึงข้อมูล
                        MySqlCommand cmd = new MySqlCommand(queryIngre, cnn);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        foodIngre = new List<string>();
                        foreach (DataRow row in ds.Tables[0].Rows)               //นำชื่อวัตถุดิบที่ถูกต้องที่ดึงได้ เก็บไว้ใน List foodIngre
                        {
                            foodIngre.Add(Convert.ToString(row[0]));
                        }

                        MySqlCommand cmd2 = new MySqlCommand(queryRegion, cnn);     //Query เพื่อดึงข้อมูลวัตถุดิบทั้งหมดมา
                        MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd2);
                        DataSet ds2 = new DataSet();
                        adapter2.Fill(ds2);
                        foreach (DataRow row in ds2.Tables[0].Rows)               //นำวัตถุดิบทั้งหมดที่ Query มาเก็บไว้ใน List ชื่อ  AllIngredient
                        {
                            foodregion = Convert.ToString(row[0]);
                        }
                        cnn.Close();

                        List<String> IngerdientWrong = AllIngredient.Except(foodIngre).ToList();    //นำวัตถุดิบทั้งหมด มาเก็บไว้ใน List IngerdientWrong

                        Food_Picture.Image = (Image)Properties.Resources.ResourceManager.GetObject($"{Fooditem}");
                        Food_Name.Text = Fooditem;      //กำหนดข้อความลักษณะอาหารต่าง ๆ ให้แต่ละ Properties
                        choice1.Text = foodIngre[0];
                        choice2.Text = IngerdientWrong[random.Next(IngerdientWrong.Count)];
                        choice3.Text = foodIngre[1];
                        choice4.Text = IngerdientWrong[random.Next(IngerdientWrong.Count)];
                        choice5.Text = foodIngre[2];
                        correctAnswer[0] = 1;
                        correctAnswer[1] = 3;
                        correctAnswer[2] = 5;
                        switch (foodregion)                 //1 = ภาคกลาง, 2 = ภาคเหนือ, 3 = ภาคใต้, 4 = ภาคอีสาน
                        {
                            case "ภาคกลาง": foodRegion = 1; 
                                break;
                            case "ภาคเหนือ": foodRegion = 2;
                                break;
                            case "ภาคใต้": foodRegion = 3;
                                break;
                            case "ภาคตะวันออกเฉียงเหนือ": foodRegion = 4;
                                break;
                            default: foodRegion = 5;
                                break;
                        }
                    }
                    
                    catch (Exception ex)
                    {

                    }



                    break;
                case 2:
                    Fooditem = foodListRandom[1];                   //เอาชื่ออาหารจากตัวที่สองใน List มา เป็นโจทย์ข้อที่ 2
                    cnn = new MySqlConnection(connetionString);
                    cnn = new MySqlConnection(connetionString);
                    try
                    {
                        string queryIngre = "select ingredient from Foods f JOIN Foods_IngredientsUse fi ON f.Food_id = fi.food_id join Ingredients i on fi.Ingredient_id = i.Ingredient_id where Food_name ='" + Fooditem + "'"; //Query วัตถุดิบของอาหารนั้น ๆ
                        string queryRegion = "select food_origin from Foods where Food_name ='" + Fooditem + "'";       //Query ภาคอาหารที่ได้

                        cnn.Open();                                             //ทำการติดต่อฐานข้อมูล เพื่อดึงข้อมูล
                        MySqlCommand cmd = new MySqlCommand(queryIngre, cnn);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        foodIngre = new List<string>();
                        foreach (DataRow row in ds.Tables[0].Rows)               //นำชื่อวัตถุดิบที่ถูกต้องที่ดึงได้ เก็บไว้ใน List foodIngre
                        {
                            foodIngre.Add(Convert.ToString(row[0]));
                        }

                        MySqlCommand cmd2 = new MySqlCommand(queryRegion, cnn);     //Query เพื่อดึงข้อมูลวัตถุดิบทั้งหมดมา
                        MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd2);
                        DataSet ds2 = new DataSet();
                        adapter2.Fill(ds2);
                        foreach (DataRow row in ds2.Tables[0].Rows)               //นำวัตถุดิบทั้งหมดที่ Query มาเก็บไว้ใน List ชื่อ  AllIngredient
                        {
                            foodregion = Convert.ToString(row[0]);
                        }
                        cnn.Close();

                        List<String> IngerdientWrong = AllIngredient.Except(foodIngre).ToList();    //นำวัตถุดิบทั้งหมด มาเก็บไว้ใน List IngerdientWrong

                        Food_Picture.Image = (Image)Properties.Resources.ResourceManager.GetObject($"{Fooditem}");
                        Food_Name.Text = Fooditem;      //กำหนดข้อความลักษณะอาหารต่าง ๆ ให้แต่ละ Properties
                        choice2.Text = foodIngre[0];
                        choice1.Text = IngerdientWrong[random.Next(IngerdientWrong.Count)];
                        choice3.Text = foodIngre[1];
                        choice5.Text = IngerdientWrong[random.Next(IngerdientWrong.Count)];
                        choice4.Text = foodIngre[2];
                        correctAnswer[0] = 2;
                        correctAnswer[1] = 3;
                        correctAnswer[2] = 4;
                        switch (foodregion)                 //1 = ภาคกลาง, 2 = ภาคเหนือ, 3 = ภาคใต้, 4 = ภาคอีสาน
                        {
                            case "ภาคกลาง":
                                foodRegion = 1;
                                break;
                            case "ภาคเหนือ":
                                foodRegion = 2;
                                break;
                            case "ภาคใต้":
                                foodRegion = 3;
                                break;
                            case "ภาคตะวันออกเฉียงเหนือ":
                                foodRegion = 4;
                                break;
                            default:
                                foodRegion = 5;
                                break;
                        }
                    }

                    catch (Exception ex)
                    {

                    }
                    break;
                case 3:
                    Fooditem = foodListRandom[2];                   //เอาชื่ออาหารจากตัวที่สองใน List มา เป็นโจทย์ข้อที่ 2
                    cnn = new MySqlConnection(connetionString);
                    cnn = new MySqlConnection(connetionString);
                    try
                    {
                        string queryIngre = "select ingredient from Foods f JOIN Foods_IngredientsUse fi ON f.Food_id = fi.food_id join Ingredients i on fi.Ingredient_id = i.Ingredient_id where Food_name ='" + Fooditem + "'"; //Query วัตถุดิบของอาหารนั้น ๆ
                        string queryRegion = "select food_origin from Foods where Food_name ='" + Fooditem + "'";       //Query ภาคอาหารที่ได้

                        cnn.Open();                                             //ทำการติดต่อฐานข้อมูล เพื่อดึงข้อมูล
                        MySqlCommand cmd = new MySqlCommand(queryIngre, cnn);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        foodIngre = new List<string>();
                        foreach (DataRow row in ds.Tables[0].Rows)               //นำชื่อวัตถุดิบที่ถูกต้องที่ดึงได้ เก็บไว้ใน List foodIngre
                        {
                            foodIngre.Add(Convert.ToString(row[0]));
                        }

                        MySqlCommand cmd2 = new MySqlCommand(queryRegion, cnn);     //Query เพื่อดึงข้อมูลวัตถุดิบทั้งหมดมา
                        MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd2);
                        DataSet ds2 = new DataSet();
                        adapter2.Fill(ds2);
                        foreach (DataRow row in ds2.Tables[0].Rows)               //นำวัตถุดิบทั้งหมดที่ Query มาเก็บไว้ใน List ชื่อ  AllIngredient
                        {
                            foodregion = Convert.ToString(row[0]);
                        }
                        cnn.Close();

                        List<String> IngerdientWrong = AllIngredient.Except(foodIngre).ToList();    //นำวัตถุดิบทั้งหมด มาเก็บไว้ใน List IngerdientWrong

                        Food_Picture.Image = (Image)Properties.Resources.ResourceManager.GetObject($"{Fooditem}");
                        Food_Name.Text = Fooditem;      //กำหนดข้อความลักษณะอาหารต่าง ๆ ให้แต่ละ Properties
                        choice1.Text = foodIngre[0];
                        choice3.Text = IngerdientWrong[random.Next(IngerdientWrong.Count)];
                        choice2.Text = foodIngre[1];
                        choice4.Text = IngerdientWrong[random.Next(IngerdientWrong.Count)];
                        choice5.Text = foodIngre[2];
                        correctAnswer[0] = 1;
                        correctAnswer[1] = 2;
                        correctAnswer[2] = 5;
                        switch (foodregion)                 //1 = ภาคกลาง, 2 = ภาคเหนือ, 3 = ภาคใต้, 4 = ภาคอีสาน
                        {
                            case "ภาคกลาง":
                                foodRegion = 1;
                                break;
                            case "ภาคเหนือ":
                                foodRegion = 2;
                                break;
                            case "ภาคใต้":
                                foodRegion = 3;
                                break;
                            case "ภาคตะวันออกเฉียงเหนือ":
                                foodRegion = 4;
                                break;
                            default:
                                foodRegion = 5;
                                break;
                        }
                    }

                    catch (Exception ex)
                    {

                    }
                    break;
                case 4:
                    Fooditem = foodListRandom[3];                   //เอาชื่ออาหารจากตัวที่สองใน List มา เป็นโจทย์ข้อที่ 2
                    cnn = new MySqlConnection(connetionString);
                    cnn = new MySqlConnection(connetionString);
                    try
                    {
                        string queryIngre = "select ingredient from Foods f JOIN Foods_IngredientsUse fi ON f.Food_id = fi.food_id join Ingredients i on fi.Ingredient_id = i.Ingredient_id where Food_name ='" + Fooditem + "'"; //Query วัตถุดิบของอาหารนั้น ๆ
                        string queryRegion = "select food_origin from Foods where Food_name ='" + Fooditem + "'";       //Query ภาคอาหารที่ได้

                        cnn.Open();                                             //ทำการติดต่อฐานข้อมูล เพื่อดึงข้อมูล
                        MySqlCommand cmd = new MySqlCommand(queryIngre, cnn);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        foodIngre = new List<string>();
                        foreach (DataRow row in ds.Tables[0].Rows)               //นำชื่อวัตถุดิบที่ถูกต้องที่ดึงได้ เก็บไว้ใน List foodIngre
                        {
                            foodIngre.Add(Convert.ToString(row[0]));
                        }

                        MySqlCommand cmd2 = new MySqlCommand(queryRegion, cnn);     //Query เพื่อดึงข้อมูลวัตถุดิบทั้งหมดมา
                        MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd2);
                        DataSet ds2 = new DataSet();
                        adapter2.Fill(ds2);
                        foreach (DataRow row in ds2.Tables[0].Rows)               //นำวัตถุดิบทั้งหมดที่ Query มาเก็บไว้ใน List ชื่อ  AllIngredient
                        {
                            foodregion = Convert.ToString(row[0]);
                        }
                        cnn.Close();

                        List<String> IngerdientWrong = AllIngredient.Except(foodIngre).ToList();    //นำวัตถุดิบทั้งหมด มาเก็บไว้ใน List IngerdientWrong

                        Food_Picture.Image = (Image)Properties.Resources.ResourceManager.GetObject($"{Fooditem}");
                        Food_Name.Text = Fooditem;      //กำหนดข้อความลักษณะอาหารต่าง ๆ ให้แต่ละ Properties
                        choice2.Text = foodIngre[0];
                        choice1.Text = IngerdientWrong[random.Next(IngerdientWrong.Count)];
                        choice3.Text = foodIngre[1];
                        choice4.Text = IngerdientWrong[random.Next(IngerdientWrong.Count)];
                        choice5.Text = foodIngre[2];
                        correctAnswer[0] = 2;
                        correctAnswer[1] = 3;
                        correctAnswer[2] = 5;
                        switch (foodregion)                 //1 = ภาคกลาง, 2 = ภาคเหนือ, 3 = ภาคใต้, 4 = ภาคอีสาน
                        {
                            case "ภาคกลาง":
                                foodRegion = 1;
                                break;
                            case "ภาคเหนือ":
                                foodRegion = 2;
                                break;
                            case "ภาคใต้":
                                foodRegion = 3;
                                break;
                            case "ภาคตะวันออกเฉียงเหนือ":
                                foodRegion = 4;
                                break;
                            default:
                                foodRegion = 5;
                                break;
                        }
                    }

                    catch (Exception ex)
                    {

                    }
                    break;
                case 5:
                    Fooditem = foodListRandom[4];                   //เอาชื่ออาหารจากตัวที่สองใน List มา เป็นโจทย์ข้อที่ 2
                    cnn = new MySqlConnection(connetionString);
                    cnn = new MySqlConnection(connetionString);
                    try
                    {
                        string queryIngre = "select ingredient from Foods f JOIN Foods_IngredientsUse fi ON f.Food_id = fi.food_id join Ingredients i on fi.Ingredient_id = i.Ingredient_id where Food_name ='" + Fooditem + "'"; //Query วัตถุดิบของอาหารนั้น ๆ
                        string queryRegion = "select food_origin from Foods where Food_name ='" + Fooditem + "'";       //Query ภาคอาหารที่ได้

                        cnn.Open();                                             //ทำการติดต่อฐานข้อมูล เพื่อดึงข้อมูล
                        MySqlCommand cmd = new MySqlCommand(queryIngre, cnn);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        foodIngre = new List<string>();
                        foreach (DataRow row in ds.Tables[0].Rows)               //นำชื่อวัตถุดิบที่ถูกต้องที่ดึงได้ เก็บไว้ใน List foodIngre
                        {
                            foodIngre.Add(Convert.ToString(row[0]));
                        }

                        MySqlCommand cmd2 = new MySqlCommand(queryRegion, cnn);     //Query เพื่อดึงข้อมูลวัตถุดิบทั้งหมดมา
                        MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd2);
                        DataSet ds2 = new DataSet();
                        adapter2.Fill(ds2);
                        foreach (DataRow row in ds2.Tables[0].Rows)               //นำวัตถุดิบทั้งหมดที่ Query มาเก็บไว้ใน List ชื่อ  AllIngredient
                        {
                            foodregion = Convert.ToString(row[0]);
                        }
                        cnn.Close();

                        List<String> IngerdientWrong = AllIngredient.Except(foodIngre).ToList();    //นำวัตถุดิบทั้งหมด มาเก็บไว้ใน List IngerdientWrong

                        Food_Picture.Image = (Image)Properties.Resources.ResourceManager.GetObject($"{Fooditem}");
                        Food_Name.Text = Fooditem;      //กำหนดข้อความลักษณะอาหารต่าง ๆ ให้แต่ละ Properties
                        choice1.Text = foodIngre[0];
                        choice3.Text = IngerdientWrong[random.Next(IngerdientWrong.Count)];
                        choice2.Text = foodIngre[1];
                        choice5.Text = IngerdientWrong[random.Next(IngerdientWrong.Count)];
                        choice4.Text = foodIngre[2];
                        correctAnswer[0] = 1;
                        correctAnswer[1] = 2;
                        correctAnswer[2] = 4;
                        switch (foodregion)                 //1 = ภาคกลาง, 2 = ภาคเหนือ, 3 = ภาคใต้, 4 = ภาคอีสาน
                        {
                            case "ภาคกลาง":
                                foodRegion = 1;
                                break;
                            case "ภาคเหนือ":
                                foodRegion = 2;
                                break;
                            case "ภาคใต้":
                                foodRegion = 3;
                                break;
                            case "ภาคตะวันออกเฉียงเหนือ":
                                foodRegion = 4;
                                break;
                            default:
                                foodRegion = 5;
                                break;
                        }
                    }

                    catch (Exception ex)
                    {

                    }
                    break;
                case 6:
                    Sum sum = new Sum(player, score, "Hard");
                    this.Hide();
                    sum.ShowDialog();
                    break;

            }
        }

        private void choice1_Click(object sender, EventArgs e)
        {
            if (choice1_c == 0)
            {
                if (correctAnswer.Contains(1))
                {
                    correctChoice += 1;
                }
                choice1_c = 1;
                choice1.BackColor = Color.Red;

            }
            else if (choice1_c == 1)
            {
                if (correctAnswer.Contains(1))
                {
                    correctChoice -= 1;
                }
                choice1_c = 0;
                choice1.BackColor = Orange1;
            }
        }

        private void choice2_Click(object sender, EventArgs e)
        {
            if (choice2_c == 0)
            {
                if (correctAnswer.Contains(2))
                {
                    correctChoice += 1;
                }
                choice2_c = 1;
                choice2.BackColor = Color.Red;
            }
            else if (choice2_c == 1)
            {
                if (correctAnswer.Contains(2))
                {
                    correctChoice -= 1;
                }
                choice2_c = 0;
                choice2.BackColor = Orange1;
            }
        }

        private void choice3_Click(object sender, EventArgs e)
        {
            if (choice3_c == 0)
            {
                if (correctAnswer.Contains(3))
                {
                    correctChoice += 1;
                }
                choice3_c = 1;
                choice3.BackColor = Color.Red;
            }
            else if (choice3_c == 1)
            {
                if (correctAnswer.Contains(3))
                {
                    correctChoice -= 1;
                }
                choice3_c = 0;
                choice3.BackColor = Orange1;
            }
        }

        private void choice4_Click(object sender, EventArgs e)
        {
            if (choice4_c == 0)
            {
                if (correctAnswer.Contains(4))
                {
                    correctChoice += 1;
                }
                choice4_c = 1;
                choice4.BackColor = Color.Red;
            }
            else if (choice4_c == 1)
            {
                if (correctAnswer.Contains(4))
                {
                    correctChoice -= 1;
                }
                choice4_c = 0;
                choice4.BackColor = Orange1;
            }
        }

        private void choice5_Click(object sender, EventArgs e)
        {
            if (choice5_c == 0)
            {
                if (correctAnswer.Contains(5))
                {
                    correctChoice += 1;
                }
                choice5_c = 1;
                choice5.BackColor = Color.Red;
            }
            else if (choice5_c == 1)
            {
                if (correctAnswer.Contains(5))
                {
                    correctChoice -= 1;
                }
                choice5_c = 0;
                choice5.BackColor = Orange1;
            }
        }

        public void resetButton()
        {
            choice1.BackColor = Orange1;
            choice2.BackColor = Orange1;
            choice3.BackColor = Orange1;
            choice4.BackColor = Orange1;
            choice5.BackColor = Orange1;
            choice1_c = 0;
            choice2_c = 0;
            choice3_c = 0;
            choice4_c = 0;
            choice5_c = 0;
            correctChoice = 0;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            int index = Food_Region.SelectedIndex+1;
            if (index == foodRegion)
            {
                correctChoice += 1;
            }
            Food_Region.SelectedIndex = -1;
            score += correctChoice;
            questionNum += 1;
            askQuestion(questionNum);
            resetButton();
            SetScore();
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            Option option = new Option();
            option.ShowDialog();
        }
    }
}
