using System;
using System.Windows.Forms;

namespace WindowsFormapdemo
{
    public partial class Login : UserControl
    {
        private Form1 parentForm;
        public event EventHandler LoginSuccess;
        public bool IsAuthenticated { get; private set; }

        public Login(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent; 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usernameOrEmail = txtEmailOrUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            string sampleUsername = "abc123@gmail.com";
            string samplePassword = "123456";

            if ((usernameOrEmail == sampleUsername || usernameOrEmail == "user") && password == samplePassword && password == confirmPassword)
            {
                IsAuthenticated = true;
                MessageBox.Show("Thành công!");

                LoginSuccess?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
