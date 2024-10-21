using TestProject.Database;
using TestProject;

namespace TestProject.Forms;

public partial class Login : Form
{
    public Login()
    {
        InitializeComponent();
    }

    private void OnLoginClick(object sender, EventArgs e)
    {
        using var context = new DatabaseContext();

        var login = this.LoginEdit.Text;
        var password = this.PasswordEdit.Text;

        var user = context.Users
            .FirstOrDefault(x => x.Login == login);
        if (user == null)
        {
            Hint("Пользователя с таким логином не существует");
            return;
        }

        if (user.Password != password)
        {
            Hint("Неправильный пароль");
            return;
        }

        Program.Session = user;

        Program.OpenMenu();
        this.Visible = false;
    }
    private void Hint(string text)
    {
        MessageBox.Show(text);
    }
    private void OnRegisterClick(object sender, EventArgs e)
    {
        var form = new Register();
        form.Show();

        this.Visible = false;
    }
    private void Login_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }
}
