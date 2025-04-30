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
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace CourseWork
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
            GetValue();
        }


        Point lastPoint;
        private void label1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseDown_1(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void KillButton_Click(object sender, EventArgs e)
        {
            KillApp.Kill();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ToMenu.Back(this);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ToMenu.Back(this);
        }

        private void GetValue()
        {   
            DB dB = new DB();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `members` WHERE `login` LIKE @login", dB.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = RememberData.CurrentLogin;

            dB.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    LoginField.Text = (row["login"].ToString());
                    NameField.Text = (row["name"].ToString());
                    FamilyField.Text = (row["family"].ToString());
                    DateOfRegistrationField.Text = (row["date"].ToString().Substring(0, 10));
                }

            }
            dB.closeConnection();
        }
        
    }
}