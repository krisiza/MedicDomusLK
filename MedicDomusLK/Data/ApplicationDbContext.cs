using MedicDomusLK.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MedicDomusLK.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Service> Services { get; set; }

        public DbSet<Town> Towns { get; set; }

        public DbSet<ApplicationUser> Users { get; set; }

        public DbSet<DoctorPatientService> DoctorPatientServices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DoctorPatientService>().HasKey(dps => new { dps.DoctorId, dps.PatientId, dps.ServiceId, dps.Date });

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
               new Town { Id = 13, PLZ = "92718", Name = "Vohenstrauß" },
               new Town { Id = 14, PLZ = "93073", Name = "Wenzenbach" },
               new Town { Id = 15, PLZ = "92442", Name = "Oberviechtach" },
               new Town { Id = 16, PLZ = "93413", Name = "Cham" },
               new Town { Id = 17, PLZ = "93444", Name = "Bad Kötzting" },
               new Town { Id = 18, PLZ = "92266", Name = "Ensdorf" },
               new Town { Id = 19, PLZ = "92431", Name = "Neunburg vorm Wald" },
               new Town { Id = 20, PLZ = "93092", Name = "Barbing" },
               new Town { Id = 21, PLZ = "92699", Name = "Wiesau" },
               new Town { Id = 22, PLZ = "92439", Name = "Bodenwöhr" }
           );

            modelBuilder.Entity<Service>().HasData(
            new Service { Id = 1, Name = "General Consultation", Price = 50.00M },
            new Service { Id = 2, Name = "Pediatric Check-Up", Price = 60.00M },
            new Service { Id = 3, Name = "Vaccination", Price = 30.00M },
            new Service { Id = 4, Name = "Blood Test", Price = 45.00M },
            new Service { Id = 5, Name = "Physical Therapy Session", Price = 70.00M },
            new Service { Id = 6, Name = "Specialist Consultation", Price = 100.00M }
            );


            var doctorRoleId = Guid.NewGuid().ToString();
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = doctorRoleId,
                    Name = "Doctor",
                    NormalizedName = "DOCTOR"
                }
            );

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
                    Lastname = "Doe",
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
                    Lastname = "Brown",
                    Birthdate = new DateTime(1975, 4, 10),
                    Street = "321 Maple Court",
                    TownId = 4,
                    PasswordHash = passwordHasher.HashPassword(null, "Password123!")
                },
                new ApplicationUser
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "doctor5@example.com",
                    NormalizedUserName = "DOCTOR5@EXAMPLE.COM",
                    Email = "doctor5@example.com",
                    NormalizedEmail = "DOCTOR5@EXAMPLE.COM",
                    EmailConfirmed = true,
                    Firstname = "Sarah",
                    Lastname = "Davis",
                    Birthdate = new DateTime(1983, 5, 25),
                    Street = "654 Birch Blvd",
                    TownId = 5,
                    PasswordHash = passwordHasher.HashPassword(null, "Password123!")
                }
            };

            modelBuilder.Entity<ApplicationUser>().HasData(users);

            var userRoles = users.Select(user => new IdentityUserRole<string>
            {
                UserId = user.Id,
                RoleId = doctorRoleId
            }).ToList();

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        }
    }
}

