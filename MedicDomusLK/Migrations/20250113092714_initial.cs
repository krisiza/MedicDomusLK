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
                values: new object[] { "7dcb4756-752a-4b6f-bc86-92dc5c3db5d6", null, "Doctor", "DOCTOR" });

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
                    { "04901d21-9108-446b-a62e-b129718175e9", 0, new DateTime(1996, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "47fa3050-1a54-441b-b227-7588c290ff86", "ApplicationUser", "isabella.lee@example.com", false, "Isabella", 0, "Lee", false, null, "ISABELLA.LEE@EXAMPLE.COM", "ISABELLA.LEE", "AQAAAAIAAYagAAAAEHvUU3VfnSeXq0raVOPrhW07DfS9enO848C6FXfd7E7wRPy7GZQUevYFyD8kStanmw==", null, false, "7431a4c0-6c37-44ce-adda-acc0289ad788", "Ninth Street 67", 9, false, "isabella.lee" },
                    { "0f0bd57b-fc8a-4f5a-aa0d-843fc6c71a4e", 0, new DateTime(1975, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "05adde8c-8cfd-48ab-abbf-fc9069465c76", "ApplicationUser", "doctor4@example.com", true, "Michael", null, "Brown", false, null, "DOCTOR4@EXAMPLE.COM", "DOCTOR4@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFiHNY5pmSe9qwsUz5m+Og1GZc1DR5EbMDzGmCixy7wIqzN1uMnQm0oLy6S3vSXwkg==", null, false, "912b3a3a-f437-49cc-8cc4-2e2f0710a8a7", "321 Maple Court", 4, false, "doctor4@example.com" },
                    { "1212dc61-07b2-4851-8d12-1d6247bd7ccc", 0, new DateTime(1992, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "44f0ffc8-85d4-4c97-a047-058c63f1e57a", "ApplicationUser", "cathy.williams@example.com", false, "Cathy", 0, "Williams", false, null, "CATHY.WILLIAMS@EXAMPLE.COM", "CATHY.WILLIAMS", "AQAAAAIAAYagAAAAEPqwzQZKpi6pgytsxsP3hi0C5A/34Pah0vWDd1JWDq2N04cthJ8Pk8mtrvx66TPZAQ==", null, false, "cc5ef741-37f1-43dd-a014-0112f47e203b", "Third Lane 5", 3, false, "cathy.williams" },
                    { "1877a624-8774-4c5d-bc6a-e0bfa775b8d6", 0, new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "a43392b8-a503-4c38-a54a-6be6de73c1aa", "ApplicationUser", "bob.johnson@example.com", false, "Bob", 1, "Johnson", false, null, "BOB.JOHNSON@EXAMPLE.COM", "BOB.JOHNSON", "AQAAAAIAAYagAAAAEN6KPNNCBzg25fbK3OsBaj5SFPg/3aDKzdJOZTfX9WovaG+bgzWHEwrBrSvpl+s+gA==", null, false, "e44c6e23-ad12-4461-b2a2-e8bc8f8dcae6", "Second Avenue 34", 2, false, "bob.johnson" },
                    { "31f662be-cac9-400c-b735-be84b0d0a73d", 0, new DateTime(1987, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "e1b3ae0f-e437-4bd1-9fb7-005b400bf431", "ApplicationUser", "henry.rodriguez@example.com", false, "Henry", 1, "Rodriguez", false, null, "HENRY.RODRIGUEZ@EXAMPLE.COM", "HENRY.RODRIGUEZ", "AQAAAAIAAYagAAAAEH8sbJteFq1Hi1FQXrT3hxCgL/KSH8ocoVWc+x6RJRpm06yTebEPI0OgA9XpW3Aenw==", null, false, "da8466e2-821e-4f13-877e-96d90a2a9cdd", "Eighth Avenue 56", 8, false, "henry.rodriguez" },
                    { "54259b15-9c38-4039-8e3c-f7e07729e0ac", 0, new DateTime(1995, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "dc8d0c4c-ce56-4674-985e-9037089d00ad", "ApplicationUser", "ella.jones@example.com", false, "Ella", 0, "Jones", false, null, "ELLA.JONES@EXAMPLE.COM", "ELLA.JONES", "AQAAAAIAAYagAAAAENHctRton8oFkKILtq2VH6AUx6/OAQYpGIj75lukdGoiiDHbFc8Ljse5n+XBTo/gfw==", null, false, "90a68308-7f80-4c61-9df7-787b1f553e4b", "Fifth Avenue 9", 5, false, "ella.jones" },
                    { "5d2f81d6-a71c-4e40-9c62-896c856563ca", 0, new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "acc5c3d6-a77b-4d1a-918c-dad4dc038b74", "ApplicationUser", "doctor3@example.com", true, "Emily", null, "Johnson", false, null, "DOCTOR3@EXAMPLE.COM", "DOCTOR3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJEeSSCRDgCSxvkQB83bwuzNBTY1Wemnda+I2Dj52gLOTOFqsdMoRd6IE7vfB8RVdw==", null, false, "1e958806-6f9d-4f00-af38-8a595491d34c", "789 Pine Lane", 3, false, "doctor3@example.com" },
                    { "90798a5b-115f-4a1e-83ad-d112e6d66649", 0, new DateTime(1985, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "158d16a7-bcb0-4e43-91a2-b4f176ada0ac", "ApplicationUser", "doctor2@example.com", true, "Jane", null, "Smith", false, null, "DOCTOR2@EXAMPLE.COM", "DOCTOR2@EXAMPLE.COM", "AQAAAAIAAYagAAAAECnVUhSaZYbUNRrTJtv5Mcg2k0WZy07nc9EJUwWiFhISs3sqz1fCPhEIw/fkJB0EnQ==", null, false, "df8c47c7-c686-42c4-9478-3ab94c54a516", "456 Oak Avenue", 2, false, "doctor2@example.com" },
                    { "948d4c9e-4187-4127-9423-a4294f51d9f6", 0, new DateTime(1994, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "1f6aa613-de60-42c4-a553-723d1a5be958", "ApplicationUser", "jack.hernandez@example.com", false, "Jack", 1, "Hernandez", false, null, "JACK.HERNANDEZ@EXAMPLE.COM", "JACK.HERNANDEZ", "AQAAAAIAAYagAAAAEOH6CvB1aMGBdffI277Eda5p6d+lK2tnPAap+eaCYKdHxLMQry1uPFRKWJb6TjmTIQ==", null, false, "9a75731a-cd90-405a-98e3-61209d9eedec", "Tenth Boulevard 89", 10, false, "jack.hernandez" },
                    { "988eef55-3693-4eaf-8fa2-3a0a944d33e0", 0, new DateTime(1988, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "2e08edf4-a2a6-486c-9fe6-ff29cd4f8fdb", "ApplicationUser", "david.brown@example.com", false, "David", 1, "Brown", false, null, "DAVID.BROWN@EXAMPLE.COM", "DAVID.BROWN", "AQAAAAIAAYagAAAAEHEidiglTubbA4P0p/ojNs5oc9d+ypkEV5RiQNDrmbubK6wWIjcpka/NGwqvv5eyZw==", null, false, "08ffc028-cfa2-49cd-aedd-598fb81f1124", "Fourth Street 78", 4, false, "david.brown" },
                    { "af372561-1f84-479c-b380-d740906c1014", 0, new DateTime(1993, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "fa0e998f-fba3-4847-8cae-b32d6cd8a355", "ApplicationUser", "frank.garcia@example.com", false, "Frank", 1, "Garcia", false, null, "FRANK.GARCIA@EXAMPLE.COM", "FRANK.GARCIA", "AQAAAAIAAYagAAAAEAkz4V4K94quJAzrGNvadO7CLE+/U+fzPBAGDL/w9eCpYm/9YYlP01pWWboLNHVzrw==", null, false, "7bb5dcc8-b84a-4f18-b5fa-0d7e9f622fe5", "Sixth Road 23", 6, false, "frank.garcia" },
                    { "c6ad3b43-cbba-49fe-8257-996ce2b72cd9", 0, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ff2b6b67-c713-4e37-b74d-1f0c5f4fd994", "ApplicationUser", "doctor1@example.com", true, "John", null, "Doe", false, null, "DOCTOR1@EXAMPLE.COM", "DOCTOR1@EXAMPLE.COM", "AQAAAAIAAYagAAAAELvj0a9z7wTcY2+0cIOnVxQPlw4Vdyth3ali5cnep4NPnSJHeOGtkla2dUtoKcIS7A==", null, false, "d5587496-44e2-4a93-94a5-36b0da3f3563", "123 Elm Street", 1, false, "doctor1@example.com" },
                    { "c7cce750-5ee7-4870-bf90-846bf41b3aef", 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1173b43c-d800-4d86-9cf7-e3eddaf168b8", "ApplicationUser", "alice.smith@example.com", false, "Alice", 0, "Smith", false, null, "ALICE.SMITH@EXAMPLE.COM", "ALICE.SMITH", "AQAAAAIAAYagAAAAECDdYg9WhFdb+jQdyWCRXBctIhurPH1yXAzv+tXUg4/X0ATGw6KZW9R6ghS7KpabNQ==", null, false, "a8896c47-62dc-457a-bc04-0648dcecdaa4", "Main Street 1", 1, false, "alice.smith" },
                    { "f86df732-0766-4e52-ad7f-99f7bcb9005b", 0, new DateTime(1991, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "d5dd9160-c55f-4875-b0da-c109005823a7", "ApplicationUser", "grace.martinez@example.com", false, "Grace", 0, "Martinez", false, null, "GRACE.MARTINEZ@EXAMPLE.COM", "GRACE.MARTINEZ", "AQAAAAIAAYagAAAAEPByo/ujmBwLdemDEMGgaXVtRVHnYTpk6zI7PW8umlZBZRe6uNYMh+f9UFHSYSR7pw==", null, false, "a017cbf6-7cd0-4bbe-b024-fd666d81e136", "Seventh Street 11", 7, false, "grace.martinez" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "7dcb4756-752a-4b6f-bc86-92dc5c3db5d6", "0f0bd57b-fc8a-4f5a-aa0d-843fc6c71a4e" },
                    { "7dcb4756-752a-4b6f-bc86-92dc5c3db5d6", "5d2f81d6-a71c-4e40-9c62-896c856563ca" },
                    { "7dcb4756-752a-4b6f-bc86-92dc5c3db5d6", "90798a5b-115f-4a1e-83ad-d112e6d66649" },
                    { "7dcb4756-752a-4b6f-bc86-92dc5c3db5d6", "c6ad3b43-cbba-49fe-8257-996ce2b72cd9" }
                });

            migrationBuilder.InsertData(
                table: "DoctorInfos",
                columns: new[] { "Id", "Description", "DoctorId", "ExperienceYear", "Img", "Score", "Sector" },
                values: new object[,]
                {
                    { 1, "Dr. Harris ist spezialisiert auf die Behandlung von Erkrankungen der Knochen, Gelenke und Muskeln und hilft Patienten, sich von Verletzungen und Operationen zu erholen. Mit seiner Expertise in der Orthopädie und Rehabilitation bietet er maßgeschneiderte Behandlungspläne, die sowohl konservative Therapieansätze als auch operative Eingriffe umfassen. Dr. Harris behandelt eine Vielzahl von Erkrankungen wie Arthritis, Bandscheibenvorfälle, Knochenbrüche und Sportverletzungen. Durch moderne diagnostische Verfahren und präzise therapeutische Maßnahmen sorgt er dafür, dass Patienten eine schnelle und vollständige Genesung erfahren. Zusätzlich legt er großen Wert auf die Prävention von orthopädischen Problemen und berät seine Patienten zu ergonomischen Praktiken, Sport und Übungen, die die Muskulatur stärken und Verletzungen vorbeugen. Mit einem empathischen Ansatz begleitet er seine Patienten während des gesamten Heilungsprozesses und stellt sicher, dass sie zu einer besseren Lebensqualität zurückkehren.", "c6ad3b43-cbba-49fe-8257-996ce2b72cd9", 20, "https://www.teleclinic.com/wp-content/uploads/teleclinic-hero-slider-1-image-6.webp", 10.0, "Orthopäde" },
                    { 2, "Dr. Smith konzentriert sich auf die Hautpflege und hilft Patienten bei einer Vielzahl von Hauterkrankungen, darunter Akne, Ekzeme und Psoriasis. Mit ihrer langjährigen Erfahrung in der Dermatologie bietet sie sowohl medizinische Behandlungen als auch ästhetische Lösungen an, um das Hautbild ihrer Patienten zu verbessern. Sie verwendet modernste Technologien und Verfahren, um Hautkrankheiten effektiv zu behandeln und das Wohlbefinden ihrer Patienten zu steigern. Dr. Clarke legt großen Wert auf eine individuelle Beratung und maßgeschneiderte Behandlungskonzepte, die den spezifischen Bedürfnissen jedes Patienten gerecht werden. Sie setzt sich zudem für die Prävention von Hautkrebs ein und bietet regelmäßige Hautscreenings zur frühzeitigen Erkennung von Hautveränderungen an. Mit ihrer empathischen und professionellen Art sorgt Dr. Clarke dafür, dass ihre Patienten nicht nur medizinische Hilfe erhalten, sondern sich auch in ihrer Haut wieder wohlfühlen.", "90798a5b-115f-4a1e-83ad-d112e6d66649", 9, "https://www.collinsdictionary.com/images/full/doctor_117169531.jpg", 9.4399999999999995, "Dermatologin" },
                    { 3, "Dr. Johnsonoy ist spezialisiert auf die Behandlung von Kindern und sorgt für deren gesundes Wachstum und Entwicklung. Sie ist bekannt für ihre einfühlsame Betreuung und ihre Fähigkeit, eine vertrauensvolle Verbindung zu jungen Patienten und ihren Familien aufzubauen. Ihr Schwerpunkt liegt auf der Prävention von Krankheiten sowie der Diagnose und Behandlung von kindlichen Gesundheitsproblemen, um eine optimale Entwicklung zu fördern. Dr. Roy setzt sich dafür ein, dass jedes Kind die beste medizinische Versorgung erhält, mit besonderem Augenmerk auf deren emotionales Wohlbefinden während der Behandlung. Sie arbeitet eng mit den Eltern zusammen, um individuelle Gesundheitspläne zu erstellen, die auf die Bedürfnisse jedes einzelnen Kindes abgestimmt sind.", "5d2f81d6-a71c-4e40-9c62-896c856563ca", 5, "https://cdn4.iconfinder.com/data/icons/ionicons/512/icon-ios7-arrow-right-128.png", 9.9000000000000004, "Pädiaterin" },
                    { 4, "Dr. Garcia ist ein führender Kardiologe mit umfassender Erfahrung in der Diagnose und Behandlung von Herzkrankheiten. Er hat sich auf die Behandlung von Herzinsuffizienz, koronaren Herzkrankheiten, Bluthochdruck und anderen kardiovaskulären Erkrankungen spezialisiert. Dr. Smith nutzt modernste diagnostische Verfahren wie EKG, Herzultraschall und Belastungstests, um eine präzise Diagnose zu stellen. Er legt großen Wert auf eine ganzheitliche Betreuung seiner Patienten, indem er individuelle Therapiepläne erstellt, die sowohl medikamentöse Behandlungen als auch Änderungen des Lebensstils umfassen. Darüber hinaus engagiert sich Dr. Smith aktiv in der Prävention von Herzkrankheiten und bietet seinen Patienten wertvolle Informationen zur gesunden Ernährung, regelmäßiger Bewegung und Stressbewältigung. Durch seine Expertise und einfühlsame Art hilft er seinen Patienten, ihre Lebensqualität zu verbessern und ihre Herzgesundheit langfristig zu erhalten.", "0f0bd57b-fc8a-4f5a-aa0d-843fc6c71a4e", 17, "https://media.istockphoto.com/id/177373093/photo/indian-male-doctor.jpg?s=612x612&w=0&k=20&c=5FkfKdCYERkAg65cQtdqeO_D0JMv6vrEdPw3mX1Lkfg=", 9.3000000000000007, "Kardiologe" }
                });

            migrationBuilder.InsertData(
                table: "DoctorPatientServices",
                columns: new[] { "DateStart", "DoctorId", "PatientId", "ServiceId", "DateEnd" },
                values: new object[,]
                {
                    { new DateTime(2025, 1, 18, 7, 0, 0, 0, DateTimeKind.Unspecified), "0f0bd57b-fc8a-4f5a-aa0d-843fc6c71a4e", "04901d21-9108-446b-a62e-b129718175e9", 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 13, 13, 0, 0, 0, DateTimeKind.Unspecified), "0f0bd57b-fc8a-4f5a-aa0d-843fc6c71a4e", "988eef55-3693-4eaf-8fa2-3a0a944d33e0", 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "5d2f81d6-a71c-4e40-9c62-896c856563ca", "1212dc61-07b2-4851-8d12-1d6247bd7ccc", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), "5d2f81d6-a71c-4e40-9c62-896c856563ca", "31f662be-cac9-400c-b735-be84b0d0a73d", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), "90798a5b-115f-4a1e-83ad-d112e6d66649", "1877a624-8774-4c5d-bc6a-e0bfa775b8d6", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), "90798a5b-115f-4a1e-83ad-d112e6d66649", "f86df732-0766-4e52-ad7f-99f7bcb9005b", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), "c6ad3b43-cbba-49fe-8257-996ce2b72cd9", "af372561-1f84-479c-b380-d740906c1014", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), "c6ad3b43-cbba-49fe-8257-996ce2b72cd9", "c7cce750-5ee7-4870-bf90-846bf41b3aef", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
