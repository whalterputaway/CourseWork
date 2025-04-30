using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Functions;

namespace CourseWork
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }


        private void LogOutLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }

        private void WriteButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateReview createreview = new CreateReview();
            createreview.Show();
        }

        private void ReadReviewsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllReviews allReviews = new AllReviews();
            allReviews.Show();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profile = new Profile();
            profile.Show();
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
    }
}
