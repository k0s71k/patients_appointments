namespace TestProject.Forms;

partial class Login
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
        LoginEdit = new TextBox();
        PasswordEdit = new TextBox();
        LoginButton = new Button();
        RegisterButton = new Button();
        SuspendLayout();
        // 
        // LoginEdit
        // 
        LoginEdit.Location = new Point(13, 12);
        LoginEdit.Name = "LoginEdit";
        LoginEdit.PlaceholderText = "Логин";
        LoginEdit.Size = new Size(214, 23);
        LoginEdit.TabIndex = 0;
        LoginEdit.TextAlign = HorizontalAlignment.Center;
        // 
        // PasswordEdit
        // 
        PasswordEdit.Location = new Point(13, 41);
        PasswordEdit.Name = "PasswordEdit";
        PasswordEdit.PlaceholderText = "Пароль";
        PasswordEdit.Size = new Size(214, 23);
        PasswordEdit.TabIndex = 1;
        PasswordEdit.TextAlign = HorizontalAlignment.Center;
        // 
        // LoginButton
        // 
        LoginButton.Location = new Point(12, 85);
        LoginButton.Name = "LoginButton";
        LoginButton.Size = new Size(215, 23);
        LoginButton.TabIndex = 2;
        LoginButton.Text = "Вход";
        LoginButton.UseVisualStyleBackColor = true;
        LoginButton.Click += OnLoginClick;
        // 
        // RegisterButton
        // 
        RegisterButton.Location = new Point(12, 114);
        RegisterButton.Name = "RegisterButton";
        RegisterButton.Size = new Size(215, 23);
        RegisterButton.TabIndex = 3;
        RegisterButton.Text = "Регистрация";
        RegisterButton.UseVisualStyleBackColor = true;
        RegisterButton.Click += OnRegisterClick;
        // 
        // Login
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(239, 147);
        Controls.Add(RegisterButton);
        Controls.Add(LoginButton);
        Controls.Add(PasswordEdit);
        Controls.Add(LoginEdit);
        Name = "Login";
        Text = "Авторизация";
        FormClosed += this.Login_FormClosed;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox LoginEdit;
    private TextBox PasswordEdit;
    private Button LoginButton;
    private Button RegisterButton;
}
