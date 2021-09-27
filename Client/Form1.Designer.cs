
namespace Client
{
    partial class AuthorizationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.authorizationButton = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.TextBox();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // authorizationButton
            // 
            this.authorizationButton.Location = new System.Drawing.Point(10, 112);
            this.authorizationButton.Name = "authorizationButton";
            this.authorizationButton.Size = new System.Drawing.Size(116, 23);
            this.authorizationButton.TabIndex = 0;
            this.authorizationButton.Text = "Авторизоваться";
            this.authorizationButton.UseVisualStyleBackColor = true;
            this.authorizationButton.Click += new System.EventHandler(this.AuthorizationButton_Click);
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(10, 27);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(148, 23);
            this.userName.TabIndex = 1;
            // 
            // userPassword
            // 
            this.userPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userPassword.Location = new System.Drawing.Point(10, 83);
            this.userPassword.Name = "userPassword";
            this.userPassword.PasswordChar = '*';
            this.userPassword.Size = new System.Drawing.Size(148, 25);
            this.userPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 142);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.authorizationButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button authorizationButton;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

