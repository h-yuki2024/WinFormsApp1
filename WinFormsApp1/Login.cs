using MySql.Data.MySqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq.Expressions;
namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            string connStr = "server=127.0.0.1;user id=root;database=ids;password=";
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(connStr);

                string id = IDTextBox.Text.ToString();
                string pass = PASSTextBox.Text.ToString();
                if (String.IsNullOrEmpty(id) || String.IsNullOrEmpty(pass))
                {
                    MessageBox.Show("no empty fields allowed");
                }
                else
                {
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand("select * from m_user", mySqlConnection);
                    MySqlDataReader reader = mySqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        if (id.Equals(reader.GetString("id")) && pass.Equals(reader.GetString("pass")))
                        {
                            MessageBox.Show("Login success");
                        }
                        else
                        {
                            MessageBox.Show("Invalid Login");
                        }
                    }
                    mySqlConnection.Close();
                }
            }
            catch (Exception ex) { }
        }
    }
}
