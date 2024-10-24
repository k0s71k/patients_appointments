using TestProject.Database;
namespace TestProject.Forms;

public partial class PacientMenu : Form
{
    public PacientMenu()
    {
        InitializeComponent();

        using var context = new DatabaseContext();

        SpecializationsList.Items.Clear();
        SpecializationsList.Items.AddRange(context.Specializations.ToArray());

        FillMyReceptions();
    }

    private void OnSpecializationChanged(object sender, EventArgs e)
    {
        using var context = new DatabaseContext();

        var selectedSpecialization = SpecializationsList.SelectedItem as Specialization;
        if (selectedSpecialization is null)
        {
            MessageBox.Show("Ошибка");
            return;
        }


        var specializationId = selectedSpecialization.Id;

        ReceptionsList.Items.Clear();
        ReceptionsList.Items.AddRange(
            context.Receptions
                .Where(x => x.PacientId == -1
                    && x.SpecializationId == specializationId)
                .ToArray());
    }

    private void OnFormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }

    private void OnTakeClick(object sender, EventArgs e)
    {
        using var context = new DatabaseContext();

        var reception = ReceptionsList.SelectedItem as Reception;
        if (reception is null)
            return;

        reception.PacientId = Program.Session.Id;
        context.Receptions.Update(reception);
        context.SaveChanges();

        FillMyReceptions();
    }

    private void FillMyReceptions()
    {
        using var context = new DatabaseContext();

        MyReceptionsList.Items.Clear();
        MyReceptionsList.Items.AddRange(
            context.Receptions
                .Where(x => x.PacientId == Program.Session.Id)
                .ToArray());
    }
}