using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MedicDomusLK.Migrations
{
    /// <inheritdoc />
    public partial class doctorpatientservicesDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DoctorPatientServices",
                table: "DoctorPatientServices");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "DoctorPatientServices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoctorPatientServices",
                table: "DoctorPatientServices",
                columns: new[] { "DoctorId", "PatientId", "ServiceId", "Date" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "335555aa-3095-43fa-8814-a38f7f82fdb0", null, "Doctor", "DOCTOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthdate", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Firstname", "Gender", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Street", "TownId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4400e765-e75d-41ca-a99e-e0b0f007b505", 0, new DateTime(1975, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "0a2f0d56-85ee-4581-94ba-ca05338a7b80", "ApplicationUser", "doctor4@example.com", true, "Michael", null, "Brown", false, null, "DOCTOR4@EXAMPLE.COM", "DOCTOR4@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAvBNLaQXnIb5fKHbaKmk1T0nlxnL3ufoaNslpkX2yHM4W3nGYx9tYBrl6cQdqvvPA==", null, false, "236e2277-18b6-4353-b5b1-c2c8bcf7ee23", "321 Maple Court", 4, false, "doctor4@example.com" },
                    { "45397492-a4b8-4114-88d2-26cd7d598b6d", 0, new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "4a2abe18-d1c6-4553-a2e2-c37c4f4629a3", "ApplicationUser", "doctor5@example.com", true, "Sarah", null, "Davis", false, null, "DOCTOR5@EXAMPLE.COM", "DOCTOR5@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMVM0X8mD8YJERY0x17X/1L14G8mY28/RRSNXpPrhvDcxtxmmzbFeP+XZVtGmm9/NA==", null, false, "dc3dee06-49fd-46a0-8bb1-62551041e6e5", "654 Birch Blvd", 5, false, "doctor5@example.com" },
                    { "4d058864-36b6-4b9b-816d-4268dc6f5a29", 0, new DateTime(1985, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "708917d4-918a-4c2b-944d-53e60e8fde6d", "ApplicationUser", "doctor2@example.com", true, "Jane", null, "Smith", false, null, "DOCTOR2@EXAMPLE.COM", "DOCTOR2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKuyEtN3HieChsVb1K7/QXX3ZVcPkim6itNsxIj1ToFJtkm2yLEdmJ+NUJNQPiDPDA==", null, false, "3fb8ec3d-6433-41d3-b572-746674ed7e23", "456 Oak Avenue", 2, false, "doctor2@example.com" },
                    { "98812fb7-dccf-4d94-a4df-763a19d14de1", 0, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d6f7eb52-d5ae-4d2e-8ec1-4a262d2ac799", "ApplicationUser", "doctor1@example.com", true, "John", null, "Doe", false, null, "DOCTOR1@EXAMPLE.COM", "DOCTOR1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKkYcRpy4jPruuxANSjLERb9PXYV+4Ycy8aXeqJCBrl5MUyafHxurpNg8eMnRFHMxw==", null, false, "95e536c5-51bd-4414-9d24-b2e84e3a920c", "123 Elm Street", 1, false, "doctor1@example.com" },
                    { "e28ab9f3-d2f2-4113-bf21-c384a607bba7", 0, new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "b4c83ee9-8f46-4608-bf31-39717691b7e5", "ApplicationUser", "doctor3@example.com", true, "Emily", null, "Johnson", false, null, "DOCTOR3@EXAMPLE.COM", "DOCTOR3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDhnIW0x+GmelvlAsRXVGcgqqrnjgcrOA9VVxfKujmx4elcU0aG2YZvKPwT6cjKUbA==", null, false, "e3cbf398-07cf-4f69-ad09-d98d96367249", "789 Pine Lane", 3, false, "doctor3@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "335555aa-3095-43fa-8814-a38f7f82fdb0", "4400e765-e75d-41ca-a99e-e0b0f007b505" },
                    { "335555aa-3095-43fa-8814-a38f7f82fdb0", "45397492-a4b8-4114-88d2-26cd7d598b6d" },
                    { "335555aa-3095-43fa-8814-a38f7f82fdb0", "4d058864-36b6-4b9b-816d-4268dc6f5a29" },
                    { "335555aa-3095-43fa-8814-a38f7f82fdb0", "98812fb7-dccf-4d94-a4df-763a19d14de1" },
                    { "335555aa-3095-43fa-8814-a38f7f82fdb0", "e28ab9f3-d2f2-4113-bf21-c384a607bba7" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DoctorPatientServices",
                table: "DoctorPatientServices");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "335555aa-3095-43fa-8814-a38f7f82fdb0", "4400e765-e75d-41ca-a99e-e0b0f007b505" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "335555aa-3095-43fa-8814-a38f7f82fdb0", "45397492-a4b8-4114-88d2-26cd7d598b6d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "335555aa-3095-43fa-8814-a38f7f82fdb0", "4d058864-36b6-4b9b-816d-4268dc6f5a29" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "335555aa-3095-43fa-8814-a38f7f82fdb0", "98812fb7-dccf-4d94-a4df-763a19d14de1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "335555aa-3095-43fa-8814-a38f7f82fdb0", "e28ab9f3-d2f2-4113-bf21-c384a607bba7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "335555aa-3095-43fa-8814-a38f7f82fdb0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4400e765-e75d-41ca-a99e-e0b0f007b505");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45397492-a4b8-4114-88d2-26cd7d598b6d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d058864-36b6-4b9b-816d-4268dc6f5a29");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98812fb7-dccf-4d94-a4df-763a19d14de1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e28ab9f3-d2f2-4113-bf21-c384a607bba7");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "DoctorPatientServices");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoctorPatientServices",
                table: "DoctorPatientServices",
                columns: new[] { "DoctorId", "PatientId", "ServiceId" });
        }
    }
}
