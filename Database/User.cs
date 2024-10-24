namespace TestProject.Database;

public class User
{
    public int Id { get; set; }
    public string? Login { get; set; }
    public string? Password { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Role { get; set; }

    public override string ToString()
        => $"{this.Name} {this.Surname}";
}
