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
using MySql.Data.MySqlClient;

namespace CourseWork
{
    public partial class SignForm : Form
    {
        public SignForm()
        {
            InitializeComponent();

            NameField.Text = "Введите имя";
            FamilyField.Text = "Введите фамилию";
            NameField.ForeColor = Color.Gray;
            FamilyField.ForeColor = Color.Gray;
        }

        private void ButtonSign_Click(object sender, EventArgs e)
        {
            if (NameField.Text == "Введите имя")
            {
                MessageBox.Show("Вы не ввели имя!");
                return;
            }
            if (FamilyField.Text == "Введите фамилию")
            {
                MessageBox.Show("Вы не ввели фамилию!");
                return;
            }
            if (LoginField.Text == "Введите логин!")
            {
                MessageBox.Show("Вы не ввели логин!");
                return;
            }
            if (PassField.Text == "Введите пароль!")
            {
                MessageBox.Show("Вы не ввели пароль!");
                return;
            }

            if (IsUserExists())
            {
                return;
            }





            DB dB = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `members` (`login`, `pass`, `name`, `family`) VALUES (@login, @pass,@name, @family)", dB.getConnection());
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = LoginField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PassField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = NameField.Text;
            command.Parameters.Add("@family", MySqlDbType.VarChar).Value = FamilyField.Text;

            dB.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такая учетная запись уже существует!");
                return;
                /*
                this.Hide();
                MenuForm menuform = new MenuForm();
                menuform.Show();
                */
            }



            if (command.ExecuteNonQuery() == 1) {
                MessageBox.Show("Учетная запись успешно создана!");
                GoToLog.Logout(this);
                    }
            else
                MessageBox.Show("Учетная запись не создана!");

            dB.closeConnection();
        }

        private void NameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameField_Enter(object sender, EventArgs e)
        {
            if (NameField.Text == "Введите имя")
            {
                NameField.Text = "";
                NameField.ForeColor = Color.Black;
            }
        }

        private void NameField_Leave(object sender, EventArgs e)
        {
            if (NameField.Text == "")
            {
                NameField.Text = "Введите имя";
                NameField.ForeColor = Color.Gray;
            }
        }

        private void FamilyField_Enter(object sender, EventArgs e)
        {
            if (FamilyField.Text == "Введите фамилию")
            {
                FamilyField.Text = "";
                FamilyField.ForeColor = Color.Black;
            }
        }

        private void FamilyField_Leave(object sender, EventArgs e)
        {
            if (FamilyField.Text == "")
            {
                FamilyField.Text = "Введите фамилию";
                FamilyField.ForeColor = Color.Gray;
            }
        }


        public Boolean IsUserExists()
        {
            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `members` WHERE `login` = @lu", db.getConnection());
            command.Parameters.Add("@lu", MySqlDbType.VarChar).Value = LoginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже существует!");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void LoginLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }


        //Перемещение окно
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

    }
}
