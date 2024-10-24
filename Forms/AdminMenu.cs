using System.Data;
using TestProject.Database;

namespace TestProject.Forms
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
            DateTimeSelect.Format = DateTimePickerFormat.Custom;
            DateTimeSelect.CustomFormat = "dd.MM.yy HH:mm";

            using var context = new DatabaseContext();

            DoctorCombo.Items.Clear();
            DoctorCombo.Items.AddRange(
                context.Users
                    .Where(x => x.Role == "doctor")
                    .ToArray());

            SpecializationCombo.Items.Clear();
            SpecializationCombo.Items.AddRange(
                context.Specializations
                    .ToArray());

            FillReceptions();
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AddReception(object sender, EventArgs e)
        {
            using var context = new DatabaseContext();

            var doctor = DoctorCombo.SelectedItem as User;
            if (doctor is null)
                return;

            var specialization = SpecializationCombo.SelectedItem as Specialization;
            if (specialization is null)
                return;

            context.Receptions.Add(new Reception
            {
                DoctorId = doctor.Id,
                SpecializationId = specialization.Id,
                StartTime = DateTimeSelect.Value,
                PacientId = -1
            });

            context.SaveChanges();

            FillReceptions();
        }

        private void FillReceptions()
        {
            using var context = new DatabaseContext();

            Reception[] receptions;
            if (ActiveReceptions.Checked)
                receptions = context.Receptions
                    .Where(x => x.StartTime > DateTime.Now)
                    .ToArray();
            else
                receptions = context.Receptions
                    .ToArray();

            ReceptionsList.Items.Clear();
            ReceptionsList.Items.AddRange(receptions);
        }

        private void DeleteReception(object sender, EventArgs e)
        {
            using var context = new DatabaseContext();

            var reception = ReceptionsList.SelectedItem as Reception;
            if (reception is null)
                return;

            context.Receptions.Remove(reception);
            context.SaveChanges();

            FillReceptions();
        }

        private void ActiveReceptions_CheckedChanged(object sender, EventArgs e)
        {
            FillReceptions();
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
    }
}
