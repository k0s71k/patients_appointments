using System.Data;
using TestProject.Database;

namespace TestProject.Forms
{
    public partial class DoctorMenu : Form
    {
        public DoctorMenu()
        {
            InitializeComponent();

            FillReceptions();
        }

        private void FillReceptions()
        {
            using var context = new DatabaseContext();

            ReceptionsList.Items.Clear();
            ReceptionsList.Items.AddRange(
                context.Receptions
                    .Where(x => x.DoctorId == Program.Session.Id)
                    .ToArray());
        }

        private void ReceptionsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            using var context = new DatabaseContext();

            var reception = ReceptionsList.SelectedItem as Reception;
            if (reception is null)
                return;

            var doctor = context.Users.FirstOrDefault(x => x.Id == reception.DoctorId);
            if (doctor is null)
                doctor = new User
                {
                    Name = "Не определен",
                    Surname = ""
                };
            var patient = context.Users.FirstOrDefault(x => x.Id == reception.PacientId);
            if (patient is null)
                patient = new User
                {
                    Name = "Не определен",
                    Surname = ""
                };
            var spezialization = context.Specializations.FirstOrDefault(x => x.Id == reception.SpecializationId);

            ReceptionInfo.Text = $"Информация о записи:\n\n" +
                $"{spezialization.Name}\n{reception.StartTime.ToString("d.MM (H:mm)")}\n" +
                $"Доктор - {doctor.Name} {doctor.Surname}\n" +
                $"Пациент - {patient.Name} {patient.Surname}\n";
        }

        private void CancelReception(object sender, EventArgs e)
        {
            using var context = new DatabaseContext();

            var reception = ReceptionsList.SelectedItem as Reception;
            if (reception is null)
                return;

            context.Receptions.Remove(reception);
            context.SaveChanges();

            MessageBox.Show("Вы успешно удалили запись");

            FillReceptions();
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
