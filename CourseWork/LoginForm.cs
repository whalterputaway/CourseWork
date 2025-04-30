using System.Data;
using MySql.Data.MySqlClient;
using Functions;


namespace CourseWork
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string LoginUser = LoginField.Text;
            string PassUser = PassField.Text;
            


            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `members` WHERE `login` = @lu AND `pass` = @pu", db.getConnection());
            command.Parameters.Add("@lu", MySqlDbType.VarChar).Value = LoginUser;
            command.Parameters.Add("@pu", MySqlDbType.VarChar).Value = PassUser;
            RememberData.CurrentLogin = LoginUser;

          
            
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                
                this.Hide();
                MenuForm menuform = new MenuForm();
                menuform.Show();
            }
            else
            {
                MessageBox.Show("Не правильный логин или пароль!");
            }
        }


        private void SignLink_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SignForm signform = new SignForm();
            signform.Show();
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

        private void LoginField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
