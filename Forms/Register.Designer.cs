namespace TestProject.Forms
{
    partial class Register
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
            LoginEdit = new TextBox();
            PasswordEdit = new TextBox();
            NameEdit = new TextBox();
            SurnameEdit = new TextBox();
            PhoneEdit = new TextBox();
            RegisterButton = new Button();
            SuspendLayout();
            // 
            // LoginEdit
            // 
            LoginEdit.Location = new Point(12, 12);
            LoginEdit.Name = "LoginEdit";
            LoginEdit.PlaceholderText = "Логин";
            LoginEdit.Size = new Size(256, 23);
            LoginEdit.TabIndex = 0;
            LoginEdit.TextAlign = HorizontalAlignment.Center;
            // 
            // PasswordEdit
            // 
            PasswordEdit.Location = new Point(12, 41);
            PasswordEdit.Name = "PasswordEdit";
            PasswordEdit.PlaceholderText = "Пароль";
            PasswordEdit.Size = new Size(256, 23);
            PasswordEdit.TabIndex = 1;
            PasswordEdit.TextAlign = HorizontalAlignment.Center;
            // 
            // NameEdit
            // 
            NameEdit.Location = new Point(12, 70);
            NameEdit.Name = "NameEdit";
            NameEdit.PlaceholderText = "Имя";
            NameEdit.Size = new Size(256, 23);
            NameEdit.TabIndex = 2;
            NameEdit.TextAlign = HorizontalAlignment.Center;
            // 
            // SurnameEdit
            // 
            SurnameEdit.Location = new Point(12, 99);
            SurnameEdit.Name = "SurnameEdit";
            SurnameEdit.PlaceholderText = "Фамилия";
            SurnameEdit.Size = new Size(256, 23);
            SurnameEdit.TabIndex = 3;
            SurnameEdit.TextAlign = HorizontalAlignment.Center;
            // 
            // PhoneEdit
            // 
            PhoneEdit.Location = new Point(12, 128);
            PhoneEdit.Name = "PhoneEdit";
            PhoneEdit.PlaceholderText = "Тел. Номер";
            PhoneEdit.Size = new Size(256, 23);
            PhoneEdit.TabIndex = 4;
            PhoneEdit.TextAlign = HorizontalAlignment.Center;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(12, 203);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(256, 23);
            RegisterButton.TabIndex = 5;
            RegisterButton.Text = "Зарегистрироваться";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += OnRegisterClick;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 238);
            Controls.Add(RegisterButton);
            Controls.Add(PhoneEdit);
            Controls.Add(SurnameEdit);
            Controls.Add(NameEdit);
            Controls.Add(PasswordEdit);
            Controls.Add(LoginEdit);
            Name = "Register";
            Text = "Register";
            FormClosed += Register_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginEdit;
        private TextBox PasswordEdit;
        private TextBox NameEdit;
        private TextBox SurnameEdit;
        private TextBox PhoneEdit;
        private Button RegisterButton;
    }
}