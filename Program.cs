namespace TestProject;

using TestProject.Database;
using TestProject.Forms;

public static class Program
{
    public static User? Session;

    [STAThread]
    static void Main()
    {
        using var context = new DatabaseContext();
        context.Database.EnsureCreated();

        ApplicationConfiguration.Initialize();
        Application.Run(new Login());
    }

    public static void OpenMenu()
    {
        if (Program.Session is null)
            return;

        Form newForm;
        switch (Program.Session.Role)
        {
            case "pacient":
                newForm = new PacientMenu();
                break;

            case "doctor":
                newForm = new DoctorMenu();
                break;

            case "admin":
                newForm = new AdminMenu();
                break;
            default:
                newForm = null;
                break;
        }

        if (newForm is null)
            return;

        newForm.Show();
    }
}