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
            if (String.IsNullOrEmpty(mail)�@&& String.IsNullOrEmpty(pass))
            {
                MessageBox.Show("���[���A�h���X�ƃp�X���[�h�͕K�{�ł��B");
            }
            else if (String.IsNullOrEmpty(mail))
            {
                MessageBox.Show("���[���A�h���X�͕K�{�ł��B");
            }
            else if (String.IsNullOrEmpty(pass))
            {
                MessageBox.Show("�p�X���[�h�͕K�{�ł��B");
            }
            else
            {
                try
                {
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand("select * from m_user where mail = '" + EMailTextBox.Text + "' and pass = '" + PASSTextBox.Text + "' and delete_flg = 0", mySqlConnection);
                    MySqlDataReader reader = mySqlCommand.ExecuteReader();
                    bool isMatch = false; // ��v�t���O��ǉ�
                    while (reader.Read())
                    {
                        if (mail.Equals(reader.GetString("mail")) && pass.Equals(reader.GetString("pass")))
                        {
                            isMatch = true; // ��v������������t���O�𗧂Ă�
                            break; // ���[�v�𔲂���
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
                        MessageBox.Show("�p�X���[�h�������̓��[���A�h���X���Ԉ���Ă��܂��B");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("���͂��ꂽ�f�[�^���s���ł��B");
                }
                finally
                {
                    mySqlConnection.Close();
                }
            }
        }
    }
}
