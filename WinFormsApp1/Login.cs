using MySql.Data.MySqlClient;
using System.CodeDom;
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
            MySqlConnection mySqlConnection = new MySqlConnection(connStr);

            string mail = EMailTextBox.Text.ToString();
            string pass = PASSTextBox.Text.ToString();
            if (String.IsNullOrEmpty(mail)　&& String.IsNullOrEmpty(pass))
            {
                MessageBox.Show("メールアドレスとパスワードは必須です。");
            }
            else if (String.IsNullOrEmpty(mail))
            {
                MessageBox.Show("メールアドレスは必須です。");
            }
            else if (String.IsNullOrEmpty(pass))
            {
                MessageBox.Show("パスワードは必須です。");
            }
            else
            {
                try
                {
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand("select * from m_user where mail = '" + EMailTextBox.Text + "' and pass = '" + PASSTextBox.Text + "' and delete_flg = 0", mySqlConnection);
                    MySqlDataReader reader = mySqlCommand.ExecuteReader();
                    bool isMatch = false; // 一致フラグを追加
                    while (reader.Read())
                    {
                        if (mail.Equals(reader.GetString("mail")) && pass.Equals(reader.GetString("pass")))
                        {
                            isMatch = true; // 一致が見つかったらフラグを立てる
                            break; // ループを抜ける
                        }
                    }

                    if (isMatch)
                    {
                        string userName = reader.GetString("name");
                        Menu menu = new Menu(userName);
                        menu.Show();
                    }
                    else
                    {
                        MessageBox.Show("パスワードもしくはメールアドレスが間違っています。");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("入力されたデータが不正です。");
                }
                finally
                {
                    mySqlConnection.Close();
                }
            }
        }
    }
}
