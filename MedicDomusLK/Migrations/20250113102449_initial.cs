using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MedicDomusLK.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Towns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PLZ = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Towns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    TownId = table.Column<int>(type: "int", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Towns_TownId",
                        column: x => x.TownId,
                        principalTable: "Towns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoctorInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score = table.Column<double>(type: "float", nullable: false),
                    Sector = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExperienceYear = table.Column<int>(type: "int", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoctorInfos_AspNetUsers_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoctorPatientServices",
                columns: table => new
                {
                    DoctorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    DateStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorPatientServices", x => new { x.DoctorId, x.PatientId, x.ServiceId, x.DateStart });
                    table.ForeignKey(
                        name: "FK_DoctorPatientServices_AspNetUsers_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DoctorPatientServices_AspNetUsers_PatientId",
                        column: x => x.PatientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DoctorPatientServices_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "75638117-8f89-4d1d-8669-f607f8e36d32", null, "Doctor", "DOCTOR" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Allgemeine Untersuchung", 50.00m },
                    { 2, "Kinderuntersuchung", 60.00m },
                    { 3, "Impfung", 30.00m },
                    { 4, "Bluttest", 45.00m },
                    { 5, "Physiotherapiesitzung", 70.00m },
                    { 6, "Spezialistenberatung", 100.00m },
                    { 7, "Roentgenuntersuchung", 160.00m },
                    { 8, "EKG", 200.00m },
                    { 9, "Ultraschalluntersuchung", 220.00m },
                    { 10, "Hoertest", 30.00m },
                    { 11, "Krebsvorsorgeuntersuchung", 60.00m },
                    { 12, "Schlafdiagnostik ", 50.00m }
                });

            migrationBuilder.InsertData(
                table: "Towns",
                columns: new[] { "Id", "Name", "PLZ" },
                values: new object[,]
                {
                    { 1, "Regensburg", "93047" },
                    { 2, "Neumarkt in der Oberpfalz", "92318" },
                    { 3, "Amberg", "92224" },
                    { 4, "Sulzbach-Rosenberg", "92237" },
                    { 5, "Leuchtenberg", "92703" },
                    { 6, "Regensburg-West", "93059" },
                    { 7, "Berching", "92334" },
                    { 8, "Schwandorf", "92421" },
                    { 9, "Beilngries", "92339" },
                    { 10, "Hirschau", "92271" },
                    { 11, "Freudenberg", "92271" },
                    { 12, "Postbauer-Heng", "92353" },
                    { 13, "Vohenstrauss", "92718" },
                    { 14, "Wenzenbach", "93073" },
                    { 15, "Oberviechtach", "92442" },
                    { 16, "Cham", "93413" },
                    { 17, "Bad Koetzting", "93444" },
                    { 18, "Ensdorf", "92266" },
                    { 19, "Neunburg vorm Wald", "92431" },
                    { 20, "Barbing", "93092" },
                    { 21, "Wiesau", "92699" },
                    { 22, "Bodenwoehr", "92439" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthdate", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Firstname", "Gender", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Street", "TownId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0b9d2ed9-574c-4ddc-9737-87114c203f75", 0, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "197be941-0682-4ee3-9c48-384f2e92774e", "ApplicationUser", "doctor1@example.com", true, "John", null, "Harris", false, null, "DOCTOR1@EXAMPLE.COM", "DOCTOR1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEy6O/ob7cGCXov+msTXdo2uVZsy2D2ctkj5oqQbhsYMBdGisjwByAZuPIplyBWrAw==", null, false, "4698c9b4-de06-448a-846c-8f7d2c0509c4", "123 Elm Street", 1, false, "doctor1@example.com" },
                    { "2faf4874-69cc-42d2-b4c8-bf5f896a2439", 0, new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "649bbdff-5fd5-4b45-ba3d-aefb1fe686d5", "ApplicationUser", "doctor3@example.com", true, "Emily", null, "Johnson", false, null, "DOCTOR3@EXAMPLE.COM", "DOCTOR3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKqmNqotR5pzVaYzakO/rEW3AdCD0wEV3eKuUNzIB8qFXyaYhsJYiDGpPwNlGXp7Mw==", null, false, "720b5555-02b4-49f3-802a-535ae87a1f5b", "789 Pine Lane", 3, false, "doctor3@example.com" },
                    { "413dbc47-0ba1-48cc-b864-6fb8dd8c1e1a", 0, new DateTime(1987, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "3debc8b5-dadd-4015-a031-4794ec74ab24", "ApplicationUser", "henry.rodriguez@example.com", false, "Henry", 1, "Rodriguez", false, null, "HENRY.RODRIGUEZ@EXAMPLE.COM", "HENRY.RODRIGUEZ", "AQAAAAIAAYagAAAAECGLy2wALqwzZFlhcZhCZyliTVW3GGNG9Z5Z8d0VM049lsbyoVcY7RVIi9Y5Pzvh/w==", null, false, "1f23d879-c735-40a3-9059-dec34615b6f8", "Eighth Avenue 56", 8, false, "henry.rodriguez" },
                    { "41ebb6c9-4899-4469-b13f-c97af15f5d7a", 0, new DateTime(1995, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "e819bb27-f9c0-486d-8de0-7ca7937bcb2c", "ApplicationUser", "ella.jones@example.com", false, "Ella", 0, "Jones", false, null, "ELLA.JONES@EXAMPLE.COM", "ELLA.JONES", "AQAAAAIAAYagAAAAEI3DScwWMw3ZK/lbL/LCuwVkVq4oRm4C8Tvo+hrOH1JaBMucTJ8EyCTuxSRQcsem7g==", null, false, "29ba68eb-07b0-40bf-9737-06183bd2adc8", "Fifth Avenue 9", 5, false, "ella.jones" },
                    { "47162477-738b-44a6-b750-501c954224c5", 0, new DateTime(1996, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "11745ce8-1894-4884-b48a-24395cfd4fe2", "ApplicationUser", "isabella.lee@example.com", false, "Isabella", 0, "Lee", false, null, "ISABELLA.LEE@EXAMPLE.COM", "ISABELLA.LEE", "AQAAAAIAAYagAAAAEKiq0IRFzbWQyOzD+KBfBhwplJ/8earqF1Ksr9YlItzmDWlK+gJ0PNiYHaXCH17MaA==", null, false, "0e1ed36d-379d-40dc-afe3-4c22121a0461", "Ninth Street 67", 9, false, "isabella.lee" },
                    { "4f202f6a-b381-4406-a250-8d411f260844", 0, new DateTime(1985, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "3d3e7e5d-290f-4d70-a323-e716894993be", "ApplicationUser", "doctor2@example.com", true, "Jane", null, "Smith", false, null, "DOCTOR2@EXAMPLE.COM", "DOCTOR2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBQFlamGFpkaTyzSmPSl89r941nwdPn1HosLfJtangJmC6DRAq1rLhur39SAu60ZFg==", null, false, "2e470e07-16e4-4664-a54f-9afd402c92b6", "456 Oak Avenue", 2, false, "doctor2@example.com" },
                    { "66f927dd-801e-4768-8874-14a49ee43c41", 0, new DateTime(1988, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "e843fc36-cb48-483f-a9c4-67d3969711c0", "ApplicationUser", "david.brown@example.com", false, "David", 1, "Brown", false, null, "DAVID.BROWN@EXAMPLE.COM", "DAVID.BROWN", "AQAAAAIAAYagAAAAEAXPCWp2z7E0zobgYeTk1QKjP/foFh9SB3FXH6AgeeofV5oGPMZmXvhqupNT4irsdA==", null, false, "7ac01131-e20c-42c7-8a10-d5ce16449f50", "Fourth Street 78", 4, false, "david.brown" },
                    { "91df25ac-9558-47fb-8e94-c45684b1aa31", 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c0c87776-3dde-464d-b7a8-898d803d4e99", "ApplicationUser", "alice.smith@example.com", false, "Alice", 0, "Smith", false, null, "ALICE.SMITH@EXAMPLE.COM", "ALICE.SMITH", "AQAAAAIAAYagAAAAEKl4kDgQkEaEW5JHoSHATqooFYp1TOOaG7EZ+EegwsmyLtaX4FL5TII5VA36xnlYCw==", null, false, "bc784bc3-f9fc-4896-8d8e-5872ba280461", "Main Street 1", 1, false, "alice.smith" },
                    { "a44ff257-085f-4d83-98be-0268d5c952d1", 0, new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "7c31f0d8-4cad-4b4b-8dd3-e8acf18aa05a", "ApplicationUser", "bob.johnson@example.com", false, "Bob", 1, "Johnson", false, null, "BOB.JOHNSON@EXAMPLE.COM", "BOB.JOHNSON", "AQAAAAIAAYagAAAAEHNrF7CiFltKhgjMwJ81HK64Q0OCHNXRGf6hb1usv3OxIEraNTg/a5d43MmKxA0jgw==", null, false, "b426f055-e34f-4ce8-87f3-9b9bbbd19a3a", "Second Avenue 34", 2, false, "bob.johnson" },
                    { "b9ab5a62-08c7-47ad-bdac-ba3bfa361500", 0, new DateTime(1993, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "40eb07b3-661f-472f-b9b6-3246c6534f60", "ApplicationUser", "frank.garcia@example.com", false, "Frank", 1, "Garcia", false, null, "FRANK.GARCIA@EXAMPLE.COM", "FRANK.GARCIA", "AQAAAAIAAYagAAAAELWQsYHPSU23/XvwX7+yM5bOgu8wElPCg5oJ+1PxPIVNxMdDbu0/j696tX3Da7c+1A==", null, false, "236d3601-684a-4aa9-bc1d-3449e5507cde", "Sixth Road 23", 6, false, "frank.garcia" },
                    { "c7e30c8b-c0a8-4621-a9b3-0f7145051ec6", 0, new DateTime(1994, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "11685ec1-29af-47c6-b396-df8e4514ec94", "ApplicationUser", "jack.hernandez@example.com", false, "Jack", 1, "Hernandez", false, null, "JACK.HERNANDEZ@EXAMPLE.COM", "JACK.HERNANDEZ", "AQAAAAIAAYagAAAAEFrYIrSdbTqdzzXz989uuWayC40XEqBj4nLGwvAtzF0rDPoXlbLFyWN0zQLpA5rozA==", null, false, "4953da17-950c-41bd-8bd3-7eb7a31e41fc", "Tenth Boulevard 89", 10, false, "jack.hernandez" },
                    { "d1a23989-7fb6-4f99-8b65-8963d81d7f55", 0, new DateTime(1991, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "f4f04534-13b7-4cb1-b3a6-e8e404d03ae5", "ApplicationUser", "grace.martinez@example.com", false, "Grace", 0, "Martinez", false, null, "GRACE.MARTINEZ@EXAMPLE.COM", "GRACE.MARTINEZ", "AQAAAAIAAYagAAAAEAV7LGw7e8biSGAPxdHEeoXhJhr5mXxZ+c9qLBpqifmHZ4htozhZvkH4T9t6K0lugQ==", null, false, "f66d5fee-0e76-4d4d-8c86-12b69ac7c8f5", "Seventh Street 11", 7, false, "grace.martinez" },
                    { "e39be28e-825a-4521-94a9-b1f20e2f0b8c", 0, new DateTime(1975, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "5f990be4-8f40-46c3-8ee4-ffa46909f73a", "ApplicationUser", "doctor4@example.com", true, "Michael", null, "Garcia", false, null, "DOCTOR4@EXAMPLE.COM", "DOCTOR4@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEF7ijeZh5IIABJ1U4hHKZxy7Svgh+S1zQ9MW9ABj1gROSxasCr7oofgXP0OLupw4g==", null, false, "b1985eb5-ac9a-45dd-82d4-dca7930b8c2e", "321 Maple Court", 4, false, "doctor4@example.com" },
                    { "f58938f1-16e7-4e0d-83c1-ab3cb278b3b0", 0, new DateTime(1992, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "4ad077c7-5fe1-4ab2-958a-bf7ebf932368", "ApplicationUser", "cathy.williams@example.com", false, "Cathy", 0, "Williams", false, null, "CATHY.WILLIAMS@EXAMPLE.COM", "CATHY.WILLIAMS", "AQAAAAIAAYagAAAAEGdkT+2vcypq7FxAxYYs/kX56d+bh4rrt7yYE3pWUENr4y1KBQCSxGVpOIhGziwzCQ==", null, false, "1a292529-23d9-4784-a733-802e5f454f4e", "Third Lane 5", 3, false, "cathy.williams" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "75638117-8f89-4d1d-8669-f607f8e36d32", "0b9d2ed9-574c-4ddc-9737-87114c203f75" },
                    { "75638117-8f89-4d1d-8669-f607f8e36d32", "2faf4874-69cc-42d2-b4c8-bf5f896a2439" },
                    { "75638117-8f89-4d1d-8669-f607f8e36d32", "4f202f6a-b381-4406-a250-8d411f260844" },
                    { "75638117-8f89-4d1d-8669-f607f8e36d32", "e39be28e-825a-4521-94a9-b1f20e2f0b8c" }
                });

            migrationBuilder.InsertData(
                table: "DoctorInfos",
                columns: new[] { "Id", "Description", "DoctorId", "ExperienceYear", "Img", "Score", "Sector" },
                values: new object[,]
                {
                    { 1, "Dr. Harris ist spezialisiert auf die Behandlung von Erkrankungen der Knochen, Gelenke und Muskeln und hilft Patienten, sich von Verletzungen und Operationen zu erholen. Mit seiner Expertise in der Orthopädie und Rehabilitation bietet er maßgeschneiderte Behandlungspläne, die sowohl konservative Therapieansätze als auch operative Eingriffe umfassen. Dr. Harris behandelt eine Vielzahl von Erkrankungen wie Arthritis, Bandscheibenvorfälle, Knochenbrüche und Sportverletzungen. Durch moderne diagnostische Verfahren und präzise therapeutische Maßnahmen sorgt er dafür, dass Patienten eine schnelle und vollständige Genesung erfahren. Zusätzlich legt er großen Wert auf die Prävention von orthopädischen Problemen und berät seine Patienten zu ergonomischen Praktiken, Sport und Übungen, die die Muskulatur stärken und Verletzungen vorbeugen. Mit einem empathischen Ansatz begleitet er seine Patienten während des gesamten Heilungsprozesses und stellt sicher, dass sie zu einer besseren Lebensqualität zurückkehren.", "0b9d2ed9-574c-4ddc-9737-87114c203f75", 20, "https://www.teleclinic.com/wp-content/uploads/teleclinic-hero-slider-1-image-6.webp", 10.0, "Orthopäde" },
                    { 2, "Dr. Smith konzentriert sich auf die Hautpflege und hilft Patienten bei einer Vielzahl von Hauterkrankungen, darunter Akne, Ekzeme und Psoriasis. Mit ihrer langjährigen Erfahrung in der Dermatologie bietet sie sowohl medizinische Behandlungen als auch ästhetische Lösungen an, um das Hautbild ihrer Patienten zu verbessern. Sie verwendet modernste Technologien und Verfahren, um Hautkrankheiten effektiv zu behandeln und das Wohlbefinden ihrer Patienten zu steigern. Dr. Clarke legt großen Wert auf eine individuelle Beratung und maßgeschneiderte Behandlungskonzepte, die den spezifischen Bedürfnissen jedes Patienten gerecht werden. Sie setzt sich zudem für die Prävention von Hautkrebs ein und bietet regelmäßige Hautscreenings zur frühzeitigen Erkennung von Hautveränderungen an. Mit ihrer empathischen und professionellen Art sorgt Dr. Clarke dafür, dass ihre Patienten nicht nur medizinische Hilfe erhalten, sondern sich auch in ihrer Haut wieder wohlfühlen.", "4f202f6a-b381-4406-a250-8d411f260844", 9, "https://www.collinsdictionary.com/images/full/doctor_117169531.jpg", 9.4399999999999995, "Dermatologin" },
                    { 3, "Dr. Johnson ist spezialisiert auf die Behandlung von Kindern und sorgt für deren gesundes Wachstum und Entwicklung. Sie ist bekannt für ihre einfühlsame Betreuung und ihre Fähigkeit, eine vertrauensvolle Verbindung zu jungen Patienten und ihren Familien aufzubauen. Ihr Schwerpunkt liegt auf der Prävention von Krankheiten sowie der Diagnose und Behandlung von kindlichen Gesundheitsproblemen, um eine optimale Entwicklung zu fördern. Dr. Roy setzt sich dafür ein, dass jedes Kind die beste medizinische Versorgung erhält, mit besonderem Augenmerk auf deren emotionales Wohlbefinden während der Behandlung. Sie arbeitet eng mit den Eltern zusammen, um individuelle Gesundheitspläne zu erstellen, die auf die Bedürfnisse jedes einzelnen Kindes abgestimmt sind.", "2faf4874-69cc-42d2-b4c8-bf5f896a2439", 5, "https://img.freepik.com/fotos-kostenlos/schoene-junge-aerztin-die-kamera-im-buero-betrachtet_1301-7807.jpg", 9.9000000000000004, "Pädiaterin" },
                    { 4, "Dr. Garcia ist ein führender Kardiologe mit umfassender Erfahrung in der Diagnose und Behandlung von Herzkrankheiten. Er hat sich auf die Behandlung von Herzinsuffizienz, koronaren Herzkrankheiten, Bluthochdruck und anderen kardiovaskulären Erkrankungen spezialisiert. Dr. Smith nutzt modernste diagnostische Verfahren wie EKG, Herzultraschall und Belastungstests, um eine präzise Diagnose zu stellen. Er legt großen Wert auf eine ganzheitliche Betreuung seiner Patienten, indem er individuelle Therapiepläne erstellt, die sowohl medikamentöse Behandlungen als auch Änderungen des Lebensstils umfassen. Darüber hinaus engagiert sich Dr. Smith aktiv in der Prävention von Herzkrankheiten und bietet seinen Patienten wertvolle Informationen zur gesunden Ernährung, regelmäßiger Bewegung und Stressbewältigung. Durch seine Expertise und einfühlsame Art hilft er seinen Patienten, ihre Lebensqualität zu verbessern und ihre Herzgesundheit langfristig zu erhalten.", "e39be28e-825a-4521-94a9-b1f20e2f0b8c", 17, "https://media.istockphoto.com/id/177373093/photo/indian-male-doctor.jpg?s=612x612&w=0&k=20&c=5FkfKdCYERkAg65cQtdqeO_D0JMv6vrEdPw3mX1Lkfg=", 9.3000000000000007, "Kardiologe" }
                });

            migrationBuilder.InsertData(
                table: "DoctorPatientServices",
                columns: new[] { "DateStart", "DoctorId", "PatientId", "ServiceId", "DateEnd" },
                values: new object[,]
                {
                    { new DateTime(2025, 1, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), "0b9d2ed9-574c-4ddc-9737-87114c203f75", "91df25ac-9558-47fb-8e94-c45684b1aa31", 1, new DateTime(2025, 1, 10, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), "0b9d2ed9-574c-4ddc-9737-87114c203f75", "b9ab5a62-08c7-47ad-bdac-ba3bfa361500", 1, new DateTime(2025, 1, 15, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), "2faf4874-69cc-42d2-b4c8-bf5f896a2439", "413dbc47-0ba1-48cc-b864-6fb8dd8c1e1a", 3, new DateTime(2025, 1, 17, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "2faf4874-69cc-42d2-b4c8-bf5f896a2439", "f58938f1-16e7-4e0d-83c1-ab3cb278b3b0", 3, new DateTime(2025, 1, 12, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), "4f202f6a-b381-4406-a250-8d411f260844", "a44ff257-085f-4d83-98be-0268d5c952d1", 2, new DateTime(2025, 1, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), "4f202f6a-b381-4406-a250-8d411f260844", "d1a23989-7fb6-4f99-8b65-8963d81d7f55", 2, new DateTime(2025, 1, 16, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 18, 7, 0, 0, 0, DateTimeKind.Unspecified), "e39be28e-825a-4521-94a9-b1f20e2f0b8c", "47162477-738b-44a6-b750-501c954224c5", 4, new DateTime(2025, 1, 18, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 13, 13, 0, 0, 0, DateTimeKind.Unspecified), "e39be28e-825a-4521-94a9-b1f20e2f0b8c", "66f927dd-801e-4768-8874-14a49ee43c41", 4, new DateTime(2025, 1, 13, 14, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TownId",
                table: "AspNetUsers",
                column: "TownId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorInfos_DoctorId",
                table: "DoctorInfos",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorPatientServices_PatientId",
                table: "DoctorPatientServices",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorPatientServices_ServiceId",
                table: "DoctorPatientServices",
                column: "ServiceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DoctorInfos");

            migrationBuilder.DropTable(
                name: "DoctorPatientServices");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Towns");
        }
    }
}
