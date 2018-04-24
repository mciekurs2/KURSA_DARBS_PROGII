using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Functions.optionCheck = checkBox.Checked;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Path.GetFullPath(@"..\..\..\") +
                                    "loginDB.mdb";

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
    }

    class StaticValues
    {
        public const string query = "SELECT [username] ,[password] FROM [User]";
        public const string error = "Invalid password or username";
    }

}
