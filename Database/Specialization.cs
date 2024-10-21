namespace TestProject.Database;

public class Specialization
{
    public int Id {  get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }

    public override string ToString()
        => $"{this.Name}";
}