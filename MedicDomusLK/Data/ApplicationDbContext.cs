using MedicDomusLK.Components.Account.Pages.Manage;
using MedicDomusLK.Data.Models;
using MedicDomusLK.Data.Models.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MedicDomusLK.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Service> Services { get; set; }

        public DbSet<Town> Towns { get; set; }

        public DbSet<ApplicationUser> Users { get; set; }

        public DbSet<DoctorPatientService> DoctorPatientServices { get; set; }

        public DbSet<DoctorInfo> DoctorInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DoctorPatientService>().HasKey(dps => new { dps.DoctorId, dps.PatientId, dps.ServiceId, dps.DateStart });

            modelBuilder.Entity<DoctorPatientService>()
                .HasOne(dps => dps.Doctor)
                .WithMany()
                .HasForeignKey(dps => dps.DoctorId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<DoctorPatientService>()
                 .HasOne(dps => dps.Patient)
                .WithMany()
                .HasForeignKey(dps => dps.PatientId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<DoctorPatientService>()
                .HasOne(dps => dps.Service)
                .WithMany()
                .HasForeignKey(dps => dps.ServiceId)
                .OnDelete(DeleteBehavior.NoAction);


            // Seed Towns
            modelBuilder.Entity<Town>().HasData(
               new Town { Id = 1, PLZ = "93047", Name = "Regensburg" },
               new Town { Id = 2, PLZ = "92318", Name = "Neumarkt in der Oberpfalz" },
               new Town { Id = 3, PLZ = "92224", Name = "Amberg" },
               new Town { Id = 4, PLZ = "92237", Name = "Sulzbach-Rosenberg" },
               new Town { Id = 5, PLZ = "92703", Name = "Leuchtenberg" },
               new Town { Id = 6, PLZ = "93059", Name = "Regensburg-West" },
               new Town { Id = 7, PLZ = "92334", Name = "Berching" },
               new Town { Id = 8, PLZ = "92421", Name = "Schwandorf" },
               new Town { Id = 9, PLZ = "92339", Name = "Beilngries" },
               new Town { Id = 10, PLZ = "92271", Name = "Hirschau" },
               new Town { Id = 11, PLZ = "92271", Name = "Freudenberg" },
               new Town { Id = 12, PLZ = "92353", Name = "Postbauer-Heng" },
               new Town { Id = 13, PLZ = "92718", Name = "Vohenstrauss" },
               new Town { Id = 14, PLZ = "93073", Name = "Wenzenbach" },
               new Town { Id = 15, PLZ = "92442", Name = "Oberviechtach" },
               new Town { Id = 16, PLZ = "93413", Name = "Cham" },
               new Town { Id = 17, PLZ = "93444", Name = "Bad Koetzting" },
               new Town { Id = 18, PLZ = "92266", Name = "Ensdorf" },
               new Town { Id = 19, PLZ = "92431", Name = "Neunburg vorm Wald" },
               new Town { Id = 20, PLZ = "93092", Name = "Barbing" },
               new Town { Id = 21, PLZ = "92699", Name = "Wiesau" },
               new Town { Id = 22, PLZ = "92439", Name = "Bodenwoehr" }
           );

            //Seed Services
            modelBuilder.Entity<Service>().HasData(
                new Service { Id = 1, Name = "Allgemeine Untersuchung", Price = 50.00M },
                new Service { Id = 2, Name = "Kinderuntersuchung", Price = 60.00M },
                new Service { Id = 3, Name = "Impfung", Price = 30.00M },
                new Service { Id = 4, Name = "Bluttest", Price = 45.00M },
                new Service { Id = 5, Name = "Physiotherapiesitzung", Price = 70.00M },
                new Service { Id = 6, Name = "Spezialistenberatung", Price = 100.00M },
                new Service { Id = 7, Name = "Roentgenuntersuchung", Price = 160.00M },
                new Service { Id = 8, Name = "EKG", Price = 200.00M },
                new Service { Id = 9, Name = "Ultraschalluntersuchung", Price = 220.00M },
                new Service { Id = 10, Name = "Hoertest", Price = 30.00M },
                new Service { Id = 11, Name = "Krebsvorsorgeuntersuchung", Price = 60.00M },
                new Service { Id = 12, Name = "Schlafdiagnostik ", Price = 50.00M }
            );

            // Seed Roles
            var doctorRoleId = Guid.NewGuid().ToString();
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = doctorRoleId,
                    Name = "Doctor",
                    NormalizedName = "DOCTOR"
                }
            );

            // Seed Users
            var passwordHasher = new PasswordHasher<ApplicationUser>();
            var users = new List<ApplicationUser>
    {
        new ApplicationUser
        {
            Id = Guid.NewGuid().ToString(),
            UserName = "doctor1@example.com",
            NormalizedUserName = "DOCTOR1@EXAMPLE.COM",
            Email = "doctor1@example.com",
            NormalizedEmail = "DOCTOR1@EXAMPLE.COM",
            EmailConfirmed = true,
            Firstname = "John",
            Lastname = "Harris",
            Birthdate = new DateTime(1980, 1, 1),
            Street = "123 Elm Street",
            TownId = 1,
            PasswordHash = passwordHasher.HashPassword(null, "Password123!")
        },
        new ApplicationUser
        {
            Id = Guid.NewGuid().ToString(),
            UserName = "doctor2@example.com",
            NormalizedUserName = "DOCTOR2@EXAMPLE.COM",
            Email = "doctor2@example.com",
            NormalizedEmail = "DOCTOR2@EXAMPLE.COM",
            EmailConfirmed = true,
            Firstname = "Jane",
            Lastname = "Smith",
            Birthdate = new DateTime(1985, 2, 15),
            Street = "456 Oak Avenue",
            TownId = 2,
            PasswordHash = passwordHasher.HashPassword(null, "Password123!")
        },
        new ApplicationUser
        {
            Id = Guid.NewGuid().ToString(),
            UserName = "doctor3@example.com",
            NormalizedUserName = "DOCTOR3@EXAMPLE.COM",
            Email = "doctor3@example.com",
            NormalizedEmail = "DOCTOR3@EXAMPLE.COM",
            EmailConfirmed = true,
            Firstname = "Emily",
            Lastname = "Johnson",
            Birthdate = new DateTime(1990, 3, 30),
            Street = "789 Pine Lane",
            TownId = 3,
            PasswordHash = passwordHasher.HashPassword(null, "Password123!")
        },
        new ApplicationUser
        {
            Id = Guid.NewGuid().ToString(),
            UserName = "doctor4@example.com",
            NormalizedUserName = "DOCTOR4@EXAMPLE.COM",
            Email = "doctor4@example.com",
            NormalizedEmail = "DOCTOR4@EXAMPLE.COM",
            EmailConfirmed = true,
            Firstname = "Michael",
            Lastname = "Garcia",
            Birthdate = new DateTime(1975, 4, 10),
            Street = "321 Maple Court",
            TownId = 4,
            PasswordHash = passwordHasher.HashPassword(null, "Password123!")
        }
    };

            modelBuilder.Entity<ApplicationUser>().HasData(users);

            // Seed User Roles (assign the Doctor role to users)
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = users[0].Id,  
                    RoleId = doctorRoleId   
                },
                new IdentityUserRole<string>
                {
                    UserId = users[1].Id,  
                    RoleId = doctorRoleId   
                },
                new IdentityUserRole<string>
                {
                    UserId = users[2].Id,  // doctor3@example.com
                    RoleId = doctorRoleId   // Doctor role
                },
                new IdentityUserRole<string>
                {
                    UserId = users[3].Id,  // doctor4@example.com
                    RoleId = doctorRoleId   // Doctor role
                }
            );
        




        //Seed DoctorInfoPage
        var doctorInfos = new List<DoctorInfo>
            {
                new DoctorInfo
                {
                     Id=1,
                    DoctorId = users[0].Id,
                    Description = "Dr. Harris ist spezialisiert auf die Behandlung von Erkrankungen der Knochen, Gelenke und Muskeln und hilft Patienten, sich von Verletzungen und Operationen zu erholen. Mit seiner Expertise in der Orthopädie und Rehabilitation bietet er maßgeschneiderte Behandlungspläne, die sowohl konservative Therapieansätze als auch operative Eingriffe umfassen. Dr. Harris behandelt eine Vielzahl von Erkrankungen wie Arthritis, Bandscheibenvorfälle, Knochenbrüche und Sportverletzungen. Durch moderne diagnostische Verfahren und präzise therapeutische Maßnahmen sorgt er dafür, dass Patienten eine schnelle und vollständige Genesung erfahren. Zusätzlich legt er großen Wert auf die Prävention von orthopädischen Problemen und berät seine Patienten zu ergonomischen Praktiken, Sport und Übungen, die die Muskulatur stärken und Verletzungen vorbeugen. Mit einem empathischen Ansatz begleitet er seine Patienten während des gesamten Heilungsprozesses und stellt sicher, dass sie zu einer besseren Lebensqualität zurückkehren.",
                    Sector = "Orthopäde",
                    ExperienceYear = 20,
                    Score = 10,
                    Img = "https://www.teleclinic.com/wp-content/uploads/teleclinic-hero-slider-1-image-6.webp"
                },
                new DoctorInfo
                {
                     Id=2,
                    DoctorId = users[1].Id,
                    Description =  "Dr. Smith konzentriert sich auf die Hautpflege und hilft Patienten bei einer Vielzahl von Hauterkrankungen, darunter Akne, Ekzeme und Psoriasis. Mit ihrer langjährigen Erfahrung in der Dermatologie bietet sie sowohl medizinische Behandlungen als auch ästhetische Lösungen an, um das Hautbild ihrer Patienten zu verbessern. Sie verwendet modernste Technologien und Verfahren, um Hautkrankheiten effektiv zu behandeln und das Wohlbefinden ihrer Patienten zu steigern. Dr. Clarke legt großen Wert auf eine individuelle Beratung und maßgeschneiderte Behandlungskonzepte, die den spezifischen Bedürfnissen jedes Patienten gerecht werden. Sie setzt sich zudem für die Prävention von Hautkrebs ein und bietet regelmäßige Hautscreenings zur frühzeitigen Erkennung von Hautveränderungen an. Mit ihrer empathischen und professionellen Art sorgt Dr. Clarke dafür, dass ihre Patienten nicht nur medizinische Hilfe erhalten, sondern sich auch in ihrer Haut wieder wohlfühlen.",
                    Sector = "Dermatologin",
                    ExperienceYear = 9,
                    Score = 9.44,
                    Img = "https://www.collinsdictionary.com/images/full/doctor_117169531.jpg"
                },
                new DoctorInfo
                {
                     Id=3,
                    DoctorId = users[2].Id,
                    Description =  "Dr. Johnson ist spezialisiert auf die Behandlung von Kindern und sorgt für deren gesundes Wachstum und Entwicklung. Sie ist bekannt für ihre einfühlsame Betreuung und ihre Fähigkeit, eine vertrauensvolle Verbindung zu jungen Patienten und ihren Familien aufzubauen. Ihr Schwerpunkt liegt auf der Prävention von Krankheiten sowie der Diagnose und Behandlung von kindlichen Gesundheitsproblemen, um eine optimale Entwicklung zu fördern. Dr. Roy setzt sich dafür ein, dass jedes Kind die beste medizinische Versorgung erhält, mit besonderem Augenmerk auf deren emotionales Wohlbefinden während der Behandlung. Sie arbeitet eng mit den Eltern zusammen, um individuelle Gesundheitspläne zu erstellen, die auf die Bedürfnisse jedes einzelnen Kindes abgestimmt sind.",
                    Sector = "Pädiaterin",
                    ExperienceYear = 5,
                    Score = 9.90,
                    Img = "https://img.freepik.com/fotos-kostenlos/schoene-junge-aerztin-die-kamera-im-buero-betrachtet_1301-7807.jpg"
                },
                new DoctorInfo
                {
                    Id=4,
                    DoctorId = users[3].Id,
                    Description =  "Dr. Garcia ist ein führender Kardiologe mit umfassender Erfahrung in der Diagnose und Behandlung von Herzkrankheiten. Er hat sich auf die Behandlung von Herzinsuffizienz, koronaren Herzkrankheiten, Bluthochdruck und anderen kardiovaskulären Erkrankungen spezialisiert. Dr. Smith nutzt modernste diagnostische Verfahren wie EKG, Herzultraschall und Belastungstests, um eine präzise Diagnose zu stellen. Er legt großen Wert auf eine ganzheitliche Betreuung seiner Patienten, indem er individuelle Therapiepläne erstellt, die sowohl medikamentöse Behandlungen als auch Änderungen des Lebensstils umfassen. Darüber hinaus engagiert sich Dr. Smith aktiv in der Prävention von Herzkrankheiten und bietet seinen Patienten wertvolle Informationen zur gesunden Ernährung, regelmäßiger Bewegung und Stressbewältigung. Durch seine Expertise und einfühlsame Art hilft er seinen Patienten, ihre Lebensqualität zu verbessern und ihre Herzgesundheit langfristig zu erhalten.",
                    Sector = "Kardiologe",
                    ExperienceYear = 17,
                    Score = 9.30,
                    Img = "https://media.istockphoto.com/id/177373093/photo/indian-male-doctor.jpg?s=612x612&w=0&k=20&c=5FkfKdCYERkAg65cQtdqeO_D0JMv6vrEdPw3mX1Lkfg="
                }
            };

        modelBuilder.Entity<DoctorInfo>().HasData(doctorInfos);

        //Seed User-Patient
        var patients = new List<ApplicationUser>()
            { new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                Firstname = "Alice",
                Lastname = "Smith",
                Birthdate = new DateTime(1990, 1, 1),
                Gender = Gender.Female,
                TownId = 1,
                Street = "Main Street 1",
                Email = "alice.smith@example.com",
                NormalizedEmail = "ALICE.SMITH@EXAMPLE.COM",
                UserName = "alice.smith",
                NormalizedUserName = "ALICE.SMITH",
                PasswordHash = passwordHasher.HashPassword(null, "Password123!")
            },
                new ApplicationUser
                {
                    Id = Guid.NewGuid().ToString(),
                    Firstname = "Bob",
                    Lastname = "Johnson",
                    Birthdate = new DateTime(1985, 5, 15),
                    Gender = Gender.Male,
                    TownId = 2,
                    Street = "Second Avenue 34",
                    Email = "bob.johnson@example.com",
                    NormalizedEmail = "BOB.JOHNSON@EXAMPLE.COM",
                    UserName = "bob.johnson",
                    NormalizedUserName = "BOB.JOHNSON",
                    PasswordHash = passwordHasher.HashPassword(null, "Password123!")
                },
                new ApplicationUser
                {
                    Id = Guid.NewGuid().ToString(),
                    Firstname = "Cathy",
                    Lastname = "Williams",
                    Birthdate = new DateTime(1992, 3, 10),
                    Gender = Gender.Female,
                    TownId = 3,
                    Street = "Third Lane 5",
                    Email = "cathy.williams@example.com",
                    NormalizedEmail = "CATHY.WILLIAMS@EXAMPLE.COM",
                    UserName = "cathy.williams",
                    NormalizedUserName = "CATHY.WILLIAMS",
                    PasswordHash = passwordHasher.HashPassword(null, "Password123!")
                },

                new ApplicationUser
                {
                    Id = Guid.NewGuid().ToString(),
                    Firstname = "David",
                    Lastname = "Brown",
                    Birthdate = new DateTime(1988, 7, 20),
                    Gender = Gender.Male,
                    TownId = 4,
                    Street = "Fourth Street 78",
                    Email = "david.brown@example.com",
                    NormalizedEmail = "DAVID.BROWN@EXAMPLE.COM",
                    UserName = "david.brown",
                    NormalizedUserName = "DAVID.BROWN",
                    PasswordHash = passwordHasher.HashPassword(null, "Password123!")
                },
                new ApplicationUser
                {
                    Id = Guid.NewGuid().ToString(),
                    Firstname = "Ella",
                    Lastname = "Jones",
                    Birthdate = new DateTime(1995, 12, 12),
                    Gender = Gender.Female,
                    TownId = 5,
                    Street = "Fifth Avenue 9",
                    Email = "ella.jones@example.com",
                    NormalizedEmail = "ELLA.JONES@EXAMPLE.COM",
                    UserName = "ella.jones",
                    NormalizedUserName = "ELLA.JONES",
                    PasswordHash = passwordHasher.HashPassword(null, "Password123!")
                },
                new ApplicationUser
                {
                    Id = Guid.NewGuid().ToString(),
                    Firstname = "Frank",
                    Lastname = "Garcia",
                    Birthdate = new DateTime(1993, 2, 18),
                    Gender = Gender.Male,
                    TownId = 6,
                    Street = "Sixth Road 23",
                    Email = "frank.garcia@example.com",
                    NormalizedEmail = "FRANK.GARCIA@EXAMPLE.COM",
                    UserName = "frank.garcia",
                    NormalizedUserName = "FRANK.GARCIA",
                    PasswordHash = passwordHasher.HashPassword(null, "Password123!")
                },
                new ApplicationUser
                {
                    Id = Guid.NewGuid().ToString(),
                    Firstname = "Grace",
                    Lastname = "Martinez",
                    Birthdate = new DateTime(1991, 6, 25),
                    Gender = Gender.Female,
                    TownId = 7,
                    Street = "Seventh Street 11",
                    Email = "grace.martinez@example.com",
                    NormalizedEmail = "GRACE.MARTINEZ@EXAMPLE.COM",
                    UserName = "grace.martinez",
                    NormalizedUserName = "GRACE.MARTINEZ",
                    PasswordHash = passwordHasher.HashPassword(null, "Password123!")
                },
                new ApplicationUser
                {
                    Id = Guid.NewGuid().ToString(),
                    Firstname = "Henry",
                    Lastname = "Rodriguez",
                    Birthdate = new DateTime(1987, 8, 8),
                    Gender = Gender.Male,
                    TownId = 8,
                    Street = "Eighth Avenue 56",
                    Email = "henry.rodriguez@example.com",
                    NormalizedEmail = "HENRY.RODRIGUEZ@EXAMPLE.COM",
                    UserName = "henry.rodriguez",
                    NormalizedUserName = "HENRY.RODRIGUEZ",
                    PasswordHash = passwordHasher.HashPassword(null, "Password123!")
                },
                new ApplicationUser
                {
                    Id = Guid.NewGuid().ToString(),
                    Firstname = "Isabella",
                    Lastname = "Lee",
                    Birthdate = new DateTime(1996, 9, 30),
                    Gender = Gender.Female,
                    TownId = 9,
                    Street = "Ninth Street 67",
                    Email = "isabella.lee@example.com",
                    NormalizedEmail = "ISABELLA.LEE@EXAMPLE.COM",
                    UserName = "isabella.lee",
                    NormalizedUserName = "ISABELLA.LEE",
                    PasswordHash = passwordHasher.HashPassword(null, "Password123!")
                },
                new ApplicationUser
                {
                    Id = Guid.NewGuid().ToString(),
                    Firstname = "Jack",
                    Lastname = "Hernandez",
                    Birthdate = new DateTime(1994, 4, 3),
                    Gender = Gender.Male,
                    TownId = 10,
                    Street = "Tenth Boulevard 89",
                    Email = "jack.hernandez@example.com",
                    NormalizedEmail = "JACK.HERNANDEZ@EXAMPLE.COM",
                    UserName = "jack.hernandez",
                    NormalizedUserName = "JACK.HERNANDEZ",
                    PasswordHash = passwordHasher.HashPassword(null, "Password123!")
                }
            };
        modelBuilder.Entity<ApplicationUser>().HasData(patients);

        //Seed DoctorPatientService
        var doctorPatientServices = new List<DoctorPatientService>
            {
                new DoctorPatientService
                {
                    DoctorId = users[0].Id,
                    PatientId = patients[0].Id,
                    ServiceId = 1,
                    DateStart = new DateTime(2025, 1, 10, 13, 00 , 00),
                    DateEnd = new DateTime(2025, 1, 10, 14, 00 , 00),
                },
                new DoctorPatientService
                {
                    DoctorId = users[1].Id,
                    PatientId = patients[1].Id,
                    ServiceId = 2,
                    DateStart = new DateTime(2025, 1, 11, 8, 00 , 00),
                    DateEnd = new DateTime(2025, 1, 11, 9, 00 , 00)
                },
                new DoctorPatientService
                {
                    DoctorId = users[2].Id,
                    PatientId = patients[2].Id,
                    ServiceId = 3,
                    DateStart = new DateTime(2025, 1, 12, 10, 00 , 00),
                    DateEnd = new DateTime(2025, 1, 12, 11, 00 , 00)
                },
                new DoctorPatientService
                {
                    DoctorId = users[3].Id,
                    PatientId = patients[3].Id,
                    ServiceId = 4,
                    DateStart = new DateTime(2025, 1, 13, 13, 00 , 00),
                      DateEnd = new DateTime(2025, 1, 13, 14, 00 , 00)
                },
                new DoctorPatientService
                {
                    DoctorId = users[0].Id,
                    PatientId = patients[5].Id,
                    ServiceId = 1,
                    DateStart = new DateTime(2025, 1, 15, 15, 00, 00),
                    DateEnd = new DateTime(2025, 1, 15, 16, 00, 00)
                },
                new DoctorPatientService
                {
                    DoctorId = users[1].Id,
                    PatientId = patients[6].Id,
                    ServiceId = 2,
                    DateStart = new DateTime(2025, 1, 16, 9, 00, 00),
                    DateEnd = new DateTime(2025, 1, 16, 10, 00, 00)
                },
                new DoctorPatientService
                {
                    DoctorId = users[2].Id,
                    PatientId = patients[7].Id,
                    ServiceId = 3,
                    DateStart = new DateTime(2025, 1, 17, 8, 00, 00),
                    DateEnd = new DateTime(2025, 1, 17, 9, 00, 00),
                },
                new DoctorPatientService
                {
                    DoctorId = users[3].Id,
                    PatientId = patients[8].Id,
                    ServiceId = 4,
                    DateStart = new DateTime(2025, 1, 18, 7, 00, 00),
                    DateEnd = new DateTime(2025, 1, 18, 8, 00, 00)
                },
            };

        modelBuilder.Entity<DoctorPatientService>().HasData(doctorPatientServices);
    }
}
}

