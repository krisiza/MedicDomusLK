using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MedicDomusLK.Migrations
{
    /// <inheritdoc />
    public partial class seedmoredata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "91480c7e-42e0-4e7f-b198-a15c07325337", "2bbe50bf-8769-440d-b8aa-4ba32d328715" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "91480c7e-42e0-4e7f-b198-a15c07325337", "89b50be6-56f9-4c74-aa29-4a8c9dc36811" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "91480c7e-42e0-4e7f-b198-a15c07325337", "ce4ddca4-b7ac-4875-abd8-40ee8625db6a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "91480c7e-42e0-4e7f-b198-a15c07325337", "d183068a-bd88-4bd1-b291-6e1488ceee71" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "91480c7e-42e0-4e7f-b198-a15c07325337", "f4c4953c-3968-42c0-8a00-8abfef3560e2" });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "Date", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "2bbe50bf-8769-440d-b8aa-4ba32d328715", "27e1510f-6114-41e0-b35c-bfca4c084cd4", 1 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "Date", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "2bbe50bf-8769-440d-b8aa-4ba32d328715", "94893109-8f52-4336-9df0-074ef43b90d1", 1 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "Date", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "89b50be6-56f9-4c74-aa29-4a8c9dc36811", "18e44362-b561-4f3a-b094-3ebdd697776d", 3 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "Date", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "89b50be6-56f9-4c74-aa29-4a8c9dc36811", "771c7bda-9bdf-42b7-8b6d-53ae8dd76652", 3 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "Date", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "ce4ddca4-b7ac-4875-abd8-40ee8625db6a", "3afd12f7-54e0-44c8-9b06-5880226fe90f", 2 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "Date", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "ce4ddca4-b7ac-4875-abd8-40ee8625db6a", "697638f3-888a-4de7-9c44-44a0d776b071", 2 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "Date", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "d183068a-bd88-4bd1-b291-6e1488ceee71", "078f881d-6035-4232-98ee-4e6365335268", 4 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "Date", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "d183068a-bd88-4bd1-b291-6e1488ceee71", "54e66b88-d082-43cc-bce6-c915a77c4533", 4 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "Date", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "f4c4953c-3968-42c0-8a00-8abfef3560e2", "d2c8625e-1096-47e8-9e45-09ee84e7c193", 5 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "Date", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "f4c4953c-3968-42c0-8a00-8abfef3560e2", "da7ffc7d-da65-4dd0-8354-98eb3a796364", 5 });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91480c7e-42e0-4e7f-b198-a15c07325337");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "078f881d-6035-4232-98ee-4e6365335268");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18e44362-b561-4f3a-b094-3ebdd697776d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27e1510f-6114-41e0-b35c-bfca4c084cd4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2bbe50bf-8769-440d-b8aa-4ba32d328715");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3afd12f7-54e0-44c8-9b06-5880226fe90f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54e66b88-d082-43cc-bce6-c915a77c4533");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "697638f3-888a-4de7-9c44-44a0d776b071");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "771c7bda-9bdf-42b7-8b6d-53ae8dd76652");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "89b50be6-56f9-4c74-aa29-4a8c9dc36811");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94893109-8f52-4336-9df0-074ef43b90d1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce4ddca4-b7ac-4875-abd8-40ee8625db6a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d183068a-bd88-4bd1-b291-6e1488ceee71");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2c8625e-1096-47e8-9e45-09ee84e7c193");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da7ffc7d-da65-4dd0-8354-98eb3a796364");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f4c4953c-3968-42c0-8a00-8abfef3560e2");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "91480c7e-42e0-4e7f-b198-a15c07325337", null, "Doctor", "DOCTOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthdate", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Firstname", "Gender", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Street", "TownId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "078f881d-6035-4232-98ee-4e6365335268", 0, new DateTime(1988, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "b91dce48-496d-48ec-8519-963b474cc9a4", "ApplicationUser", "david.brown@example.com", false, "David", 1, "Brown", false, null, "DAVID.BROWN@EXAMPLE.COM", "DAVID.BROWN", "AQAAAAIAAYagAAAAEBBNqZzZPoMHjz4iH5Z0Fsp7fVmFpPRsIN9fucAO57Cl/jdtabjgENEc6Q8kHzOdbA==", null, false, "f54b7ff6-3be3-4c21-892e-ba5581bd545f", "Fourth Street 78", 4, false, "david.brown" },
                    { "18e44362-b561-4f3a-b094-3ebdd697776d", 0, new DateTime(1987, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "435e5989-94c8-47c0-a8ea-2ed6990edec0", "ApplicationUser", "henry.rodriguez@example.com", false, "Henry", 1, "Rodriguez", false, null, "HENRY.RODRIGUEZ@EXAMPLE.COM", "HENRY.RODRIGUEZ", "AQAAAAIAAYagAAAAEFKNQ2Ti3BxJ7hX1c5d6flNT1qgEJuKhv0tH7GJc0rSIYfVR+d7UlbmEaKw8vzmPhg==", null, false, "c8374ef2-1e64-4c35-9c58-7b1f4892f92c", "Eighth Avenue 56", 8, false, "henry.rodriguez" },
                    { "27e1510f-6114-41e0-b35c-bfca4c084cd4", 0, new DateTime(1993, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "3c7d4a93-a204-447b-b39f-460d3f515001", "ApplicationUser", "frank.garcia@example.com", false, "Frank", 1, "Garcia", false, null, "FRANK.GARCIA@EXAMPLE.COM", "FRANK.GARCIA", "AQAAAAIAAYagAAAAEJfLJkGSEpgfQoaRy7cxFwJyor0dWri6/QmBOPIVvzBZAQ1a74gTF7HogV1Qrnq6AA==", null, false, "0a3b26b3-a331-4899-a4cb-347eeefa45f5", "Sixth Road 23", 6, false, "frank.garcia" },
                    { "2bbe50bf-8769-440d-b8aa-4ba32d328715", 0, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "01dc041b-4340-4570-8978-b79d5952890e", "ApplicationUser", "doctor1@example.com", true, "John", null, "Doe", false, null, "DOCTOR1@EXAMPLE.COM", "DOCTOR1@EXAMPLE.COM", "AQAAAAIAAYagAAAAELDO+lYA4zFGmzoEwKwUQebU06/Q8PZKVJoJcMJdzK/3H/gf18Qd/uxU8/8SwXjlfw==", null, false, "8ce1213a-8c24-44f6-ac91-46c4581ebaf5", "123 Elm Street", 1, false, "doctor1@example.com" },
                    { "3afd12f7-54e0-44c8-9b06-5880226fe90f", 0, new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "afd5f65b-17e1-4d57-9011-9e46bf5e234c", "ApplicationUser", "bob.johnson@example.com", false, "Bob", 1, "Johnson", false, null, "BOB.JOHNSON@EXAMPLE.COM", "BOB.JOHNSON", "AQAAAAIAAYagAAAAEBAjlXhdLuBSauh+H9hr2Ruh8kDUIWwwKcsMt6nUQKaaNdM2pKHrf0nYWoi3kLfq7g==", null, false, "413169c8-fbce-4b18-8171-68edcd8256d2", "Second Avenue 34", 2, false, "bob.johnson" },
                    { "54e66b88-d082-43cc-bce6-c915a77c4533", 0, new DateTime(1996, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "66758161-1dd2-4cda-8c35-1006770a18b9", "ApplicationUser", "isabella.lee@example.com", false, "Isabella", 0, "Lee", false, null, "ISABELLA.LEE@EXAMPLE.COM", "ISABELLA.LEE", "AQAAAAIAAYagAAAAEFrGPQdZmK6aljHPl6Pm6imCXxOqbCM3lCJzu30zozDdxT8q4N2d7mEpgA/OLvvlIQ==", null, false, "35d3f151-2c6a-4983-8a4c-6964ddb81f72", "Ninth Street 67", 9, false, "isabella.lee" },
                    { "697638f3-888a-4de7-9c44-44a0d776b071", 0, new DateTime(1991, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "8ff3a78f-d107-47ba-b399-958e6d2bbdad", "ApplicationUser", "grace.martinez@example.com", false, "Grace", 0, "Martinez", false, null, "GRACE.MARTINEZ@EXAMPLE.COM", "GRACE.MARTINEZ", "AQAAAAIAAYagAAAAENRH3KyBQos3fHfdeEQiyHvquu9fwo89Db3rBKrKnAdD3O1AR7OkD6awdVIWi64Qow==", null, false, "aacc9cf9-3b17-4ce5-832e-755e2bf7595d", "Seventh Street 11", 7, false, "grace.martinez" },
                    { "771c7bda-9bdf-42b7-8b6d-53ae8dd76652", 0, new DateTime(1992, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "30c50922-06e0-49be-b323-80992841b6c4", "ApplicationUser", "cathy.williams@example.com", false, "Cathy", 0, "Williams", false, null, "CATHY.WILLIAMS@EXAMPLE.COM", "CATHY.WILLIAMS", "AQAAAAIAAYagAAAAEKekvNBsm2mKIBt44XhVbkhYpJGHkH2Gn0IsUHGoBc0t1ZkoTXBiXWouTJLo6zFfcA==", null, false, "745e172f-a5f1-437e-9bc5-3e2a53873a01", "Third Lane 5", 3, false, "cathy.williams" },
                    { "89b50be6-56f9-4c74-aa29-4a8c9dc36811", 0, new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "d4b5153d-168d-4758-8ab5-02c6b411e398", "ApplicationUser", "doctor3@example.com", true, "Emily", null, "Johnson", false, null, "DOCTOR3@EXAMPLE.COM", "DOCTOR3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKCOIAfPobrlqZMeImDPeddHhrRKKK/bZGBgYkG0IllICh+20M5ruByWkZOI1YEjnA==", null, false, "acd42299-3533-48db-a702-725e78c4184f", "789 Pine Lane", 3, false, "doctor3@example.com" },
                    { "94893109-8f52-4336-9df0-074ef43b90d1", 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7c87f816-60d0-40ba-906a-a67d2a901203", "ApplicationUser", "alice.smith@example.com", false, "Alice", 0, "Smith", false, null, "ALICE.SMITH@EXAMPLE.COM", "ALICE.SMITH", "AQAAAAIAAYagAAAAEFLfb6W03fcGy9cNyd3rvZ+viw6PnchuU8rkgAQPN/1N0agyyW8791JGoxm3uy0TuQ==", null, false, "2253d569-6765-4403-adc3-4e445f03d937", "Main Street 1", 1, false, "alice.smith" },
                    { "ce4ddca4-b7ac-4875-abd8-40ee8625db6a", 0, new DateTime(1985, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "69fed519-41bc-48cd-a701-75b961a542db", "ApplicationUser", "doctor2@example.com", true, "Jane", null, "Smith", false, null, "DOCTOR2@EXAMPLE.COM", "DOCTOR2@EXAMPLE.COM", "AQAAAAIAAYagAAAAELGNZRjKO8j9MVbUdciTjjs7LKuSgqAOU8W47Z4ih+7ZOD+lrrxlvdXmg0QyY1IxKw==", null, false, "a5ae9ab8-456f-49fe-a286-a071510aa2ed", "456 Oak Avenue", 2, false, "doctor2@example.com" },
                    { "d183068a-bd88-4bd1-b291-6e1488ceee71", 0, new DateTime(1975, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "307c1f85-d192-4b3f-bd5c-2d89f0acdcd7", "ApplicationUser", "doctor4@example.com", true, "Michael", null, "Brown", false, null, "DOCTOR4@EXAMPLE.COM", "DOCTOR4@EXAMPLE.COM", "AQAAAAIAAYagAAAAEH8piA05oPz6nkNZH4I88slisf+o3mU5R2avgnKKC9UjCh/lxfdWmLpkpuex+rNPfQ==", null, false, "b15f6d20-76a6-4ac2-b824-f450c6a04be6", "321 Maple Court", 4, false, "doctor4@example.com" },
                    { "d2c8625e-1096-47e8-9e45-09ee84e7c193", 0, new DateTime(1995, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "2fa755ff-b17c-4a9b-9e82-b8ffc72a1085", "ApplicationUser", "ella.jones@example.com", false, "Ella", 0, "Jones", false, null, "ELLA.JONES@EXAMPLE.COM", "ELLA.JONES", "AQAAAAIAAYagAAAAEBgHrW3LAL8ehkw5rn01FtG99kmYqDY6xsLIKIzgizZyvYPhnBWAerS30B2cAcgXgQ==", null, false, "03d210ca-e37a-484e-858c-d1a4013c6e13", "Fifth Avenue 9", 5, false, "ella.jones" },
                    { "da7ffc7d-da65-4dd0-8354-98eb3a796364", 0, new DateTime(1994, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "16f8f0d0-7d58-42f3-be1c-e28422572013", "ApplicationUser", "jack.hernandez@example.com", false, "Jack", 1, "Hernandez", false, null, "JACK.HERNANDEZ@EXAMPLE.COM", "JACK.HERNANDEZ", "AQAAAAIAAYagAAAAEKAOi6eiR/6kRTmfghbHNooIBL6UKPGBty2gIdyHzmN4tYcyD0T+tmuhnFHgnvMFJQ==", null, false, "be1cf3d8-1cd6-4a96-8065-d06bb72aed6e", "Tenth Boulevard 89", 10, false, "jack.hernandez" },
                    { "f4c4953c-3968-42c0-8a00-8abfef3560e2", 0, new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "b83a8b62-14e5-4be8-a319-84cd089e96d8", "ApplicationUser", "doctor5@example.com", true, "Sarah", null, "Davis", false, null, "DOCTOR5@EXAMPLE.COM", "DOCTOR5@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPQYd71Tho/p6IPOkdKjMe5bJgWGZDEqwaWgsk5uKlgFizi2RmISVadbYdXpemT1Vg==", null, false, "dc4df817-510f-4854-801f-551084a3dc5d", "654 Birch Blvd", 5, false, "doctor5@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "91480c7e-42e0-4e7f-b198-a15c07325337", "2bbe50bf-8769-440d-b8aa-4ba32d328715" },
                    { "91480c7e-42e0-4e7f-b198-a15c07325337", "89b50be6-56f9-4c74-aa29-4a8c9dc36811" },
                    { "91480c7e-42e0-4e7f-b198-a15c07325337", "ce4ddca4-b7ac-4875-abd8-40ee8625db6a" },
                    { "91480c7e-42e0-4e7f-b198-a15c07325337", "d183068a-bd88-4bd1-b291-6e1488ceee71" },
                    { "91480c7e-42e0-4e7f-b198-a15c07325337", "f4c4953c-3968-42c0-8a00-8abfef3560e2" }
                });

            migrationBuilder.InsertData(
                table: "DoctorPatientServices",
                columns: new[] { "Date", "DoctorId", "PatientId", "ServiceId" },
                values: new object[,]
                {
                    { new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "2bbe50bf-8769-440d-b8aa-4ba32d328715", "27e1510f-6114-41e0-b35c-bfca4c084cd4", 1 },
                    { new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "2bbe50bf-8769-440d-b8aa-4ba32d328715", "94893109-8f52-4336-9df0-074ef43b90d1", 1 },
                    { new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "89b50be6-56f9-4c74-aa29-4a8c9dc36811", "18e44362-b561-4f3a-b094-3ebdd697776d", 3 },
                    { new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "89b50be6-56f9-4c74-aa29-4a8c9dc36811", "771c7bda-9bdf-42b7-8b6d-53ae8dd76652", 3 },
                    { new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "ce4ddca4-b7ac-4875-abd8-40ee8625db6a", "3afd12f7-54e0-44c8-9b06-5880226fe90f", 2 },
                    { new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "ce4ddca4-b7ac-4875-abd8-40ee8625db6a", "697638f3-888a-4de7-9c44-44a0d776b071", 2 },
                    { new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "d183068a-bd88-4bd1-b291-6e1488ceee71", "078f881d-6035-4232-98ee-4e6365335268", 4 },
                    { new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "d183068a-bd88-4bd1-b291-6e1488ceee71", "54e66b88-d082-43cc-bce6-c915a77c4533", 4 },
                    { new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "f4c4953c-3968-42c0-8a00-8abfef3560e2", "d2c8625e-1096-47e8-9e45-09ee84e7c193", 5 },
                    { new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "f4c4953c-3968-42c0-8a00-8abfef3560e2", "da7ffc7d-da65-4dd0-8354-98eb3a796364", 5 }
                });
        }
    }
}
