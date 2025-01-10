using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MedicDomusLK.Migrations
{
    /// <inheritdoc />
    public partial class servicesgerman : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "396617d6-7b1a-4e60-a7cc-7edea3568fea", "504c559f-88d6-4ea3-8ff1-abad069f42e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "396617d6-7b1a-4e60-a7cc-7edea3568fea", "a3249c05-0e59-412f-8917-26770d850728" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "396617d6-7b1a-4e60-a7cc-7edea3568fea", "bf2102b7-1c55-4ae6-a977-bf8a9626333a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "396617d6-7b1a-4e60-a7cc-7edea3568fea", "cab6d27a-1fba-45a6-9e92-f151fb97453e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "396617d6-7b1a-4e60-a7cc-7edea3568fea", "f0e9583b-49ce-49ce-bb8d-a009d6f4519f" });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "Date", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), "504c559f-88d6-4ea3-8ff1-abad069f42e4", "66fb32e6-d95a-4a79-a247-053212b2373b", 3 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "Date", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "504c559f-88d6-4ea3-8ff1-abad069f42e4", "c85b1ad1-ba3e-436c-93cc-0b0d430ce18c", 3 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "Date", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), "a3249c05-0e59-412f-8917-26770d850728", "52b8e3a8-ee7b-41e8-934e-4f1239d7ae6c", 2 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "Date", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), "a3249c05-0e59-412f-8917-26770d850728", "9ecdeeb6-f820-4db6-8758-d9af8fef213e", 2 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "Date", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), "bf2102b7-1c55-4ae6-a977-bf8a9626333a", "0b890ef6-8874-4cd2-8b33-8b6f9e4a8db3", 1 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "Date", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), "bf2102b7-1c55-4ae6-a977-bf8a9626333a", "5e25a06c-94d3-446e-8cdc-a43409d1959e", 1 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "Date", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 18, 7, 0, 0, 0, DateTimeKind.Unspecified), "cab6d27a-1fba-45a6-9e92-f151fb97453e", "65c70f8b-3d45-4d3d-b700-28aaf53b0827", 4 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "Date", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 13, 13, 0, 0, 0, DateTimeKind.Unspecified), "cab6d27a-1fba-45a6-9e92-f151fb97453e", "6bc325f1-b0bf-4372-a913-53b4908dec39", 4 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "Date", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), "f0e9583b-49ce-49ce-bb8d-a009d6f4519f", "ae680932-d02c-42cc-a2f3-ed5619892bb7", 5 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "Date", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 14, 9, 0, 0, 0, DateTimeKind.Unspecified), "f0e9583b-49ce-49ce-bb8d-a009d6f4519f", "c753620d-c230-4db2-a07c-43c162e23016", 5 });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "396617d6-7b1a-4e60-a7cc-7edea3568fea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b890ef6-8874-4cd2-8b33-8b6f9e4a8db3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "504c559f-88d6-4ea3-8ff1-abad069f42e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52b8e3a8-ee7b-41e8-934e-4f1239d7ae6c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e25a06c-94d3-446e-8cdc-a43409d1959e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65c70f8b-3d45-4d3d-b700-28aaf53b0827");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66fb32e6-d95a-4a79-a247-053212b2373b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bc325f1-b0bf-4372-a913-53b4908dec39");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ecdeeb6-f820-4db6-8758-d9af8fef213e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3249c05-0e59-412f-8917-26770d850728");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae680932-d02c-42cc-a2f3-ed5619892bb7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf2102b7-1c55-4ae6-a977-bf8a9626333a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c753620d-c230-4db2-a07c-43c162e23016");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c85b1ad1-ba3e-436c-93cc-0b0d430ce18c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cab6d27a-1fba-45a6-9e92-f151fb97453e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0e9583b-49ce-49ce-bb8d-a009d6f4519f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ace44016-76e9-477b-86ba-b5fe840208da", null, "Doctor", "DOCTOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthdate", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Firstname", "Gender", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Street", "TownId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1d7bcb47-7b1c-475a-9424-8e8d814fe15b", 0, new DateTime(1988, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "e90148b2-c674-41af-b0ae-df1100746648", "ApplicationUser", "david.brown@example.com", false, "David", 1, "Brown", false, null, "DAVID.BROWN@EXAMPLE.COM", "DAVID.BROWN", "AQAAAAIAAYagAAAAELOLp38XaJ5WvqCWnsPbCZoAzpTCU3apbBOujj89E+fVV/uc6Eg0BUehXmU92TsjGw==", null, false, "f6c84ab9-7f72-4fe2-826a-2351e805b4f1", "Fourth Street 78", 4, false, "david.brown" },
                    { "23af7e15-f296-44e8-82fa-017f78dfca7c", 0, new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "e088ce7d-0f3e-4535-9d0a-cb14192254a9", "ApplicationUser", "doctor3@example.com", true, "Emily", null, "Johnson", false, null, "DOCTOR3@EXAMPLE.COM", "DOCTOR3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBTZb/xSSyeCietP3YPTyvyCDlX7KPiD/6VTJZeyoGT4KSqkMPg0wkxiaphVpvMdKg==", null, false, "b83848ce-adeb-4d60-ba16-fd493200243d", "789 Pine Lane", 3, false, "doctor3@example.com" },
                    { "4050126e-9593-4fa9-922b-2f10504879b6", 0, new DateTime(1991, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "091f7119-769b-49f2-943a-80cb06bc19fb", "ApplicationUser", "grace.martinez@example.com", false, "Grace", 0, "Martinez", false, null, "GRACE.MARTINEZ@EXAMPLE.COM", "GRACE.MARTINEZ", "AQAAAAIAAYagAAAAEEbJOxO7O/A1o6DY0CYM2VnWddXvN7JnuaSEDnSI88TQVy3Mw/6dBtJHQFGs2mL51w==", null, false, "c5bbdc90-1a97-4c3e-85cb-1bc03374a458", "Seventh Street 11", 7, false, "grace.martinez" },
                    { "48f623ae-3e82-44d8-8dc5-1c89b1901009", 0, new DateTime(1975, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "9c006527-296a-4900-afaf-6637d61e8248", "ApplicationUser", "doctor4@example.com", true, "Michael", null, "Brown", false, null, "DOCTOR4@EXAMPLE.COM", "DOCTOR4@EXAMPLE.COM", "AQAAAAIAAYagAAAAEI4JIHd0Wcsqn1ppvugHQPN61jvnX8xl2e0FEOWMtiymNvCpNiIHA9GUnryRONTtIw==", null, false, "272defc6-bfec-4417-8c52-b00d08301ad4", "321 Maple Court", 4, false, "doctor4@example.com" },
                    { "5d677e2b-3248-4911-8177-b1f6054050ae", 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3c7d65c4-1a00-4eeb-9d5d-93c06d19ad8f", "ApplicationUser", "alice.smith@example.com", false, "Alice", 0, "Smith", false, null, "ALICE.SMITH@EXAMPLE.COM", "ALICE.SMITH", "AQAAAAIAAYagAAAAECZBnVrXXCgJkdVTyKgv3KuuBRNsbujCSJoPQIL6yTOnFzcb36m+m+X8GkeBe59rqQ==", null, false, "01f11343-9569-4173-875b-c24003acb0b7", "Main Street 1", 1, false, "alice.smith" },
                    { "8754c483-cab7-4e62-a9ed-88f7aad95022", 0, new DateTime(1994, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "92d5a2a4-e041-4a7d-b312-b6f58d05f973", "ApplicationUser", "jack.hernandez@example.com", false, "Jack", 1, "Hernandez", false, null, "JACK.HERNANDEZ@EXAMPLE.COM", "JACK.HERNANDEZ", "AQAAAAIAAYagAAAAEAbPQJAOEE3aXe97b/Qv5XF26M45fcVg4Oxfd45SzGL8W4G4xptCC9j/WtPdwc8TMA==", null, false, "f6e111a1-ada6-4ecb-addc-11f6f20dda1c", "Tenth Boulevard 89", 10, false, "jack.hernandez" },
                    { "8e455d2a-f8c2-4fe9-9d09-2109cd378dd2", 0, new DateTime(1996, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "be32ead3-0747-4194-8702-25f85846a89d", "ApplicationUser", "isabella.lee@example.com", false, "Isabella", 0, "Lee", false, null, "ISABELLA.LEE@EXAMPLE.COM", "ISABELLA.LEE", "AQAAAAIAAYagAAAAEDx1PnQD00tbSlo3mdpateH6voaucnIvaUi00qw05piDuiydLErEHYwvhFZF6PT8+w==", null, false, "134d59f9-3949-4ddd-90b9-abe0f02a2a51", "Ninth Street 67", 9, false, "isabella.lee" },
                    { "96978a57-0fb6-4b41-b27c-52c8520953ef", 0, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4a9c7fc9-1b63-4d74-8079-11e6bf0059e7", "ApplicationUser", "doctor1@example.com", true, "John", null, "Doe", false, null, "DOCTOR1@EXAMPLE.COM", "DOCTOR1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEONEoBKm0wmpFS92d6Mv0Fq7Ui1ZIvYOFmkDc+L7SGxltIwuIJxsQvDieueIkNIv9g==", null, false, "b3c2d10c-a3c1-4016-9c40-86f6973c2af3", "123 Elm Street", 1, false, "doctor1@example.com" },
                    { "970d5551-7706-4054-92f3-7df5ae0b718b", 0, new DateTime(1987, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "cc3377fd-c140-422b-b18f-2c16b0489f49", "ApplicationUser", "henry.rodriguez@example.com", false, "Henry", 1, "Rodriguez", false, null, "HENRY.RODRIGUEZ@EXAMPLE.COM", "HENRY.RODRIGUEZ", "AQAAAAIAAYagAAAAEH00BCNIlQ/+U0YptNkuYbFqfIwJKdGSC/N2sMI4IDWGfBFFmseJ6tMjvD1qnOFT7Q==", null, false, "e450d40c-c5d9-4aeb-bb3e-95ca201ac00e", "Eighth Avenue 56", 8, false, "henry.rodriguez" },
                    { "9e3de4a1-3248-4254-859d-ad1b709f5460", 0, new DateTime(1992, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ec1694bf-6a88-4c72-9223-f0b9499c0ab0", "ApplicationUser", "cathy.williams@example.com", false, "Cathy", 0, "Williams", false, null, "CATHY.WILLIAMS@EXAMPLE.COM", "CATHY.WILLIAMS", "AQAAAAIAAYagAAAAEL4QgmZs4QFto9DrfSZ2D4B5hHeYuwJZ2Xg5hm61ymVpf5cM5oFxs/D/9IMXGRUYmA==", null, false, "c5759917-ceb3-4525-a6dd-030e3eb9af2d", "Third Lane 5", 3, false, "cathy.williams" },
                    { "a2dab488-98db-4988-a381-3a7a4c41dbb2", 0, new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "45f51450-b567-4cb8-8001-8b9bd2b9b519", "ApplicationUser", "doctor5@example.com", true, "Sarah", null, "Davis", false, null, "DOCTOR5@EXAMPLE.COM", "DOCTOR5@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOMFjnaHS0jdRCr4SR+Am9RMKwP0CHCXujtxsVzG+SIRo4+4ASVAlfTFHoDZ1dPf3w==", null, false, "5aa2459a-3159-4f12-8ee2-f0c5e15ccb56", "654 Birch Blvd", 5, false, "doctor5@example.com" },
                    { "b1da66cd-8bbc-4b2e-87be-acc13ab00fb0", 0, new DateTime(1985, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "b9b496df-b6a6-4d6d-8367-0a76c2feccf9", "ApplicationUser", "doctor2@example.com", true, "Jane", null, "Smith", false, null, "DOCTOR2@EXAMPLE.COM", "DOCTOR2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBNScJXyCTWlv63N8gcDEPW+gE8w8DXV58UUQZZVqlSCzp07XygsG4hWm4grTJR3BA==", null, false, "2464a707-b4f5-44e7-b8fd-f05b2b26b2f7", "456 Oak Avenue", 2, false, "doctor2@example.com" },
                    { "b4ac5b92-0190-4998-8fe9-3cbe434056b2", 0, new DateTime(1993, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "f6bd1860-dbed-43c0-9fa1-bc86f9e6d9b0", "ApplicationUser", "frank.garcia@example.com", false, "Frank", 1, "Garcia", false, null, "FRANK.GARCIA@EXAMPLE.COM", "FRANK.GARCIA", "AQAAAAIAAYagAAAAEEWbyE32tDOSnQH5pWe3t8LnKspxPHJVEpchfiyBdZ3HIOoHqz384Fjx/dC3ehtrrA==", null, false, "97659939-17d3-4e02-9955-bb8775374b74", "Sixth Road 23", 6, false, "frank.garcia" },
                    { "d3b34728-f7a1-4c9d-bfa7-7eb6ba3a15e1", 0, new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "6d38a8c2-1b65-4f6a-8610-49cf4db1e5a8", "ApplicationUser", "bob.johnson@example.com", false, "Bob", 1, "Johnson", false, null, "BOB.JOHNSON@EXAMPLE.COM", "BOB.JOHNSON", "AQAAAAIAAYagAAAAENfCaijsj4/vshXL1o9tzjrSgyk0p1J8R7w/vSJqHXd1aOYtzO39OVIESsqMNuReig==", null, false, "5582aedd-e0c6-4ee8-99e0-1f965c8bf73c", "Second Avenue 34", 2, false, "bob.johnson" },
                    { "eacd75aa-a911-486b-9516-019486fdcffd", 0, new DateTime(1995, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "e6693962-6a3f-456b-b383-bd7e6c9d9643", "ApplicationUser", "ella.jones@example.com", false, "Ella", 0, "Jones", false, null, "ELLA.JONES@EXAMPLE.COM", "ELLA.JONES", "AQAAAAIAAYagAAAAEORIpnyvWWi1UH5Kom1XCX4E34Z9P+lYGEhvWmleIS503FlHbghSGs1LFPSkmw8N+A==", null, false, "30a311fa-1246-4a6a-b4ec-4ea9ba5a3591", "Fifth Avenue 9", 5, false, "ella.jones" }
                });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Allgemeine Untersuchung");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Kinderuntersuchung");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Impfung");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Bluttest");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Physiotherapiesitzung");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Spezialistenberatung");

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 7, "Röntgenuntersuchung", 160.00m },
                    { 8, "EKG", 200.00m },
                    { 9, "Ultraschalluntersuchung", 220.00m },
                    { 10, "Hörtest", 30.00m },
                    { 11, "Krebsvorsorgeuntersuchung", 60.00m },
                    { 12, "Schlafdiagnostik ", 50.00m }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ace44016-76e9-477b-86ba-b5fe840208da", "23af7e15-f296-44e8-82fa-017f78dfca7c" },
                    { "ace44016-76e9-477b-86ba-b5fe840208da", "48f623ae-3e82-44d8-8dc5-1c89b1901009" },
                    { "ace44016-76e9-477b-86ba-b5fe840208da", "96978a57-0fb6-4b41-b27c-52c8520953ef" },
                    { "ace44016-76e9-477b-86ba-b5fe840208da", "a2dab488-98db-4988-a381-3a7a4c41dbb2" },
                    { "ace44016-76e9-477b-86ba-b5fe840208da", "b1da66cd-8bbc-4b2e-87be-acc13ab00fb0" }
                });

            migrationBuilder.InsertData(
                table: "DoctorPatientServices",
                columns: new[] { "Date", "DoctorId", "PatientId", "ServiceId" },
                values: new object[,]
                {
                    { new DateTime(2025, 1, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), "23af7e15-f296-44e8-82fa-017f78dfca7c", "970d5551-7706-4054-92f3-7df5ae0b718b", 3 },
                    { new DateTime(2025, 1, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "23af7e15-f296-44e8-82fa-017f78dfca7c", "9e3de4a1-3248-4254-859d-ad1b709f5460", 3 },
                    { new DateTime(2025, 1, 13, 13, 0, 0, 0, DateTimeKind.Unspecified), "48f623ae-3e82-44d8-8dc5-1c89b1901009", "1d7bcb47-7b1c-475a-9424-8e8d814fe15b", 4 },
                    { new DateTime(2025, 1, 18, 7, 0, 0, 0, DateTimeKind.Unspecified), "48f623ae-3e82-44d8-8dc5-1c89b1901009", "8e455d2a-f8c2-4fe9-9d09-2109cd378dd2", 4 },
                    { new DateTime(2025, 1, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), "96978a57-0fb6-4b41-b27c-52c8520953ef", "5d677e2b-3248-4911-8177-b1f6054050ae", 1 },
                    { new DateTime(2025, 1, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), "96978a57-0fb6-4b41-b27c-52c8520953ef", "b4ac5b92-0190-4998-8fe9-3cbe434056b2", 1 },
                    { new DateTime(2025, 1, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), "a2dab488-98db-4988-a381-3a7a4c41dbb2", "8754c483-cab7-4e62-a9ed-88f7aad95022", 5 },
                    { new DateTime(2025, 1, 14, 9, 0, 0, 0, DateTimeKind.Unspecified), "a2dab488-98db-4988-a381-3a7a4c41dbb2", "eacd75aa-a911-486b-9516-019486fdcffd", 5 },
                    { new DateTime(2025, 1, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), "b1da66cd-8bbc-4b2e-87be-acc13ab00fb0", "4050126e-9593-4fa9-922b-2f10504879b6", 2 },
                    { new DateTime(2025, 1, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), "b1da66cd-8bbc-4b2e-87be-acc13ab00fb0", "d3b34728-f7a1-4c9d-bfa7-7eb6ba3a15e1", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ace44016-76e9-477b-86ba-b5fe840208da", "23af7e15-f296-44e8-82fa-017f78dfca7c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ace44016-76e9-477b-86ba-b5fe840208da", "48f623ae-3e82-44d8-8dc5-1c89b1901009" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ace44016-76e9-477b-86ba-b5fe840208da", "96978a57-0fb6-4b41-b27c-52c8520953ef" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ace44016-76e9-477b-86ba-b5fe840208da", "a2dab488-98db-4988-a381-3a7a4c41dbb2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ace44016-76e9-477b-86ba-b5fe840208da", "b1da66cd-8bbc-4b2e-87be-acc13ab00fb0" });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "Date", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), "23af7e15-f296-44e8-82fa-017f78dfca7c", "970d5551-7706-4054-92f3-7df5ae0b718b", 3 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "Date", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "23af7e15-f296-44e8-82fa-017f78dfca7c", "9e3de4a1-3248-4254-859d-ad1b709f5460", 3 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "Date", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 13, 13, 0, 0, 0, DateTimeKind.Unspecified), "48f623ae-3e82-44d8-8dc5-1c89b1901009", "1d7bcb47-7b1c-475a-9424-8e8d814fe15b", 4 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "Date", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 18, 7, 0, 0, 0, DateTimeKind.Unspecified), "48f623ae-3e82-44d8-8dc5-1c89b1901009", "8e455d2a-f8c2-4fe9-9d09-2109cd378dd2", 4 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "Date", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), "96978a57-0fb6-4b41-b27c-52c8520953ef", "5d677e2b-3248-4911-8177-b1f6054050ae", 1 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "Date", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), "96978a57-0fb6-4b41-b27c-52c8520953ef", "b4ac5b92-0190-4998-8fe9-3cbe434056b2", 1 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "Date", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), "a2dab488-98db-4988-a381-3a7a4c41dbb2", "8754c483-cab7-4e62-a9ed-88f7aad95022", 5 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "Date", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 14, 9, 0, 0, 0, DateTimeKind.Unspecified), "a2dab488-98db-4988-a381-3a7a4c41dbb2", "eacd75aa-a911-486b-9516-019486fdcffd", 5 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "Date", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), "b1da66cd-8bbc-4b2e-87be-acc13ab00fb0", "4050126e-9593-4fa9-922b-2f10504879b6", 2 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "Date", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), "b1da66cd-8bbc-4b2e-87be-acc13ab00fb0", "d3b34728-f7a1-4c9d-bfa7-7eb6ba3a15e1", 2 });

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ace44016-76e9-477b-86ba-b5fe840208da");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d7bcb47-7b1c-475a-9424-8e8d814fe15b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23af7e15-f296-44e8-82fa-017f78dfca7c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4050126e-9593-4fa9-922b-2f10504879b6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48f623ae-3e82-44d8-8dc5-1c89b1901009");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d677e2b-3248-4911-8177-b1f6054050ae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8754c483-cab7-4e62-a9ed-88f7aad95022");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e455d2a-f8c2-4fe9-9d09-2109cd378dd2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96978a57-0fb6-4b41-b27c-52c8520953ef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "970d5551-7706-4054-92f3-7df5ae0b718b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e3de4a1-3248-4254-859d-ad1b709f5460");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2dab488-98db-4988-a381-3a7a4c41dbb2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1da66cd-8bbc-4b2e-87be-acc13ab00fb0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4ac5b92-0190-4998-8fe9-3cbe434056b2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d3b34728-f7a1-4c9d-bfa7-7eb6ba3a15e1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eacd75aa-a911-486b-9516-019486fdcffd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "396617d6-7b1a-4e60-a7cc-7edea3568fea", null, "Doctor", "DOCTOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthdate", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Firstname", "Gender", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Street", "TownId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0b890ef6-8874-4cd2-8b33-8b6f9e4a8db3", 0, new DateTime(1993, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "44f63215-a8a7-401f-b185-8b31f2c86616", "ApplicationUser", "frank.garcia@example.com", false, "Frank", 1, "Garcia", false, null, "FRANK.GARCIA@EXAMPLE.COM", "FRANK.GARCIA", "AQAAAAIAAYagAAAAEFiO7u40pxCpYFGDNTrWPPWFArRZJAkmFyzzWUgtdM2VldU+CZjXn2C3c+DoToeykQ==", null, false, "dc3967c3-3fa7-4ccc-85e9-d8cd96aa3735", "Sixth Road 23", 6, false, "frank.garcia" },
                    { "504c559f-88d6-4ea3-8ff1-abad069f42e4", 0, new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "b9b942e4-1fbf-4bf5-a3da-86edcca4b7dc", "ApplicationUser", "doctor3@example.com", true, "Emily", null, "Johnson", false, null, "DOCTOR3@EXAMPLE.COM", "DOCTOR3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAzLjFiowdgE74voCIbfAMaSON3d4OkE5Cw+GiNpi8XprYn4ym1CNzLrN0vNT5GZig==", null, false, "f4b44907-bec3-49c6-9c31-313a7d88e799", "789 Pine Lane", 3, false, "doctor3@example.com" },
                    { "52b8e3a8-ee7b-41e8-934e-4f1239d7ae6c", 0, new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "1dc5ff28-6726-4e38-a44c-315be57a0de6", "ApplicationUser", "bob.johnson@example.com", false, "Bob", 1, "Johnson", false, null, "BOB.JOHNSON@EXAMPLE.COM", "BOB.JOHNSON", "AQAAAAIAAYagAAAAENFxaX266MGHpg6iWSIGS1FdzHxx4QdYxnq2qsWeOreGKc7I5UqCOPY1FVB/M4Lw4g==", null, false, "603816dd-c4db-44e8-8efb-87e678e2ac7e", "Second Avenue 34", 2, false, "bob.johnson" },
                    { "5e25a06c-94d3-446e-8cdc-a43409d1959e", 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "434e400c-f808-4813-b947-2989ab9000b8", "ApplicationUser", "alice.smith@example.com", false, "Alice", 0, "Smith", false, null, "ALICE.SMITH@EXAMPLE.COM", "ALICE.SMITH", "AQAAAAIAAYagAAAAEPFs/+IpMl2zxaq3h1bN1V3+fXwotvpyBwrOmUTftR6I0UL6R4a/s9ecryzYMuIqHw==", null, false, "9fd8724c-ff22-4815-b58b-8640adb8d134", "Main Street 1", 1, false, "alice.smith" },
                    { "65c70f8b-3d45-4d3d-b700-28aaf53b0827", 0, new DateTime(1996, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ebeec2be-4ad5-4c28-9e7b-f3b739e305ca", "ApplicationUser", "isabella.lee@example.com", false, "Isabella", 0, "Lee", false, null, "ISABELLA.LEE@EXAMPLE.COM", "ISABELLA.LEE", "AQAAAAIAAYagAAAAEDdJmnQGLN9aew/dPKJBpmGiCJrv6gny4yfskc3tch64LvHEWMwqdNMoOSY0vHhaFw==", null, false, "19e4484e-2515-48a1-9c28-52e9c5ed91bd", "Ninth Street 67", 9, false, "isabella.lee" },
                    { "66fb32e6-d95a-4a79-a247-053212b2373b", 0, new DateTime(1987, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "23b7e87d-6cdf-4355-8ab8-b774ad9137a9", "ApplicationUser", "henry.rodriguez@example.com", false, "Henry", 1, "Rodriguez", false, null, "HENRY.RODRIGUEZ@EXAMPLE.COM", "HENRY.RODRIGUEZ", "AQAAAAIAAYagAAAAEDZDeLM3bXq/OEksM7PWPLF5d6HIYN9npujLP4mHD4vVyeYDjLIgw/zIuUhqW226hg==", null, false, "fae7e2df-d0b4-404d-a421-1cacd170f8f7", "Eighth Avenue 56", 8, false, "henry.rodriguez" },
                    { "6bc325f1-b0bf-4372-a913-53b4908dec39", 0, new DateTime(1988, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "e63d7afc-0f70-40d0-8aef-c20e4948e32c", "ApplicationUser", "david.brown@example.com", false, "David", 1, "Brown", false, null, "DAVID.BROWN@EXAMPLE.COM", "DAVID.BROWN", "AQAAAAIAAYagAAAAEMq/fMqhtrAZN+fxKVqmUrMcwV0W/Sx0/JxvMBmvZOS6R/S4gQhs8ZGntIoWrjzgCg==", null, false, "54811621-3afb-49bb-8c90-b358fefa3a03", "Fourth Street 78", 4, false, "david.brown" },
                    { "9ecdeeb6-f820-4db6-8758-d9af8fef213e", 0, new DateTime(1991, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "a50d510c-32f4-4326-9c05-995893f1a6c1", "ApplicationUser", "grace.martinez@example.com", false, "Grace", 0, "Martinez", false, null, "GRACE.MARTINEZ@EXAMPLE.COM", "GRACE.MARTINEZ", "AQAAAAIAAYagAAAAEOr0M/owerK6V8HQw1gl/DDvhsgzC+oLQ0PQw5oLyJSbRnWLxdSeARchH0p1LVmYrQ==", null, false, "8a769ee4-796d-40bc-bd0f-35427f206fef", "Seventh Street 11", 7, false, "grace.martinez" },
                    { "a3249c05-0e59-412f-8917-26770d850728", 0, new DateTime(1985, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "689064ce-7469-4e05-a047-6682198408f0", "ApplicationUser", "doctor2@example.com", true, "Jane", null, "Smith", false, null, "DOCTOR2@EXAMPLE.COM", "DOCTOR2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBvHzB9U5Up3QUTW2xsPPaa2owda2D+K1e8XsVk7ar+0HWAW1YxFHKamvEpeqG9rQQ==", null, false, "aff9bdad-dcfe-43e6-a2f8-114f4bad65c5", "456 Oak Avenue", 2, false, "doctor2@example.com" },
                    { "ae680932-d02c-42cc-a2f3-ed5619892bb7", 0, new DateTime(1994, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "f5239928-2a81-48e6-a82d-ee939dbd978d", "ApplicationUser", "jack.hernandez@example.com", false, "Jack", 1, "Hernandez", false, null, "JACK.HERNANDEZ@EXAMPLE.COM", "JACK.HERNANDEZ", "AQAAAAIAAYagAAAAENjdqsBZYOJdoJ3kk3JSEw4mvCZKDmNaqLNW2SYIt2KVchcmUZy2fhCE1iHsdAotNQ==", null, false, "f50b83dd-ea5f-4a50-a649-ad4e0c9e737f", "Tenth Boulevard 89", 10, false, "jack.hernandez" },
                    { "bf2102b7-1c55-4ae6-a977-bf8a9626333a", 0, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8285df37-e5fd-4135-9e93-0cb1deee2d59", "ApplicationUser", "doctor1@example.com", true, "John", null, "Doe", false, null, "DOCTOR1@EXAMPLE.COM", "DOCTOR1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKi8j62XhommgDTGk9LF73DZ1DUwzXqI4r8zUBuvmc6mag/N6GrtoEb13W8O2COfAQ==", null, false, "fdcc8f8c-8ecf-4716-bb41-3b34bc0c4939", "123 Elm Street", 1, false, "doctor1@example.com" },
                    { "c753620d-c230-4db2-a07c-43c162e23016", 0, new DateTime(1995, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "569fc982-d67d-47e4-8b41-284c52f428ee", "ApplicationUser", "ella.jones@example.com", false, "Ella", 0, "Jones", false, null, "ELLA.JONES@EXAMPLE.COM", "ELLA.JONES", "AQAAAAIAAYagAAAAEMt0TU7oVffMxxpbvSLMpoiCkAVkjKHx1S09nKToqn7V8cJv0XQ41kZOw7vJfJrk5g==", null, false, "1ce341be-110f-4ee1-96ef-fe0d1f2e1991", "Fifth Avenue 9", 5, false, "ella.jones" },
                    { "c85b1ad1-ba3e-436c-93cc-0b0d430ce18c", 0, new DateTime(1992, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "a3dc393e-81a0-4992-ad02-24db4c3265af", "ApplicationUser", "cathy.williams@example.com", false, "Cathy", 0, "Williams", false, null, "CATHY.WILLIAMS@EXAMPLE.COM", "CATHY.WILLIAMS", "AQAAAAIAAYagAAAAEOnYnbWm9dQQQbdJwMfnzdBPX2J92L98xd/eVaH1n02hT6uuCo6rgVItJFmjs2bdyw==", null, false, "d5042cb0-4494-4e63-ab1f-ee8c32e897f0", "Third Lane 5", 3, false, "cathy.williams" },
                    { "cab6d27a-1fba-45a6-9e92-f151fb97453e", 0, new DateTime(1975, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "583d899b-97a8-448e-b3c0-ad87bc16ae20", "ApplicationUser", "doctor4@example.com", true, "Michael", null, "Brown", false, null, "DOCTOR4@EXAMPLE.COM", "DOCTOR4@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJoUxDzb/KOI7+eed8gYaiFBK7b0Op4vAAFOJbQU3i24duF6/6ujcxhHYK50RELTUA==", null, false, "62fb4743-c26b-465e-ad7c-d8c7963dc69c", "321 Maple Court", 4, false, "doctor4@example.com" },
                    { "f0e9583b-49ce-49ce-bb8d-a009d6f4519f", 0, new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "dc2f3ce3-4c00-418c-897b-c712b8fe17e8", "ApplicationUser", "doctor5@example.com", true, "Sarah", null, "Davis", false, null, "DOCTOR5@EXAMPLE.COM", "DOCTOR5@EXAMPLE.COM", "AQAAAAIAAYagAAAAENjlTpz4kLWbraFboqZxGk3EWSSs25wtd4xMXG0J3LaOhWn0LS0aIQ8J7WMEijnxgg==", null, false, "e9a8fd9e-37a6-4d48-9f2f-d8a52c34fae6", "654 Birch Blvd", 5, false, "doctor5@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "General Consultation");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Pediatric Check-Up");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Vaccination");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Blood Test");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Physical Therapy Session");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Specialist Consultation");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "396617d6-7b1a-4e60-a7cc-7edea3568fea", "504c559f-88d6-4ea3-8ff1-abad069f42e4" },
                    { "396617d6-7b1a-4e60-a7cc-7edea3568fea", "a3249c05-0e59-412f-8917-26770d850728" },
                    { "396617d6-7b1a-4e60-a7cc-7edea3568fea", "bf2102b7-1c55-4ae6-a977-bf8a9626333a" },
                    { "396617d6-7b1a-4e60-a7cc-7edea3568fea", "cab6d27a-1fba-45a6-9e92-f151fb97453e" },
                    { "396617d6-7b1a-4e60-a7cc-7edea3568fea", "f0e9583b-49ce-49ce-bb8d-a009d6f4519f" }
                });

            migrationBuilder.InsertData(
                table: "DoctorPatientServices",
                columns: new[] { "Date", "DoctorId", "PatientId", "ServiceId" },
                values: new object[,]
                {
                    { new DateTime(2025, 1, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), "504c559f-88d6-4ea3-8ff1-abad069f42e4", "66fb32e6-d95a-4a79-a247-053212b2373b", 3 },
                    { new DateTime(2025, 1, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "504c559f-88d6-4ea3-8ff1-abad069f42e4", "c85b1ad1-ba3e-436c-93cc-0b0d430ce18c", 3 },
                    { new DateTime(2025, 1, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), "a3249c05-0e59-412f-8917-26770d850728", "52b8e3a8-ee7b-41e8-934e-4f1239d7ae6c", 2 },
                    { new DateTime(2025, 1, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), "a3249c05-0e59-412f-8917-26770d850728", "9ecdeeb6-f820-4db6-8758-d9af8fef213e", 2 },
                    { new DateTime(2025, 1, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), "bf2102b7-1c55-4ae6-a977-bf8a9626333a", "0b890ef6-8874-4cd2-8b33-8b6f9e4a8db3", 1 },
                    { new DateTime(2025, 1, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), "bf2102b7-1c55-4ae6-a977-bf8a9626333a", "5e25a06c-94d3-446e-8cdc-a43409d1959e", 1 },
                    { new DateTime(2025, 1, 18, 7, 0, 0, 0, DateTimeKind.Unspecified), "cab6d27a-1fba-45a6-9e92-f151fb97453e", "65c70f8b-3d45-4d3d-b700-28aaf53b0827", 4 },
                    { new DateTime(2025, 1, 13, 13, 0, 0, 0, DateTimeKind.Unspecified), "cab6d27a-1fba-45a6-9e92-f151fb97453e", "6bc325f1-b0bf-4372-a913-53b4908dec39", 4 },
                    { new DateTime(2025, 1, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), "f0e9583b-49ce-49ce-bb8d-a009d6f4519f", "ae680932-d02c-42cc-a2f3-ed5619892bb7", 5 },
                    { new DateTime(2025, 1, 14, 9, 0, 0, 0, DateTimeKind.Unspecified), "f0e9583b-49ce-49ce-bb8d-a009d6f4519f", "c753620d-c230-4db2-a07c-43c162e23016", 5 }
                });
        }
    }
}
