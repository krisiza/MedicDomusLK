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
                    Firstname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    TownId = table.Column<int>(type: "int", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
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
                name: "Bills",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DoctorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Paid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bills_AspNetUsers_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bills_AspNetUsers_PatientId",
                        column: x => x.PatientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BillId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_Bills_BillId",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BillServices",
                columns: table => new
                {
                    BillId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillServices", x => new { x.BillId, x.ServiceId });
                    table.ForeignKey(
                        name: "FK_BillServices_Bills_BillId",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BillServices_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id");
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
                values: new object[] { "94fd393e-f757-40c6-841e-8d77b2317103", null, "Doctor", "DOCTOR" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "BillId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, null, "Allgemeine Untersuchung", 50.00m },
                    { 2, null, "Kinderuntersuchung", 60.00m },
                    { 3, null, "Impfung", 30.00m },
                    { 4, null, "Bluttest", 45.00m },
                    { 5, null, "Physiotherapiesitzung", 70.00m },
                    { 6, null, "Spezialistenberatung", 100.00m },
                    { 7, null, "Roentgenuntersuchung", 160.00m },
                    { 8, null, "EKG", 200.00m },
                    { 9, null, "Ultraschalluntersuchung", 220.00m },
                    { 10, null, "Hoertest", 30.00m },
                    { 11, null, "Krebsvorsorgeuntersuchung", 60.00m },
                    { 12, null, "Schlafdiagnostik ", 50.00m }
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
                columns: new[] { "Id", "AccessFailedCount", "Birthdate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "Gender", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Street", "TownId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1386af66-971f-4d39-aed9-b0b8cfe0d3ba", 0, new DateTime(1987, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "fa56eebd-8419-4d60-9411-e7960e395e83", "henry.rodriguez@example.com", false, "Henry", 1, "Rodriguez", false, null, "HENRY.RODRIGUEZ@EXAMPLE.COM", "HENRY.RODRIGUEZ", "AQAAAAIAAYagAAAAEE7vUt3oMBr40/GtlgBZoAdOccZ8hxv+MTvk6bztIz/9AjqOHWA70vNpJkL1JAzPqQ==", null, false, "c3c0a937-75a9-4fc1-a5fd-0d3d4f8d1953", "Eighth Avenue 56", 8, false, "henry.rodriguez" },
                    { "46f107fe-a266-4e0a-8670-1c6050e1e6ef", 0, new DateTime(1988, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "192b6e98-9cf0-4548-ada4-eeaeba845f99", "david.brown@example.com", false, "David", 1, "Brown", false, null, "DAVID.BROWN@EXAMPLE.COM", "DAVID.BROWN", "AQAAAAIAAYagAAAAEHQqIDO7OBIC+p8vejxygCkY2Ujj+dYt2rBvrJox0a8pcs6uGpnOi71M/nhbThQCjQ==", null, false, "f9703202-72c9-4c41-be58-ea66c63f95db", "Fourth Street 78", 4, false, "david.brown" },
                    { "4b0edccf-5d4f-4dc3-aea2-0dec1c716b83", 0, new DateTime(1975, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "40ad1e83-c2be-4854-938b-3fd876d1a123", "doctor4@example.com", true, "Michael", null, "Garcia", false, null, "DOCTOR4@EXAMPLE.COM", "DOCTOR4@EXAMPLE.COM", "AQAAAAIAAYagAAAAEP4j+TOxHw/Y0qNiAkEJdQuBjm6wuphX3ERautrE2a4uPXOyustEWBo0KjKzP22rgA==", null, false, "18178c3b-7da3-429e-9a70-2818c7786b43", "321 Maple Court", 4, false, "doctor4@example.com" },
                    { "5875217f-bef2-4ffe-bd9d-f62abb7c5151", 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0023599d-79b6-4d4b-b071-973b70ceba06", "alice.smith@example.com", false, "Alice", 0, "Smith", false, null, "ALICE.SMITH@EXAMPLE.COM", "ALICE.SMITH", "AQAAAAIAAYagAAAAEKSKOMMkZcRqNhFT7VisXBci+blWwdaarkLP71tDOI51iNPonRGLFwp0HHMjtJY1zw==", null, false, "ffb75a82-5649-403f-b1a3-386ce1e73348", "Main Street 1", 1, false, "alice.smith" },
                    { "5ad0f591-9f02-4ccb-8bb6-148cb1159900", 0, new DateTime(1991, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "58ff0c64-e2ba-4261-99c4-0ea85f35cb9e", "grace.martinez@example.com", false, "Grace", 0, "Martinez", false, null, "GRACE.MARTINEZ@EXAMPLE.COM", "GRACE.MARTINEZ", "AQAAAAIAAYagAAAAENoB3JGkgXUEMNaus58V2uzSmIeu565Mv1kgjw5j4VqKycij0R8xUVYU6lpCP/J39Q==", null, false, "4f95715a-1860-44ad-abb0-06a304cf7c0b", "Seventh Street 11", 7, false, "grace.martinez" },
                    { "6c2279c0-c299-43af-87d9-1f8f468132d9", 0, new DateTime(1992, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "cedfd59f-f06b-4092-9a7f-9179384d857e", "cathy.williams@example.com", false, "Cathy", 0, "Williams", false, null, "CATHY.WILLIAMS@EXAMPLE.COM", "CATHY.WILLIAMS", "AQAAAAIAAYagAAAAENKOu+4KbuYjoQYrqX+lRutNAyGDRCSgYEe1YfAfszOqKgD+qEqPsrigTvDWokWRbA==", null, false, "95afe3f7-ebe2-4d43-94b7-6938a1b2009a", "Third Lane 5", 3, false, "cathy.williams" },
                    { "abdf7ffa-2b33-4ca6-b333-238a3216ceaf", 0, new DateTime(1985, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "c477be32-e42d-4ae4-a7a2-07fdb606ed10", "doctor2@example.com", true, "Jane", null, "Smith", false, null, "DOCTOR2@EXAMPLE.COM", "DOCTOR2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIVDUEtJo32Ct+P2+I2DpwMNTFQQMtt3mswrKQVTTn/eExk0sHQ46YfCdzXtSK2Qxw==", null, false, "e5d62ceb-1158-42e5-af02-9686221e1d48", "456 Oak Avenue", 2, false, "doctor2@example.com" },
                    { "aca792bf-dacd-43d5-ac83-9038daf44bbe", 0, new DateTime(1994, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "fd5f34a5-1e5d-4371-a21e-dcf6c640a8ac", "jack.hernandez@example.com", false, "Jack", 1, "Hernandez", false, null, "JACK.HERNANDEZ@EXAMPLE.COM", "JACK.HERNANDEZ", "AQAAAAIAAYagAAAAEGWN1+wiDdGgHCm5NiMrPHd5CephBsqi8lNW13//oFPWGF4OzjPJXDlGyhsXGwWjIg==", null, false, "e42bac31-4944-4e14-aeff-c2d233df94e3", "Tenth Boulevard 89", 10, false, "jack.hernandez" },
                    { "b4266ce7-ff9e-47de-93c9-be6b91485f2f", 0, new DateTime(1996, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "5d4064f4-15c4-4841-820c-c1ba9df09a05", "isabella.lee@example.com", false, "Isabella", 0, "Lee", false, null, "ISABELLA.LEE@EXAMPLE.COM", "ISABELLA.LEE", "AQAAAAIAAYagAAAAEAqRoUOuT92b8l5+rjYtyhP9Dr1p4qeQ5A9DKSBGCkqWy6dC4mbO5B7QAZrEOKHvVQ==", null, false, "6849bcaf-5b62-492f-a687-7084d1dcc024", "Ninth Street 67", 9, false, "isabella.lee" },
                    { "c53673ae-0e63-4660-b7a8-21877a361300", 0, new DateTime(1993, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "4715881f-e9e6-4f1a-9b65-a9722013d5d7", "frank.garcia@example.com", false, "Frank", 1, "Garcia", false, null, "FRANK.GARCIA@EXAMPLE.COM", "FRANK.GARCIA", "AQAAAAIAAYagAAAAEJOibFZsOcxB1v6ekiGWyvKKJCIWBdTXBEyxnb+Opfw4NFtrhUgRuX0e8UwkmD1CVw==", null, false, "8c284aa5-63cc-465d-9e4e-1af56d4297c4", "Sixth Road 23", 6, false, "frank.garcia" },
                    { "d0a08a30-f0a9-40ff-a01b-05e04bb62a35", 0, new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "5b9b9015-fdbc-4b1b-ad03-a00b2eee65cc", "doctor3@example.com", true, "Emily", null, "Johnson", false, null, "DOCTOR3@EXAMPLE.COM", "DOCTOR3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEB1qVHr1JYH+VPMSEKL2v9cDM1NkcQrCRZzb7QPZ8fInTJ68CHdTmN1sQDWgCo0xKw==", null, false, "097cf25c-50fd-4a37-bd39-6324132f2327", "789 Pine Lane", 3, false, "doctor3@example.com" },
                    { "d55212aa-2ef6-4b11-ae28-ea7d834841a7", 0, new DateTime(1995, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "a8788ce3-6578-4731-b29f-5fdba0eadedd", "ella.jones@example.com", false, "Ella", 0, "Jones", false, null, "ELLA.JONES@EXAMPLE.COM", "ELLA.JONES", "AQAAAAIAAYagAAAAECtRwxB/OM5+cjJU3ZfEBAw0XuDPedL2/WUhMkWFe3BLE7vzUqaT9yu5uXgINgA5jw==", null, false, "c400e4d8-e531-4b4d-a030-473d8b964972", "Fifth Avenue 9", 5, false, "ella.jones" },
                    { "d884af72-adc2-4715-81c6-e7fed27d10c1", 0, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "de87abcf-69e5-4224-8405-281b9417bc45", "doctor1@example.com", true, "John", null, "Harris", false, null, "DOCTOR1@EXAMPLE.COM", "DOCTOR1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEN8k5e7E4F3wDl92RlTFRp9uY83zQTg/d2jqlf6bZhMML4XS7kFpJiJTOxFwudpA4A==", null, false, "67ff3e77-ca38-4377-86ba-d9e04bb15d18", "123 Elm Street", 1, false, "doctor1@example.com" },
                    { "f6a48a77-22fb-4f07-904a-0f4654c395bb", 0, new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "57f6be75-b857-4629-bb33-af68e360b549", "bob.johnson@example.com", false, "Bob", 1, "Johnson", false, null, "BOB.JOHNSON@EXAMPLE.COM", "BOB.JOHNSON", "AQAAAAIAAYagAAAAEPWTJ05foYeS93kmhEl8uqNXDvEsvqj5a88gixK9YcV704qchpINCOs5k0Ork4ewJQ==", null, false, "2b71da28-c077-412c-b0c4-56982da29a0f", "Second Avenue 34", 2, false, "bob.johnson" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "94fd393e-f757-40c6-841e-8d77b2317103", "4b0edccf-5d4f-4dc3-aea2-0dec1c716b83" },
                    { "94fd393e-f757-40c6-841e-8d77b2317103", "abdf7ffa-2b33-4ca6-b333-238a3216ceaf" },
                    { "94fd393e-f757-40c6-841e-8d77b2317103", "d0a08a30-f0a9-40ff-a01b-05e04bb62a35" },
                    { "94fd393e-f757-40c6-841e-8d77b2317103", "d884af72-adc2-4715-81c6-e7fed27d10c1" }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "Id", "Date", "DoctorId", "Paid", "PatientId", "Price" },
                values: new object[,]
                {
                    { "465644e0-4cb9-4f20-818e-35a3701967df", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "d884af72-adc2-4715-81c6-e7fed27d10c1", false, "b4266ce7-ff9e-47de-93c9-be6b91485f2f", 45.00m },
                    { "49bcf0ca-e41a-44b6-ab4c-fb6005323cf7", new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "abdf7ffa-2b33-4ca6-b333-238a3216ceaf", true, "1386af66-971f-4d39-aed9-b0b8cfe0d3ba", 160.00m },
                    { "61215266-d4e1-49ab-a51a-38e4c2117d59", new DateTime(2024, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "d0a08a30-f0a9-40ff-a01b-05e04bb62a35", true, "46f107fe-a266-4e0a-8670-1c6050e1e6ef", 345.00m },
                    { "a3187ad6-2dc8-4bea-8f0f-62f9e36d0f28", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "abdf7ffa-2b33-4ca6-b333-238a3216ceaf", true, "d55212aa-2ef6-4b11-ae28-ea7d834841a7", 50.00m },
                    { "ba93964c-3302-4af5-aa40-9c5935c9d42a", new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "d0a08a30-f0a9-40ff-a01b-05e04bb62a35", false, "5ad0f591-9f02-4ccb-8bb6-148cb1159900", 110.00m }
                });

            migrationBuilder.InsertData(
                table: "DoctorInfos",
                columns: new[] { "Id", "Description", "DoctorId", "ExperienceYear", "Img", "Score", "Sector" },
                values: new object[,]
                {
                    { 1, "Dr. Harris ist spezialisiert auf die Behandlung von Erkrankungen der Knochen, Gelenke und Muskeln und hilft Patienten, sich von Verletzungen und Operationen zu erholen. Mit seiner Expertise in der Orthopädie und Rehabilitation bietet er maßgeschneiderte Behandlungspläne, die sowohl konservative Therapieansätze als auch operative Eingriffe umfassen. Dr. Harris behandelt eine Vielzahl von Erkrankungen wie Arthritis, Bandscheibenvorfälle, Knochenbrüche und Sportverletzungen. Durch moderne diagnostische Verfahren und präzise therapeutische Maßnahmen sorgt er dafür, dass Patienten eine schnelle und vollständige Genesung erfahren. Zusätzlich legt er großen Wert auf die Prävention von orthopädischen Problemen und berät seine Patienten zu ergonomischen Praktiken, Sport und Übungen, die die Muskulatur stärken und Verletzungen vorbeugen. Mit einem empathischen Ansatz begleitet er seine Patienten während des gesamten Heilungsprozesses und stellt sicher, dass sie zu einer besseren Lebensqualität zurückkehren.", "d884af72-adc2-4715-81c6-e7fed27d10c1", 20, "https://www.teleclinic.com/wp-content/uploads/teleclinic-hero-slider-1-image-6.webp", 10.0, "Orthopäde" },
                    { 2, "Dr. Smith konzentriert sich auf die Hautpflege und hilft Patienten bei einer Vielzahl von Hauterkrankungen, darunter Akne, Ekzeme und Psoriasis. Mit ihrer langjährigen Erfahrung in der Dermatologie bietet sie sowohl medizinische Behandlungen als auch ästhetische Lösungen an, um das Hautbild ihrer Patienten zu verbessern. Sie verwendet modernste Technologien und Verfahren, um Hautkrankheiten effektiv zu behandeln und das Wohlbefinden ihrer Patienten zu steigern. Dr. Clarke legt großen Wert auf eine individuelle Beratung und maßgeschneiderte Behandlungskonzepte, die den spezifischen Bedürfnissen jedes Patienten gerecht werden. Sie setzt sich zudem für die Prävention von Hautkrebs ein und bietet regelmäßige Hautscreenings zur frühzeitigen Erkennung von Hautveränderungen an. Mit ihrer empathischen und professionellen Art sorgt Dr. Clarke dafür, dass ihre Patienten nicht nur medizinische Hilfe erhalten, sondern sich auch in ihrer Haut wieder wohlfühlen.", "abdf7ffa-2b33-4ca6-b333-238a3216ceaf", 9, "https://www.collinsdictionary.com/images/full/doctor_117169531.jpg", 9.4399999999999995, "Dermatologin" },
                    { 3, "Dr. Johnson ist spezialisiert auf die Behandlung von Kindern und sorgt für deren gesundes Wachstum und Entwicklung. Sie ist bekannt für ihre einfühlsame Betreuung und ihre Fähigkeit, eine vertrauensvolle Verbindung zu jungen Patienten und ihren Familien aufzubauen. Ihr Schwerpunkt liegt auf der Prävention von Krankheiten sowie der Diagnose und Behandlung von kindlichen Gesundheitsproblemen, um eine optimale Entwicklung zu fördern. Dr. Roy setzt sich dafür ein, dass jedes Kind die beste medizinische Versorgung erhält, mit besonderem Augenmerk auf deren emotionales Wohlbefinden während der Behandlung. Sie arbeitet eng mit den Eltern zusammen, um individuelle Gesundheitspläne zu erstellen, die auf die Bedürfnisse jedes einzelnen Kindes abgestimmt sind.", "d0a08a30-f0a9-40ff-a01b-05e04bb62a35", 5, "https://img.freepik.com/fotos-kostenlos/schoene-junge-aerztin-die-kamera-im-buero-betrachtet_1301-7807.jpg", 9.9000000000000004, "Pädiaterin" },
                    { 4, "Dr. Garcia ist ein führender Kardiologe mit umfassender Erfahrung in der Diagnose und Behandlung von Herzkrankheiten. Er hat sich auf die Behandlung von Herzinsuffizienz, koronaren Herzkrankheiten, Bluthochdruck und anderen kardiovaskulären Erkrankungen spezialisiert. Dr. Smith nutzt modernste diagnostische Verfahren wie EKG, Herzultraschall und Belastungstests, um eine präzise Diagnose zu stellen. Er legt großen Wert auf eine ganzheitliche Betreuung seiner Patienten, indem er individuelle Therapiepläne erstellt, die sowohl medikamentöse Behandlungen als auch Änderungen des Lebensstils umfassen. Darüber hinaus engagiert sich Dr. Smith aktiv in der Prävention von Herzkrankheiten und bietet seinen Patienten wertvolle Informationen zur gesunden Ernährung, regelmäßiger Bewegung und Stressbewältigung. Durch seine Expertise und einfühlsame Art hilft er seinen Patienten, ihre Lebensqualität zu verbessern und ihre Herzgesundheit langfristig zu erhalten.", "4b0edccf-5d4f-4dc3-aea2-0dec1c716b83", 17, "https://media.istockphoto.com/id/177373093/photo/indian-male-doctor.jpg?s=612x612&w=0&k=20&c=5FkfKdCYERkAg65cQtdqeO_D0JMv6vrEdPw3mX1Lkfg=", 9.3000000000000007, "Kardiologe" }
                });

            migrationBuilder.InsertData(
                table: "DoctorPatientServices",
                columns: new[] { "DateStart", "DoctorId", "PatientId", "ServiceId", "DateEnd" },
                values: new object[,]
                {
                    { new DateTime(2025, 1, 13, 13, 0, 0, 0, DateTimeKind.Unspecified), "4b0edccf-5d4f-4dc3-aea2-0dec1c716b83", "46f107fe-a266-4e0a-8670-1c6050e1e6ef", 4, new DateTime(2025, 1, 13, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 18, 7, 0, 0, 0, DateTimeKind.Unspecified), "4b0edccf-5d4f-4dc3-aea2-0dec1c716b83", "b4266ce7-ff9e-47de-93c9-be6b91485f2f", 4, new DateTime(2025, 1, 18, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), "abdf7ffa-2b33-4ca6-b333-238a3216ceaf", "5ad0f591-9f02-4ccb-8bb6-148cb1159900", 2, new DateTime(2025, 1, 16, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), "abdf7ffa-2b33-4ca6-b333-238a3216ceaf", "f6a48a77-22fb-4f07-904a-0f4654c395bb", 2, new DateTime(2025, 1, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), "d0a08a30-f0a9-40ff-a01b-05e04bb62a35", "1386af66-971f-4d39-aed9-b0b8cfe0d3ba", 3, new DateTime(2025, 1, 17, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "d0a08a30-f0a9-40ff-a01b-05e04bb62a35", "6c2279c0-c299-43af-87d9-1f8f468132d9", 3, new DateTime(2025, 1, 12, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), "d884af72-adc2-4715-81c6-e7fed27d10c1", "5875217f-bef2-4ffe-bd9d-f62abb7c5151", 1, new DateTime(2025, 1, 10, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), "d884af72-adc2-4715-81c6-e7fed27d10c1", "c53673ae-0e63-4660-b7a8-21877a361300", 1, new DateTime(2025, 1, 15, 16, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "BillServices",
                columns: new[] { "BillId", "ServiceId" },
                values: new object[,]
                {
                    { "465644e0-4cb9-4f20-818e-35a3701967df", 1 },
                    { "49bcf0ca-e41a-44b6-ab4c-fb6005323cf7", 2 },
                    { "61215266-d4e1-49ab-a51a-38e4c2117d59", 6 },
                    { "61215266-d4e1-49ab-a51a-38e4c2117d59", 7 },
                    { "a3187ad6-2dc8-4bea-8f0f-62f9e36d0f28", 5 },
                    { "ba93964c-3302-4af5-aa40-9c5935c9d42a", 3 },
                    { "ba93964c-3302-4af5-aa40-9c5935c9d42a", 4 }
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
                name: "IX_Bills_DoctorId",
                table: "Bills",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_PatientId",
                table: "Bills",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_BillServices_ServiceId",
                table: "BillServices",
                column: "ServiceId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Services_BillId",
                table: "Services",
                column: "BillId");
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
                name: "BillServices");

            migrationBuilder.DropTable(
                name: "DoctorInfos");

            migrationBuilder.DropTable(
                name: "DoctorPatientServices");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Towns");
        }
    }
}
