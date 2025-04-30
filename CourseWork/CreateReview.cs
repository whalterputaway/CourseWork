using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Functions;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using static System.Net.Mime.MediaTypeNames;
using static CourseWork.LoginForm;
using Image = System.Drawing.Image;

namespace CourseWork
{

    public partial class CreateReview : Form
    {
        private bool isEmpty = true;
        private int Rating = 0;
        private readonly string EmptyStar = ("C:\\Users\\modes\\source\\repos\\CourseWork\\CourseWork\\images\\nostar.png");
        private readonly string FilledStar = ("C:\\Users\\modes\\source\\repos\\CourseWork\\CourseWork\\images\\yellowstar.png");



        public CreateReview()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ToMenu.Back(this);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ToMenu.Back(this);
        }

        private void LogOutLink_Click(object sender, EventArgs e)
        {
            GoToLog.Logout(this);
        }

        private void LogOutPicture_Click(object sender, EventArgs e)
        {
            GoToLog.Logout(this);
        }






        private void KillButton_Click(object sender, EventArgs e)
        {
            KillApp.Kill();
        }



        // Перемещение окна
        Point lastPoint;
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }



        //Поставить звездочки
        private void star1_Click(object sender, EventArgs e)
        {
            if (isEmpty)
            {
                star1.Image = Image.FromFile(FilledStar);
                star2.Image = Image.FromFile(EmptyStar);
                star3.Image = Image.FromFile(EmptyStar);
                star4.Image = Image.FromFile(EmptyStar);
                star5.Image = Image.FromFile(EmptyStar);
                isEmpty = false;
                Rating = 1;
            }
            else
            {
                star1.Image = Image.FromFile(FilledStar);
                star2.Image = Image.FromFile(EmptyStar);
                star3.Image = Image.FromFile(EmptyStar);
                star4.Image = Image.FromFile(EmptyStar);
                star5.Image = Image.FromFile(EmptyStar);
                isEmpty = true;
                Rating = 1;
            }
        }

        private void star2_Click(object sender, EventArgs e)
        {
            if (isEmpty)
            {
                star1.Image = Image.FromFile(FilledStar);
                star2.Image = Image.FromFile(FilledStar);
                star3.Image = Image.FromFile(EmptyStar);
                star4.Image = Image.FromFile(EmptyStar);
                star5.Image = Image.FromFile(EmptyStar);
                isEmpty = false;
                Rating = 2;
            }
            else
            {
                star1.Image = Image.FromFile(FilledStar);
                star2.Image = Image.FromFile(FilledStar);
                star3.Image = Image.FromFile(EmptyStar);
                star4.Image = Image.FromFile(EmptyStar);
                star5.Image = Image.FromFile(EmptyStar);
                isEmpty = true;
                Rating = 2;
            }
        }

        private void star3_Click(object sender, EventArgs e)
        {
            if (isEmpty)
            {
                star1.Image = Image.FromFile(FilledStar);
                star2.Image = Image.FromFile(FilledStar);
                star3.Image = Image.FromFile(FilledStar);
                star4.Image = Image.FromFile(EmptyStar);
                star5.Image = Image.FromFile(EmptyStar);
                isEmpty = false;
                Rating = 3;
            }
            else
            {
                star1.Image = Image.FromFile(FilledStar);
                star2.Image = Image.FromFile(FilledStar);
                star3.Image = Image.FromFile(FilledStar);
                star4.Image = Image.FromFile(EmptyStar);
                star5.Image = Image.FromFile(EmptyStar);
                isEmpty = true;
                Rating = 3;
            }
        }

        private void star4_Click(object sender, EventArgs e)
        {
            if (isEmpty)
            {
                star1.Image = Image.FromFile(FilledStar);
                star2.Image = Image.FromFile(FilledStar);
                star3.Image = Image.FromFile(FilledStar);
                star4.Image = Image.FromFile(FilledStar);
                star5.Image = Image.FromFile(EmptyStar);
                isEmpty = false;
                Rating = 4;
            }
            else
            {
                star1.Image = Image.FromFile(FilledStar);
                star2.Image = Image.FromFile(FilledStar);
                star3.Image = Image.FromFile(FilledStar);
                star4.Image = Image.FromFile(FilledStar);
                star5.Image = Image.FromFile(EmptyStar);
                isEmpty = true;
                Rating = 4;
            }
        }

        private void star5_Click(object sender, EventArgs e)
        {
            if (isEmpty)
            {
                star1.Image = Image.FromFile(FilledStar);
                star2.Image = Image.FromFile(FilledStar);
                star3.Image = Image.FromFile(FilledStar);
                star4.Image = Image.FromFile(FilledStar);
                star5.Image = Image.FromFile(FilledStar);
                isEmpty = false;
                Rating = 5;
            }
            else
            {
                star1.Image = Image.FromFile(FilledStar);
                star2.Image = Image.FromFile(FilledStar);
                star3.Image = Image.FromFile(FilledStar);
                star4.Image = Image.FromFile(FilledStar);
                star5.Image = Image.FromFile(FilledStar);
                isEmpty = true;
                Rating = 5;
            }
        }


        private void getGrade()
        {

        }

        private void SendReview_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `reviews` (`login`, `review`, `grade`,`timing`) VALUES (@login, @review, @grade,@timing)",db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = RememberData.CurrentLogin;
            command.Parameters.Add("@review", MySqlDbType.VarChar).Value = ReviewField.Text;
            command.Parameters.Add("@grade", MySqlDbType.VarChar).Value = Rating;
            command.Parameters.Add("@timing", MySqlDbType.Date).Value = DateTime.UtcNow;

            if (ReviewField.Text == "")
            {
                MessageBox.Show("Отзыв не может быть пустым!");
                return;
            }
            else if (Rating ==0)
            {
                MessageBox.Show("Оцените работу звездочками!");
                return;
            }

            db.openConnection();


            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Отзыв успешно отправлен!");
                ToMenu.Back(this);
            }
            else
                MessageBox.Show("Не удалось отправить отзыв!");
            db.closeConnection();
        }

    }




}
