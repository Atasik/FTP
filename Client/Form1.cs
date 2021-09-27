using System;
using System.Windows.Forms;

namespace Client
{
    public partial class AuthorizationForm : Form
    {
        string url;

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            url = "http://localhost/coursework2021/authorization.php";
            var user = new User();
            user.SetName(userName.Text);
            user.SetPassword(userPassword.Text);
            ClientManager.SetURL(url);
            ClientManager.Authorization(user);

            string response = ClientManager.GetResponse();
            if (response != "error")
            {
                ManagerForm downloadForm = new ManagerForm();
                downloadForm.textToConvert = response;
                downloadForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неверный пароль или логин");
            }
        }
    }
}
