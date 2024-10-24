namespace TestProject.Database;

public class Reception
{
    public int Id { get; set; }
    public int DoctorId { get; set; }
    public int PacientId { get; set; }
    public DateTime StartTime { get; set; } = DateTime.Now;
    public int SpecializationId { get; set; }

    public override string ToString()
    {
        using var context = new DatabaseContext();

        var specialization = context.Specializations.FirstOrDefault(x => x.Id == this.SpecializationId);
        if (specialization is null)
        {
            specialization = new Specialization
            {
                Id = -1,
                Name = "Неизвестно",
                Description = ""
            };
        }

        return $"#{this.Id} - {specialization.Name} ({this.StartTime.ToString("dd.MM")})";
    }
}