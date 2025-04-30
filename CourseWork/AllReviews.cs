using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Functions;
using MySql.Data.MySqlClient;

namespace CourseWork
{
    public partial class AllReviews : Form
    {
        private List<DataRow> records = new List<DataRow>();
        private int CurrentIndex = 0;
        public AllReviews()
        {
            InitializeComponent();
            LoadRecords();
            ShowCurrentRecord();
        }


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

        private void KillButton_Click(object sender, EventArgs e)
        {
            KillApp.Kill();
        }

        private void LogOutLink_Click(object sender, EventArgs e)
        {
            GoToLog.Logout(this);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ToMenu.Back(this);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ToMenu.Back(this);
        }





        private void ReviewField_TextChanged(object sender, EventArgs e) { }


        private void LoadRecords()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            db.openConnection();
            string query = "SELECT * FROM reviews";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.getConnection());
            adapter.Fill(table);

            records = table.AsEnumerable().ToList();
            db.closeConnection();
        }
        private void ShowCurrentRecord()
        {
            if (records.Count == 0)
            {
                ClearFields();
                return;
            }

            DataRow current = records[CurrentIndex];
            NickField.Text = current["login"].ToString();
            ReviewField.Text = current["review"].ToString();
            GradField.Text= current["grade"].ToString();
            TimeField.Text = current["timing"].ToString();
            TimeField.Text = new string(current["timing"].ToString().Take(10).ToArray());

            string Counter = $"{CurrentIndex + 1}/{records.Count}";


        }

        private void ClearFields()
        {
            NickField.Text = "";
            ReviewField.Text = "";
            GradField.Text = "";
            TimeField.Text = "";

        }


        private void NextReviewButton_Click(object sender, EventArgs e)
        {
            if (records.Count == 0) return;
            CurrentIndex = (CurrentIndex - 1 + records.Count)%records.Count;
            ShowCurrentRecord();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (records.Count == 0) return;

            CurrentIndex = (CurrentIndex - 1 + records.Count) % records.Count;
            ShowCurrentRecord();
        }
    }
}
