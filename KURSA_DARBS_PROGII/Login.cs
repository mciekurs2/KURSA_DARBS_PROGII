using System;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using KURSA_DARBS_PROGII.Scripts;

namespace KURSA_DARBS_PROGII
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Functions.optionCheck = checkBox.Checked;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Martin\Source\Repos\KURSA_DARBS_PROGII\KURSA_DARBS_PROGII\loginDB.mdb";

            conn.Open();
            OleDbCommand cmd = new OleDbCommand();

            cmd.Connection = conn;

            cmd.CommandText = StaticValues.query;
            OleDbDataReader reader = cmd.ExecuteReader();

            reader.Read();

            var inputUser = (reader["Username"].ToString());
            var inputPass = (reader["Password"].ToString());

            if (username.Text == inputUser && password.Text == inputPass)
            {
                var news = new MainWindow();
                news.Show();
                Hide();
            }
            else
            {
                MessageBox.Show(StaticValues.error);
            }

            conn.Close();

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

    internal class StaticValues
    {
        public const string query = "SELECT [username] ,[password] FROM [User]";
        public const string error = "Invalid password or username";
    }

}
