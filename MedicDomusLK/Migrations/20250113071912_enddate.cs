using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MedicDomusLK.Migrations
{
    /// <inheritdoc />
    public partial class enddate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DoctorPatientServices",
                table: "DoctorPatientServices");

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

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "DoctorPatientServices",
                newName: "DateEnd");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateStart",
                table: "DoctorPatientServices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoctorPatientServices",
                table: "DoctorPatientServices",
                columns: new[] { "DoctorId", "PatientId", "ServiceId", "DateStart" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5b636c5d-47b7-4b58-9428-e8fa35cab56c", null, "Doctor", "DOCTOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthdate", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Firstname", "Gender", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Street", "TownId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "40b52a9a-5ab8-47b2-808c-7ab8244e5cb4", 0, new DateTime(1987, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "8c2f09e3-c588-4fb1-ab76-698a69401454", "ApplicationUser", "henry.rodriguez@example.com", false, "Henry", 1, "Rodriguez", false, null, "HENRY.RODRIGUEZ@EXAMPLE.COM", "HENRY.RODRIGUEZ", "AQAAAAIAAYagAAAAEH174RHmfttWX8n4XKaAKXSFbltd+TBfQ0NHPHiRIar0OaK5sdgYuif+b0ALCHCp4g==", null, false, "0671b7af-6be5-4974-9b32-e69f7bfd9368", "Eighth Avenue 56", 8, false, "henry.rodriguez" },
                    { "41afaf33-b1f7-4b03-bc86-e272906487f7", 0, new DateTime(1996, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "d10ecc58-d34d-4162-9bc6-031ef21ee9e7", "ApplicationUser", "isabella.lee@example.com", false, "Isabella", 0, "Lee", false, null, "ISABELLA.LEE@EXAMPLE.COM", "ISABELLA.LEE", "AQAAAAIAAYagAAAAEByLa7ycU4LGUjwa6LxpOGpdS/n/rMAnCDudytBnE8liWQDLZfdpIalHTe0Hxu4CVQ==", null, false, "a3fcdf21-f666-49fe-bff4-2f1e337ee971", "Ninth Street 67", 9, false, "isabella.lee" },
                    { "4a3291ef-8a09-4b97-9b72-608bf9f811da", 0, new DateTime(1988, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "6dcce120-f7b7-44da-84b1-b690dc7038b1", "ApplicationUser", "david.brown@example.com", false, "David", 1, "Brown", false, null, "DAVID.BROWN@EXAMPLE.COM", "DAVID.BROWN", "AQAAAAIAAYagAAAAEIk9mrZcoNUwj1xabhY8sm/+/wWKnnaK68w6YgUot3cxk54J/RoMKEFJz+av8UCAPw==", null, false, "8109e44c-b926-4868-9956-40617d0e52c8", "Fourth Street 78", 4, false, "david.brown" },
                    { "51b3247a-034d-4fee-bd48-7643609fe486", 0, new DateTime(1975, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "be71f956-1053-4fcd-b287-d0d171bab19f", "ApplicationUser", "doctor4@example.com", true, "Michael", null, "Brown", false, null, "DOCTOR4@EXAMPLE.COM", "DOCTOR4@EXAMPLE.COM", "AQAAAAIAAYagAAAAELy3ysMDDvmrhhlt8oR0jH+IaWQ4Ni0r6cd6hHYXwE9CL1VkzvYFtvXwr4GJeP531w==", null, false, "c512be35-93a0-4b67-9345-89ac62494574", "321 Maple Court", 4, false, "doctor4@example.com" },
                    { "55ab853d-5b2d-4688-9940-e867e950d84c", 0, new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "b5aa7ced-ee09-4acb-9719-d2731b8e4218", "ApplicationUser", "doctor3@example.com", true, "Emily", null, "Johnson", false, null, "DOCTOR3@EXAMPLE.COM", "DOCTOR3@EXAMPLE.COM", "AQAAAAIAAYagAAAAENF2oK8nZa4pwvwiwLWzGR5uMoE6banXOcVvuyYMSHpCPAVABxJBXwU70uvhNoJ1QA==", null, false, "d1443939-ff1d-4dcb-9143-db42924b70ae", "789 Pine Lane", 3, false, "doctor3@example.com" },
                    { "749e047b-3964-4240-aa08-dd732222c341", 0, new DateTime(1991, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "6d4ec39a-baa8-46cd-8c26-459113c4a3d4", "ApplicationUser", "grace.martinez@example.com", false, "Grace", 0, "Martinez", false, null, "GRACE.MARTINEZ@EXAMPLE.COM", "GRACE.MARTINEZ", "AQAAAAIAAYagAAAAELNogTsKiCCpHFx/HKr8F00x6qdMPC5knyg0/BeAjie+i1yCht9652nSAur1RrqlcQ==", null, false, "f9f0becb-ae75-4a0f-a82c-a445228748a0", "Seventh Street 11", 7, false, "grace.martinez" },
                    { "8402ec25-6fab-4ec5-bdc2-47878b6831c0", 0, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "51927cd3-fa43-4bfd-ab71-0095d904881d", "ApplicationUser", "doctor1@example.com", true, "John", null, "Doe", false, null, "DOCTOR1@EXAMPLE.COM", "DOCTOR1@EXAMPLE.COM", "AQAAAAIAAYagAAAAECUMVn0Q59hLm9QSI+UI51Xujsd5UcxCzCgw5j9nQloW0YskibxoxbbMHbcPnVyGCw==", null, false, "c691c12a-9f71-40a0-892f-cdcf077cf018", "123 Elm Street", 1, false, "doctor1@example.com" },
                    { "935effba-cca7-4ab7-b3f8-2149e3b5b8dd", 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ab5029ed-2453-4e60-97f1-fbca646f37eb", "ApplicationUser", "alice.smith@example.com", false, "Alice", 0, "Smith", false, null, "ALICE.SMITH@EXAMPLE.COM", "ALICE.SMITH", "AQAAAAIAAYagAAAAEHaRqrXfU5USP+l5BVjF3qAEUZcpitC+WWZZsU9gxzxfILCV6gNjKX4K7xFUO1ypWA==", null, false, "e48e4111-4577-4c7b-ae3f-62a55322c8e6", "Main Street 1", 1, false, "alice.smith" },
                    { "93d4e279-e388-478d-860e-5f4d9e9e4873", 0, new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "f2481794-61f2-4ceb-a54a-7928452252ce", "ApplicationUser", "bob.johnson@example.com", false, "Bob", 1, "Johnson", false, null, "BOB.JOHNSON@EXAMPLE.COM", "BOB.JOHNSON", "AQAAAAIAAYagAAAAECaVYt8gJHM2R+YtAnSoweu9V1hEkacljfp9g/lnfmBYuL1Q2w0ulv3xYDGtuRcRvw==", null, false, "d3364866-b6aa-4632-aa7a-3b4224ca0c9c", "Second Avenue 34", 2, false, "bob.johnson" },
                    { "95b70e62-5023-4dc8-b6c6-7dc1e4911264", 0, new DateTime(1994, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "e6d6520f-20e6-40a5-8475-3d34a70602c2", "ApplicationUser", "jack.hernandez@example.com", false, "Jack", 1, "Hernandez", false, null, "JACK.HERNANDEZ@EXAMPLE.COM", "JACK.HERNANDEZ", "AQAAAAIAAYagAAAAEOsjVn0IqW1HawlJlRN4Va7wVuHv2b4ofA6RSPsezoPCwzdOhf7UDQf9RTjIlUKi8g==", null, false, "89832225-f1e8-4a3b-b7d9-94bb40e3c538", "Tenth Boulevard 89", 10, false, "jack.hernandez" },
                    { "99377057-4fd6-4bb7-83a4-ea8aed83c88a", 0, new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "93baf30c-6a3f-43bd-9d17-ba916f7cba94", "ApplicationUser", "doctor5@example.com", true, "Sarah", null, "Davis", false, null, "DOCTOR5@EXAMPLE.COM", "DOCTOR5@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIH5/xMv63GfllWrhcGe9C5CMyb7B+Rq9C96k5Lcgogy8fM7ZhDIQh+0qURLAs9BsQ==", null, false, "f2fc0608-a94b-4de5-aa78-eb67b4e1a05a", "654 Birch Blvd", 5, false, "doctor5@example.com" },
                    { "99a67a79-26b5-4fda-b19f-f00f9b2a6cad", 0, new DateTime(1992, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "92365080-651b-4958-aea1-b4154ea96bbe", "ApplicationUser", "cathy.williams@example.com", false, "Cathy", 0, "Williams", false, null, "CATHY.WILLIAMS@EXAMPLE.COM", "CATHY.WILLIAMS", "AQAAAAIAAYagAAAAEPza5fWdNDVfKQWsUzl5g772nnrsxm5VZUIacvcsITibE/E3JMA0vz4Ge6predCfJg==", null, false, "bbf5e425-0551-4663-86be-ad0567c1cd67", "Third Lane 5", 3, false, "cathy.williams" },
                    { "9c0558d7-b87b-4ab7-a80a-9ef96a18ad31", 0, new DateTime(1985, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "c8ecc648-0a04-44d7-9762-188c3c7986b9", "ApplicationUser", "doctor2@example.com", true, "Jane", null, "Smith", false, null, "DOCTOR2@EXAMPLE.COM", "DOCTOR2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPGsBifHcjXDrQe28mGfHk3I0QwRZvEdGm9nCXdnkRoLeR/P4HkvinY92Q6XLjSF6w==", null, false, "dab2e2b1-5e21-422e-9b94-babb96807fd1", "456 Oak Avenue", 2, false, "doctor2@example.com" },
                    { "b80697df-d98b-46e8-8ef8-7204f62d94e1", 0, new DateTime(1993, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "29339247-f0a5-47bd-99ac-f9e6352d1a4c", "ApplicationUser", "frank.garcia@example.com", false, "Frank", 1, "Garcia", false, null, "FRANK.GARCIA@EXAMPLE.COM", "FRANK.GARCIA", "AQAAAAIAAYagAAAAEJfEuESa0nH10OB+z4Jm2iTI5B50E86ta2+sVcLCJzybjfBfWThxaTlVVF6vY+ZHAw==", null, false, "d1b4a373-34cb-4cbd-a21e-e3ea7ee0c904", "Sixth Road 23", 6, false, "frank.garcia" },
                    { "d5bfaee1-adfb-4af2-9ede-07ae8117ec52", 0, new DateTime(1995, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "e96b0a3d-418c-47c5-a1c1-65b191f38884", "ApplicationUser", "ella.jones@example.com", false, "Ella", 0, "Jones", false, null, "ELLA.JONES@EXAMPLE.COM", "ELLA.JONES", "AQAAAAIAAYagAAAAEJwBv+qIoIJzjuIbPQygzspZtf8GIMp7l0Wm6K1b4nSPPuuOCl1QumPSw1Bgv1KOpQ==", null, false, "62b415fa-ec4b-4cc3-9d23-096caa21ccb0", "Fifth Avenue 9", 5, false, "ella.jones" }
                });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "R�ntgenuntersuchung");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "H�rtest");

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Vohenstrau�");

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "Bad K�tzting");

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 22,
                column: "Name",
                value: "Bodenw�hr");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5b636c5d-47b7-4b58-9428-e8fa35cab56c", "51b3247a-034d-4fee-bd48-7643609fe486" },
                    { "5b636c5d-47b7-4b58-9428-e8fa35cab56c", "55ab853d-5b2d-4688-9940-e867e950d84c" },
                    { "5b636c5d-47b7-4b58-9428-e8fa35cab56c", "8402ec25-6fab-4ec5-bdc2-47878b6831c0" },
                    { "5b636c5d-47b7-4b58-9428-e8fa35cab56c", "99377057-4fd6-4bb7-83a4-ea8aed83c88a" },
                    { "5b636c5d-47b7-4b58-9428-e8fa35cab56c", "9c0558d7-b87b-4ab7-a80a-9ef96a18ad31" }
                });

            migrationBuilder.InsertData(
                table: "DoctorPatientServices",
                columns: new[] { "DateStart", "DoctorId", "PatientId", "ServiceId", "DateEnd" },
                values: new object[,]
                {
                    { new DateTime(2025, 1, 18, 7, 0, 0, 0, DateTimeKind.Unspecified), "51b3247a-034d-4fee-bd48-7643609fe486", "41afaf33-b1f7-4b03-bc86-e272906487f7", 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 13, 13, 0, 0, 0, DateTimeKind.Unspecified), "51b3247a-034d-4fee-bd48-7643609fe486", "4a3291ef-8a09-4b97-9b72-608bf9f811da", 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), "55ab853d-5b2d-4688-9940-e867e950d84c", "40b52a9a-5ab8-47b2-808c-7ab8244e5cb4", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "55ab853d-5b2d-4688-9940-e867e950d84c", "99a67a79-26b5-4fda-b19f-f00f9b2a6cad", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), "8402ec25-6fab-4ec5-bdc2-47878b6831c0", "935effba-cca7-4ab7-b3f8-2149e3b5b8dd", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), "8402ec25-6fab-4ec5-bdc2-47878b6831c0", "b80697df-d98b-46e8-8ef8-7204f62d94e1", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), "99377057-4fd6-4bb7-83a4-ea8aed83c88a", "95b70e62-5023-4dc8-b6c6-7dc1e4911264", 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 14, 9, 0, 0, 0, DateTimeKind.Unspecified), "99377057-4fd6-4bb7-83a4-ea8aed83c88a", "d5bfaee1-adfb-4af2-9ede-07ae8117ec52", 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), "9c0558d7-b87b-4ab7-a80a-9ef96a18ad31", "749e047b-3964-4240-aa08-dd732222c341", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), "9c0558d7-b87b-4ab7-a80a-9ef96a18ad31", "93d4e279-e388-478d-860e-5f4d9e9e4873", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
                keyValues: new object[] { "5b636c5d-47b7-4b58-9428-e8fa35cab56c", "51b3247a-034d-4fee-bd48-7643609fe486" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5b636c5d-47b7-4b58-9428-e8fa35cab56c", "55ab853d-5b2d-4688-9940-e867e950d84c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5b636c5d-47b7-4b58-9428-e8fa35cab56c", "8402ec25-6fab-4ec5-bdc2-47878b6831c0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5b636c5d-47b7-4b58-9428-e8fa35cab56c", "99377057-4fd6-4bb7-83a4-ea8aed83c88a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5b636c5d-47b7-4b58-9428-e8fa35cab56c", "9c0558d7-b87b-4ab7-a80a-9ef96a18ad31" });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "DateStart", "DoctorId", "PatientId", "ServiceId" },
                keyColumnTypes: new[] { "datetime2", "nvarchar(450)", "nvarchar(450)", "int" },
                keyValues: new object[] { new DateTime(2025, 1, 18, 7, 0, 0, 0, DateTimeKind.Unspecified), "51b3247a-034d-4fee-bd48-7643609fe486", "41afaf33-b1f7-4b03-bc86-e272906487f7", 4 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "DateStart", "DoctorId", "PatientId", "ServiceId" },
                keyColumnTypes: new[] { "datetime2", "nvarchar(450)", "nvarchar(450)", "int" },
                keyValues: new object[] { new DateTime(2025, 1, 13, 13, 0, 0, 0, DateTimeKind.Unspecified), "51b3247a-034d-4fee-bd48-7643609fe486", "4a3291ef-8a09-4b97-9b72-608bf9f811da", 4 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "DateStart", "DoctorId", "PatientId", "ServiceId" },
                keyColumnTypes: new[] { "datetime2", "nvarchar(450)", "nvarchar(450)", "int" },
                keyValues: new object[] { new DateTime(2025, 1, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), "55ab853d-5b2d-4688-9940-e867e950d84c", "40b52a9a-5ab8-47b2-808c-7ab8244e5cb4", 3 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "DateStart", "DoctorId", "PatientId", "ServiceId" },
                keyColumnTypes: new[] { "datetime2", "nvarchar(450)", "nvarchar(450)", "int" },
                keyValues: new object[] { new DateTime(2025, 1, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "55ab853d-5b2d-4688-9940-e867e950d84c", "99a67a79-26b5-4fda-b19f-f00f9b2a6cad", 3 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "DateStart", "DoctorId", "PatientId", "ServiceId" },
                keyColumnTypes: new[] { "datetime2", "nvarchar(450)", "nvarchar(450)", "int" },
                keyValues: new object[] { new DateTime(2025, 1, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), "8402ec25-6fab-4ec5-bdc2-47878b6831c0", "935effba-cca7-4ab7-b3f8-2149e3b5b8dd", 1 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "DateStart", "DoctorId", "PatientId", "ServiceId" },
                keyColumnTypes: new[] { "datetime2", "nvarchar(450)", "nvarchar(450)", "int" },
                keyValues: new object[] { new DateTime(2025, 1, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), "8402ec25-6fab-4ec5-bdc2-47878b6831c0", "b80697df-d98b-46e8-8ef8-7204f62d94e1", 1 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "DateStart", "DoctorId", "PatientId", "ServiceId" },
                keyColumnTypes: new[] { "datetime2", "nvarchar(450)", "nvarchar(450)", "int" },
                keyValues: new object[] { new DateTime(2025, 1, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), "99377057-4fd6-4bb7-83a4-ea8aed83c88a", "95b70e62-5023-4dc8-b6c6-7dc1e4911264", 5 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "DateStart", "DoctorId", "PatientId", "ServiceId" },
                keyColumnTypes: new[] { "datetime2", "nvarchar(450)", "nvarchar(450)", "int" },
                keyValues: new object[] { new DateTime(2025, 1, 14, 9, 0, 0, 0, DateTimeKind.Unspecified), "99377057-4fd6-4bb7-83a4-ea8aed83c88a", "d5bfaee1-adfb-4af2-9ede-07ae8117ec52", 5 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "DateStart", "DoctorId", "PatientId", "ServiceId" },
                keyColumnTypes: new[] { "datetime2", "nvarchar(450)", "nvarchar(450)", "int" },
                keyValues: new object[] { new DateTime(2025, 1, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), "9c0558d7-b87b-4ab7-a80a-9ef96a18ad31", "749e047b-3964-4240-aa08-dd732222c341", 2 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "DateStart", "DoctorId", "PatientId", "ServiceId" },
                keyColumnTypes: new[] { "datetime2", "nvarchar(450)", "nvarchar(450)", "int" },
                keyValues: new object[] { new DateTime(2025, 1, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), "9c0558d7-b87b-4ab7-a80a-9ef96a18ad31", "93d4e279-e388-478d-860e-5f4d9e9e4873", 2 });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b636c5d-47b7-4b58-9428-e8fa35cab56c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40b52a9a-5ab8-47b2-808c-7ab8244e5cb4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41afaf33-b1f7-4b03-bc86-e272906487f7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a3291ef-8a09-4b97-9b72-608bf9f811da");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51b3247a-034d-4fee-bd48-7643609fe486");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55ab853d-5b2d-4688-9940-e867e950d84c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "749e047b-3964-4240-aa08-dd732222c341");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8402ec25-6fab-4ec5-bdc2-47878b6831c0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "935effba-cca7-4ab7-b3f8-2149e3b5b8dd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93d4e279-e388-478d-860e-5f4d9e9e4873");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95b70e62-5023-4dc8-b6c6-7dc1e4911264");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99377057-4fd6-4bb7-83a4-ea8aed83c88a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99a67a79-26b5-4fda-b19f-f00f9b2a6cad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c0558d7-b87b-4ab7-a80a-9ef96a18ad31");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b80697df-d98b-46e8-8ef8-7204f62d94e1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5bfaee1-adfb-4af2-9ede-07ae8117ec52");

            migrationBuilder.DropColumn(
                name: "DateStart",
                table: "DoctorPatientServices");

            migrationBuilder.RenameColumn(
                name: "DateEnd",
                table: "DoctorPatientServices",
                newName: "Date");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoctorPatientServices",
                table: "DoctorPatientServices",
                columns: new[] { "DoctorId", "PatientId", "ServiceId", "Date" });

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
                keyValue: 7,
                column: "Name",
                value: "Röntgenuntersuchung");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Hörtest");

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Vohenstrauß");

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "Bad Kötzting");

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 22,
                column: "Name",
                value: "Bodenwöhr");

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
    }
}
