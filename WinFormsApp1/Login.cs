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
            if (IDTextBox.Text == "1234" && PASSTextBox.Text == "1234")
            {
                new LoginOK().Show();
                this.Visible = false;
            }

            else
            {
                MessageBox.Show("IDまたはパスワードが間違っています。");
                IDTextBox.Clear();
                PASSTextBox.Clear();
                IDTextBox.Focus();
            }
        }
    }
}
