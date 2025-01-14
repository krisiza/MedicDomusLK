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
                values: new object[] { "53f26c91-1f7f-4974-b639-687622fb956e", null, "Doctor", "DOCTOR" });

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
                    { "24b4d3f9-dfa7-439a-ba39-98ac60c62928", 0, new DateTime(1996, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "347f2bfa-087f-4361-beb6-93f4eec5be47", "ApplicationUser", "isabella.lee@example.com", false, "Isabella", 0, "Lee", false, null, "ISABELLA.LEE@EXAMPLE.COM", "ISABELLA.LEE", "AQAAAAIAAYagAAAAEJX2nnXM/+XgDJxdYXOh/9ZJ/AKI6iT4DBABS1qsi7QBTyYnkdRqYWZxvkTxaTXh3Q==", null, false, "b716d816-ce57-4c32-a183-1e48a76f1eb4", "Ninth Street 67", 9, false, "isabella.lee" },
                    { "46acd8b9-3ec9-465e-8bec-d8b91005d413", 0, new DateTime(1987, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "b0dfe75d-fcfe-4e8d-84fa-0a7964969431", "ApplicationUser", "henry.rodriguez@example.com", false, "Henry", 1, "Rodriguez", false, null, "HENRY.RODRIGUEZ@EXAMPLE.COM", "HENRY.RODRIGUEZ", "AQAAAAIAAYagAAAAEMyd5OSfCGn8dmIiC0XyOTzkzXMJhZP0gyNLEkdXomzM8+hc4jYrKEwdm/dreNLFIg==", null, false, "74840530-4d85-43cb-ad08-e146b8b206fc", "Eighth Avenue 56", 8, false, "henry.rodriguez" },
                    { "5ac4a948-83a7-46ac-ab68-dcab3380f7b7", 0, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2242ff9e-3156-49f6-9869-1fd82543dda7", "ApplicationUser", "doctor1@example.com", true, "John", null, "Harris", false, null, "DOCTOR1@EXAMPLE.COM", "DOCTOR1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAxLOqx1/A0Iz8LpYW661JRwvukm9gI/86SjnSMpLvLSXWrfSOPBSL/ADL4XVRJfuQ==", null, false, "f818cd6a-7c38-4911-8277-708d20fd0032", "123 Elm Street", 1, false, "doctor1@example.com" },
                    { "5f3e1ff5-daa2-4257-bab1-a29998b4d17f", 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9287642b-dc1d-475b-8e4f-18bcb721bf9b", "ApplicationUser", "alice.smith@example.com", false, "Alice", 0, "Smith", false, null, "ALICE.SMITH@EXAMPLE.COM", "ALICE.SMITH", "AQAAAAIAAYagAAAAEDgUV/s+wOfHyH6p1dFQAbgzK+S5Chij7EdTTZ1t/atxjM7nwzHOIQaTip3tErDANg==", null, false, "60367076-c2cf-4928-b0a1-2990f5f6e1a1", "Main Street 1", 1, false, "alice.smith" },
                    { "6614bff5-a4eb-42a5-8e10-e8f2139d04c0", 0, new DateTime(1975, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "c95411e9-6434-44a1-a7d7-69b971f97083", "ApplicationUser", "doctor4@example.com", true, "Michael", null, "Garcia", false, null, "DOCTOR4@EXAMPLE.COM", "DOCTOR4@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHlffR3p998wLB0x32Am60KPJJmfsLj1VKR9myIXonQlfny0bUzJKuD62nePNWR1mA==", null, false, "d1496a58-8059-438a-a2b9-7b7e4f388abb", "321 Maple Court", 4, false, "doctor4@example.com" },
                    { "6e0ad939-2b4e-433d-85e5-68e78ffa531e", 0, new DateTime(1985, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "75040278-8028-45ba-8f6d-7ef5e0c43d3e", "ApplicationUser", "doctor2@example.com", true, "Jane", null, "Smith", false, null, "DOCTOR2@EXAMPLE.COM", "DOCTOR2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKaHUBwtSUtJrRX6kuntQ8qjmobWpFgq/BC8rpi6k97OfdCtiAs9l24xXcqzzdGpQg==", null, false, "eb88eaaf-c29d-4cc0-8841-43031f2e3867", "456 Oak Avenue", 2, false, "doctor2@example.com" },
                    { "8198dff8-b4ff-42ae-8ad1-eabbc419df13", 0, new DateTime(1991, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "41114e92-3263-44d5-945c-4ddcbe2ce33e", "ApplicationUser", "grace.martinez@example.com", false, "Grace", 0, "Martinez", false, null, "GRACE.MARTINEZ@EXAMPLE.COM", "GRACE.MARTINEZ", "AQAAAAIAAYagAAAAELFHaH9nhu3H2MlhLDuRrdZqekijeTWxB1NAZ1O79IhRt1A6LxcIfQtUaK6MlLYTHg==", null, false, "5cb7b2b3-06bb-4643-90af-1099c2b29bd9", "Seventh Street 11", 7, false, "grace.martinez" },
                    { "9b5909cf-333a-4030-8a46-ce3948c0e4ed", 0, new DateTime(1994, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "c8897162-8738-4a6e-ac5a-9b1bdc86b855", "ApplicationUser", "jack.hernandez@example.com", false, "Jack", 1, "Hernandez", false, null, "JACK.HERNANDEZ@EXAMPLE.COM", "JACK.HERNANDEZ", "AQAAAAIAAYagAAAAECUT/0zX/+Nyl0ErzIW68rT/nmcSqZei/5y0ML6PHP4gRAu500+N/JYlz5JQqXLxcA==", null, false, "3d0a7ab7-ed7d-439d-96ef-5005c0ae8a27", "Tenth Boulevard 89", 10, false, "jack.hernandez" },
                    { "aa84e156-5d87-43ac-9568-c44b93682083", 0, new DateTime(1993, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "6a2e0312-d6b1-402f-a6ba-f9a185f25b2b", "ApplicationUser", "frank.garcia@example.com", false, "Frank", 1, "Garcia", false, null, "FRANK.GARCIA@EXAMPLE.COM", "FRANK.GARCIA", "AQAAAAIAAYagAAAAEK1hx2Ug9nsRPjD+VhiuxVC5XirGfNQLRtF6/3sUQzFAw6Xlni3e1VD4OKCgwU8iVg==", null, false, "11d837db-1c7a-496d-b326-74c80b783732", "Sixth Road 23", 6, false, "frank.garcia" },
                    { "d0431988-d9ee-42f8-9034-8dd817f467e8", 0, new DateTime(1992, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "b768ff4c-7089-4c73-8539-5b51a801b9eb", "ApplicationUser", "cathy.williams@example.com", false, "Cathy", 0, "Williams", false, null, "CATHY.WILLIAMS@EXAMPLE.COM", "CATHY.WILLIAMS", "AQAAAAIAAYagAAAAEMjpXxxJ7xuhHAPTpHaSBFZkJsK5FaBrEsgdkWlLXLOgX6O2PZiZEuszDez6/BCkSw==", null, false, "182ed173-b78d-4d2b-88e0-33df0e3460c9", "Third Lane 5", 3, false, "cathy.williams" },
                    { "d2b20c09-455b-4f27-842f-8b197a22d538", 0, new DateTime(1988, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "db516e39-e838-4903-bf5f-da8f306f294c", "ApplicationUser", "david.brown@example.com", false, "David", 1, "Brown", false, null, "DAVID.BROWN@EXAMPLE.COM", "DAVID.BROWN", "AQAAAAIAAYagAAAAEME6HibzgIFqvFk9ZubZX/YK5NM2qknguCJ/dyQGn5XGggmJrHy4z3PBD2AiubJ7Bw==", null, false, "e615c3e5-8287-45cf-8e21-0c47277411b0", "Fourth Street 78", 4, false, "david.brown" },
                    { "d99990c7-cc98-4682-a82d-bb17f238fc80", 0, new DateTime(1995, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "95122dc9-c982-418d-b728-df7506aa42dd", "ApplicationUser", "ella.jones@example.com", false, "Ella", 0, "Jones", false, null, "ELLA.JONES@EXAMPLE.COM", "ELLA.JONES", "AQAAAAIAAYagAAAAEKZNZJq7fNR29QrYcVUW70wjIH/ljLNIrenJ3Xl7wFiKK5wno9YYN1wcuE+Ohrxfmg==", null, false, "d22cda4e-3bd0-4ef0-ad02-29a11c384054", "Fifth Avenue 9", 5, false, "ella.jones" },
                    { "da2ecf80-5300-4a27-bc8f-c3450c2ee26e", 0, new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "e810bed4-6ed8-406e-b320-0a27ff174ac2", "ApplicationUser", "bob.johnson@example.com", false, "Bob", 1, "Johnson", false, null, "BOB.JOHNSON@EXAMPLE.COM", "BOB.JOHNSON", "AQAAAAIAAYagAAAAEJMZMfII55ka77cQKqxTzHK/oieQtC9TUHff+OK76LwJPea4BkGAtUX0aaykQd8oOw==", null, false, "cfed5b68-1729-466d-92ea-78927d8bee8a", "Second Avenue 34", 2, false, "bob.johnson" },
                    { "fcf88b80-400d-459b-9738-59934a2e1147", 0, new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "f9630d53-d9ee-49b8-9842-120ed9321323", "ApplicationUser", "doctor3@example.com", true, "Emily", null, "Johnson", false, null, "DOCTOR3@EXAMPLE.COM", "DOCTOR3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGzmP3c7IpxoQSQhBwHpV3xZe2pR99i+vJREtyK8wYB34jC7OwV2ikgzKmH3Cr81tQ==", null, false, "c2baf9f9-39c1-4ec1-8390-d805f5ccfc2e", "789 Pine Lane", 3, false, "doctor3@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "53f26c91-1f7f-4974-b639-687622fb956e", "5ac4a948-83a7-46ac-ab68-dcab3380f7b7" },
                    { "53f26c91-1f7f-4974-b639-687622fb956e", "6614bff5-a4eb-42a5-8e10-e8f2139d04c0" },
                    { "53f26c91-1f7f-4974-b639-687622fb956e", "6e0ad939-2b4e-433d-85e5-68e78ffa531e" },
                    { "53f26c91-1f7f-4974-b639-687622fb956e", "fcf88b80-400d-459b-9738-59934a2e1147" }
                });

            migrationBuilder.InsertData(
                table: "DoctorInfos",
                columns: new[] { "Id", "Description", "DoctorId", "ExperienceYear", "Img", "Score", "Sector" },
                values: new object[,]
                {
                    { 1, "Dr. Harris ist spezialisiert auf die Behandlung von Erkrankungen der Knochen, Gelenke und Muskeln und hilft Patienten, sich von Verletzungen und Operationen zu erholen. Mit seiner Expertise in der Orthopädie und Rehabilitation bietet er maßgeschneiderte Behandlungspläne, die sowohl konservative Therapieansätze als auch operative Eingriffe umfassen. Dr. Harris behandelt eine Vielzahl von Erkrankungen wie Arthritis, Bandscheibenvorfälle, Knochenbrüche und Sportverletzungen. Durch moderne diagnostische Verfahren und präzise therapeutische Maßnahmen sorgt er dafür, dass Patienten eine schnelle und vollständige Genesung erfahren. Zusätzlich legt er großen Wert auf die Prävention von orthopädischen Problemen und berät seine Patienten zu ergonomischen Praktiken, Sport und Übungen, die die Muskulatur stärken und Verletzungen vorbeugen. Mit einem empathischen Ansatz begleitet er seine Patienten während des gesamten Heilungsprozesses und stellt sicher, dass sie zu einer besseren Lebensqualität zurückkehren.", "5ac4a948-83a7-46ac-ab68-dcab3380f7b7", 20, "https://www.teleclinic.com/wp-content/uploads/teleclinic-hero-slider-1-image-6.webp", 10.0, "Orthopäde" },
                    { 2, "Dr. Smith konzentriert sich auf die Hautpflege und hilft Patienten bei einer Vielzahl von Hauterkrankungen, darunter Akne, Ekzeme und Psoriasis. Mit ihrer langjährigen Erfahrung in der Dermatologie bietet sie sowohl medizinische Behandlungen als auch ästhetische Lösungen an, um das Hautbild ihrer Patienten zu verbessern. Sie verwendet modernste Technologien und Verfahren, um Hautkrankheiten effektiv zu behandeln und das Wohlbefinden ihrer Patienten zu steigern. Dr. Clarke legt großen Wert auf eine individuelle Beratung und maßgeschneiderte Behandlungskonzepte, die den spezifischen Bedürfnissen jedes Patienten gerecht werden. Sie setzt sich zudem für die Prävention von Hautkrebs ein und bietet regelmäßige Hautscreenings zur frühzeitigen Erkennung von Hautveränderungen an. Mit ihrer empathischen und professionellen Art sorgt Dr. Clarke dafür, dass ihre Patienten nicht nur medizinische Hilfe erhalten, sondern sich auch in ihrer Haut wieder wohlfühlen.", "6e0ad939-2b4e-433d-85e5-68e78ffa531e", 9, "https://www.collinsdictionary.com/images/full/doctor_117169531.jpg", 9.4399999999999995, "Dermatologin" },
                    { 3, "Dr. Johnson ist spezialisiert auf die Behandlung von Kindern und sorgt für deren gesundes Wachstum und Entwicklung. Sie ist bekannt für ihre einfühlsame Betreuung und ihre Fähigkeit, eine vertrauensvolle Verbindung zu jungen Patienten und ihren Familien aufzubauen. Ihr Schwerpunkt liegt auf der Prävention von Krankheiten sowie der Diagnose und Behandlung von kindlichen Gesundheitsproblemen, um eine optimale Entwicklung zu fördern. Dr. Roy setzt sich dafür ein, dass jedes Kind die beste medizinische Versorgung erhält, mit besonderem Augenmerk auf deren emotionales Wohlbefinden während der Behandlung. Sie arbeitet eng mit den Eltern zusammen, um individuelle Gesundheitspläne zu erstellen, die auf die Bedürfnisse jedes einzelnen Kindes abgestimmt sind.", "fcf88b80-400d-459b-9738-59934a2e1147", 5, "https://img.freepik.com/fotos-kostenlos/schoene-junge-aerztin-die-kamera-im-buero-betrachtet_1301-7807.jpg", 9.9000000000000004, "Pädiaterin" },
                    { 4, "Dr. Garcia ist ein führender Kardiologe mit umfassender Erfahrung in der Diagnose und Behandlung von Herzkrankheiten. Er hat sich auf die Behandlung von Herzinsuffizienz, koronaren Herzkrankheiten, Bluthochdruck und anderen kardiovaskulären Erkrankungen spezialisiert. Dr. Smith nutzt modernste diagnostische Verfahren wie EKG, Herzultraschall und Belastungstests, um eine präzise Diagnose zu stellen. Er legt großen Wert auf eine ganzheitliche Betreuung seiner Patienten, indem er individuelle Therapiepläne erstellt, die sowohl medikamentöse Behandlungen als auch Änderungen des Lebensstils umfassen. Darüber hinaus engagiert sich Dr. Smith aktiv in der Prävention von Herzkrankheiten und bietet seinen Patienten wertvolle Informationen zur gesunden Ernährung, regelmäßiger Bewegung und Stressbewältigung. Durch seine Expertise und einfühlsame Art hilft er seinen Patienten, ihre Lebensqualität zu verbessern und ihre Herzgesundheit langfristig zu erhalten.", "6614bff5-a4eb-42a5-8e10-e8f2139d04c0", 17, "https://media.istockphoto.com/id/177373093/photo/indian-male-doctor.jpg?s=612x612&w=0&k=20&c=5FkfKdCYERkAg65cQtdqeO_D0JMv6vrEdPw3mX1Lkfg=", 9.3000000000000007, "Kardiologe" }
                });

            migrationBuilder.InsertData(
                table: "DoctorPatientServices",
                columns: new[] { "DateStart", "DoctorId", "PatientId", "ServiceId", "DateEnd" },
                values: new object[,]
                {
                    { new DateTime(2025, 1, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), "5ac4a948-83a7-46ac-ab68-dcab3380f7b7", "5f3e1ff5-daa2-4257-bab1-a29998b4d17f", 1, new DateTime(2025, 1, 10, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), "5ac4a948-83a7-46ac-ab68-dcab3380f7b7", "aa84e156-5d87-43ac-9568-c44b93682083", 1, new DateTime(2025, 1, 15, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 18, 7, 0, 0, 0, DateTimeKind.Unspecified), "6614bff5-a4eb-42a5-8e10-e8f2139d04c0", "24b4d3f9-dfa7-439a-ba39-98ac60c62928", 4, new DateTime(2025, 1, 18, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 13, 13, 0, 0, 0, DateTimeKind.Unspecified), "6614bff5-a4eb-42a5-8e10-e8f2139d04c0", "d2b20c09-455b-4f27-842f-8b197a22d538", 4, new DateTime(2025, 1, 13, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), "6e0ad939-2b4e-433d-85e5-68e78ffa531e", "8198dff8-b4ff-42ae-8ad1-eabbc419df13", 2, new DateTime(2025, 1, 16, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), "6e0ad939-2b4e-433d-85e5-68e78ffa531e", "da2ecf80-5300-4a27-bc8f-c3450c2ee26e", 2, new DateTime(2025, 1, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), "fcf88b80-400d-459b-9738-59934a2e1147", "46acd8b9-3ec9-465e-8bec-d8b91005d413", 3, new DateTime(2025, 1, 17, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "fcf88b80-400d-459b-9738-59934a2e1147", "d0431988-d9ee-42f8-9034-8dd817f467e8", 3, new DateTime(2025, 1, 12, 11, 0, 0, 0, DateTimeKind.Unspecified) }
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
