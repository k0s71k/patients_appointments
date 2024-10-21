using TestProject.Database;

namespace TestProject.Forms;

public partial class Register : Form
{
    public Register()
    {
        InitializeComponent();
    }

    private void OnRegisterClick(object sender, EventArgs e)
    {
        using var context = new DatabaseContext();

        var login = LoginEdit.Text;

        if (context.Users
            .Any(x => x.Login == login))
        {
            MessageBox.Show("Пользователь с таким логином уже существует!)");
            return;
        }

        var user = new User()
        {
            Login = login,
            Password = PasswordEdit.Text,
            Name = NameEdit.Text,
            Surname = SurnameEdit.Text,
            PhoneNumber = PhoneEdit.Text,
            Role = "pacient"
        };

        context.Users.Add(user);

        Program.Session = user;

        context.SaveChanges();

        Program.OpenMenu();
        this.Visible = false;
    }

    private void Register_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }
}
