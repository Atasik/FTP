using System;
using System.Linq;
using System.Windows.Forms;

namespace Client
{
    public partial class ManagerForm : Form
    {
        public string textToConvert;
        private string url;

        public ManagerForm()
        {
            InitializeComponent();
        }

        private void DownloadForm_Load(object sender, EventArgs e)
        {
            ConvertResponse();
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            url = "http://localhost/coursework2021/download.php";
            ClientManager.SetURL(url);
            ClientManager.DownloadFile(downloadPath.Text, name.Text);
            MessageBox.Show(ClientManager.GetResponse());
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            url = "http://localhost/coursework2021/upload.php";
            ClientManager.SetURL(url);
            ClientManager.UploadFile(uploadPath.Text, name.Text);
            MessageBox.Show(ClientManager.GetResponse());
        }

        private void ConvertResponse()
        {
            if (textToConvert == "error")
            {
                message.Text = "Ошибка!";
            }
            else if (textToConvert == String.Empty)
            {
                message.Text = "Файлов нет!";
            }
            else
            {
                listOfFiles.Visible = true;
                string[] _files = textToConvert.Split("<br/>").ToArray();
                listOfFiles.Rows.Add(_files.Length);
                for (int i = 0; i < _files.Length - 1; i++)
                {
                    string[] temp = _files[i].Split('~').ToArray();
                    string nameOfFile = temp[0].Substring(13);

                    listOfFiles[0, i].Value = nameOfFile;
                    listOfFiles[1, i].Value = temp[1];
                }
            }
        }
    }
}
