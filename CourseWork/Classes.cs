using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseWork;
using MySql.Data.MySqlClient;


namespace Functions
{




    // Переход на страницу авторизации!
    public static class GoToLog
    {
        public static void Logout(Form currentForm)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            currentForm.Close();
        }

    }


    // Переход на страницу главного меню!
    public static class ToMenu
    {
        public static void Back(Form currentForm)
        {
            var menuForm = new MenuForm();
            menuForm.Show();
            currentForm.Close();
        }
    }

    public static class KillApp
    {
        public static void Kill()
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }



    //Запоминать данные учетной записи
    public static class RememberData
    {
        public static string CurrentLogin { get; set; }
    }




    public class DB
    {
        private MySqlConnection _connection;

        public MySqlConnection getConnection()
        {
            return _connection ??= new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=users;");
        }

        public void openConnection()
        {
            if (_connection?.State == ConnectionState.Closed)
                _connection.Open();
        }

        public void closeConnection()
        {
            if (_connection?.State == ConnectionState.Open)
                _connection.Close();
        }
    }


}
