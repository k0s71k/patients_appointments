using Microsoft.EntityFrameworkCore;
using TestProject.Database;

namespace TestProject.Database
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=projectDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User 
                {
                    Id = 1,
                    Login = "kst",
                    Password = "kst",
                    Name = "kostik",
                    Surname = "",
                    PhoneNumber = "1234567890",
                    Role = "admin"
                },
                new User
                {
                    Id = 3,
                    Login = "terapevt",
                    Password = "dr1",
                    Name = "Сергей",
                    Surname = "Козловский",
                    PhoneNumber = "79567653498",
                    Role = "doctor"
                },
                new User
                {
                    Id = 4,
                    Login = "ortodont",
                    Password = "dr2",
                    Name = "Алексей",
                    Surname = "Дьяченко",
                    PhoneNumber = "79456712785",
                    Role = "doctor"
                },
                new User
                {
                    Id = 5,
                    Login = "childdr",
                    Password = "dr3",
                    Name = "Константин",
                    Surname = "Гагарин",
                    PhoneNumber = "79845931568",
                    Role = "doctor"
                },
                new User
                {
                    Id = 6,
                    Login = "hirurg",
                    Password = "dr4",
                    Name = "Александр",
                    Surname = "Яшин",
                    PhoneNumber = "79578356222",
                    Role = "doctor"
                },
                new User
                {
                    Id = 7,
                    Login = "parodontolog",
                    Password = "dr5",
                    Name = "Дмитрий",
                    Surname = "Дутов",
                    PhoneNumber = "79855622114",
                    Role = "doctor"
                },
                new User
                {
                    Id = 8,
                    Login = "hirurg2",
                    Password = "dr6",
                    Name = "Антон",
                    Surname = "Кульнев",
                    PhoneNumber = "79326729814",
                    Role = "doctor"
                }
            );

            modelBuilder.Entity<Specialization>().HasData(
                new Specialization
                {
                    Id = 1,
                    Name = "Стоматолог - терапевт",
                    Description = ""
                },
                new Specialization
                {
                    Id = 2,
                    Name = "Стоматолог - ортодонт",
                    Description = ""
                },
                new Specialization
                {
                    Id = 3,
                    Name = "Детский стоматолог",
                    Description = ""
                },
                new Specialization
                {
                    Id = 4,
                    Name = "Хирург",
                    Description = ""
                },
                new Specialization
                {
                    Id = 5,
                    Name = "Пародонтолог",
                    Description = ""
                },
                new Specialization
                {
                    Id = 6,
                    Name = "Челюстно - лицевой хирург",
                    Description = ""
                }
            );

            modelBuilder.Entity<Reception>().HasData(
                new Reception
                {
                    Id = 1,
                    DoctorId = 3,
                    PacientId = -1,
                    StartTime = DateTime.Today,
                    SpecializationId = 1,
                },
                new Reception
                {
                    Id = 2,
                    DoctorId = 3,
                    PacientId = -1,
                    StartTime = DateTime.Today,
                    SpecializationId = 1,
                },
                new Reception
                {
                    Id = 3,
                    DoctorId = 3,
                    PacientId = -1,
                    StartTime = DateTime.Today,
                    SpecializationId = 1,
                },
                new Reception
                {
                    Id = 4,
                    DoctorId = 4,
                    PacientId = -1,
                    StartTime = DateTime.Today,
                    SpecializationId = 2,
                },
                new Reception
                {
                    Id = 5,
                    DoctorId = 4,
                    PacientId = -1,
                    StartTime = DateTime.Today,
                    SpecializationId = 2,
                },
                new Reception
                {
                    Id = 6,
                    DoctorId = 4,
                    PacientId = -1,
                    StartTime = DateTime.Today,
                    SpecializationId = 2,
                },
                new Reception
                {
                    Id = 7,
                    DoctorId = 5,
                    PacientId = -1,
                    StartTime = DateTime.Today,
                    SpecializationId = 3,
                },
                new Reception
                {
                    Id = 8,
                    DoctorId = 6,
                    PacientId = -1,
                    StartTime = DateTime.Today,
                    SpecializationId = 3,
                },
                new Reception
                { 
                    Id = 9, 
                    DoctorId = 6, 
                    PacientId = -1, 
                    StartTime = DateTime.Today, 
                    SpecializationId = 4, 
                },
                new Reception
                {
                    Id = 10,
                    DoctorId = 6,
                    PacientId = -1,
                    StartTime = DateTime.Today,
                    SpecializationId = 4,
                }, 
                new Reception
                {
                    Id = 11,
                    DoctorId = 7,
                    PacientId = -1,
                    StartTime = DateTime.Today,
                    SpecializationId = 5,
                },
                new Reception
                {
                    Id = 12,
                    DoctorId = 7,
                    PacientId = -1,
                    StartTime = DateTime.Today,
                    SpecializationId = 5,
                },
                new Reception
                {
                    Id = 13,
                    DoctorId = 7,
                    PacientId = -1,
                    StartTime = DateTime.Today,
                    SpecializationId = 5,
                },
                new Reception
                {
                    Id = 14,
                    DoctorId = 7,
                    PacientId = -1,
                    StartTime = DateTime.Today,
                    SpecializationId = 5,
                },
                new Reception
                {
                    Id = 15,
                    DoctorId = 8,
                    PacientId = -1,
                    StartTime = DateTime.Today,
                    SpecializationId = 6,
                }, 
                new Reception
                {
                    Id = 16,
                    DoctorId = 8,
                    PacientId = -1,
                    StartTime = DateTime.Today,
                    SpecializationId = 6,
                }, 
                new Reception
                {
                    Id = 17,
                    DoctorId = 8,
                    PacientId = -1,
                    StartTime = DateTime.Today,
                    SpecializationId = 6,
                }
            );
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Reception> Receptions { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
    }
}
