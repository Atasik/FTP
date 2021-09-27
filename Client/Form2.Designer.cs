
namespace Client
{
    partial class ManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.downloadButton = new System.Windows.Forms.Button();
            this.downloadPath = new System.Windows.Forms.TextBox();
            this.listOfFiles = new System.Windows.Forms.DataGridView();
            this.fileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uploadPath = new System.Windows.Forms.TextBox();
            this.uploadButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listOfFiles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(254, 51);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(75, 23);
            this.downloadButton.TabIndex = 1;
            this.downloadButton.Text = "Сохранить";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // downloadPath
            // 
            this.downloadPath.Location = new System.Drawing.Point(124, 22);
            this.downloadPath.Name = "downloadPath";
            this.downloadPath.Size = new System.Drawing.Size(205, 23);
            this.downloadPath.TabIndex = 2;
            // 
            // listOfFiles
            // 
            this.listOfFiles.AllowUserToAddRows = false;
            this.listOfFiles.AllowUserToDeleteRows = false;
            this.listOfFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileName,
            this.fileSize});
            this.listOfFiles.Location = new System.Drawing.Point(7, 27);
            this.listOfFiles.Name = "listOfFiles";
            this.listOfFiles.RowTemplate.Height = 25;
            this.listOfFiles.Size = new System.Drawing.Size(335, 302);
            this.listOfFiles.TabIndex = 3;
            this.listOfFiles.Visible = false;
            // 
            // fileName
            // 
            this.fileName.HeaderText = "Имя файла";
            this.fileName.Name = "fileName";
            this.fileName.ReadOnly = true;
            this.fileName.Width = 145;
            // 
            // fileSize
            // 
            this.fileSize.HeaderText = "Размер файла";
            this.fileSize.Name = "fileSize";
            this.fileSize.ReadOnly = true;
            this.fileSize.Width = 145;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(7, 9);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(96, 15);
            this.message.TabIndex = 4;
            this.message.Text = "Список файлов:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(132, 495);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(205, 23);
            this.name.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Путь сохранения:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Название файла:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.downloadPath);
            this.groupBox1.Controls.Add(this.downloadButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 77);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Скачать файл с сервера";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uploadPath);
            this.groupBox2.Controls.Add(this.uploadButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(7, 415);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 78);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Загрузить файл на сервер";
            // 
            // uploadPath
            // 
            this.uploadPath.Location = new System.Drawing.Point(124, 22);
            this.uploadPath.Name = "uploadPath";
            this.uploadPath.Size = new System.Drawing.Size(205, 23);
            this.uploadPath.TabIndex = 2;
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(203, 51);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(126, 23);
            this.uploadButton.TabIndex = 1;
            this.uploadButton.Text = "Загрузить на сервер";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Путь к файлу:";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 524);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.message);
            this.Controls.Add(this.listOfFiles);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Файловый менеджер";
            this.Load += new System.EventHandler(this.DownloadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listOfFiles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.TextBox downloadPath;
        private System.Windows.Forms.DataGridView listOfFiles;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileSize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox uploadPath;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
    }
}