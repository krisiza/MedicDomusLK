using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MedicDomusLK.Migrations
{
    /// <inheritdoc />
    public partial class roles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "53f26c91-1f7f-4974-b639-687622fb956e", "5ac4a948-83a7-46ac-ab68-dcab3380f7b7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "53f26c91-1f7f-4974-b639-687622fb956e", "6614bff5-a4eb-42a5-8e10-e8f2139d04c0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "53f26c91-1f7f-4974-b639-687622fb956e", "6e0ad939-2b4e-433d-85e5-68e78ffa531e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "53f26c91-1f7f-4974-b639-687622fb956e", "fcf88b80-400d-459b-9738-59934a2e1147" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b5909cf-333a-4030-8a46-ce3948c0e4ed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d99990c7-cc98-4682-a82d-bb17f238fc80");

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "DateStart", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), "5ac4a948-83a7-46ac-ab68-dcab3380f7b7", "5f3e1ff5-daa2-4257-bab1-a29998b4d17f", 1 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "DateStart", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), "5ac4a948-83a7-46ac-ab68-dcab3380f7b7", "aa84e156-5d87-43ac-9568-c44b93682083", 1 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "DateStart", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 18, 7, 0, 0, 0, DateTimeKind.Unspecified), "6614bff5-a4eb-42a5-8e10-e8f2139d04c0", "24b4d3f9-dfa7-439a-ba39-98ac60c62928", 4 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "DateStart", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 13, 13, 0, 0, 0, DateTimeKind.Unspecified), "6614bff5-a4eb-42a5-8e10-e8f2139d04c0", "d2b20c09-455b-4f27-842f-8b197a22d538", 4 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "DateStart", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), "6e0ad939-2b4e-433d-85e5-68e78ffa531e", "8198dff8-b4ff-42ae-8ad1-eabbc419df13", 2 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "DateStart", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), "6e0ad939-2b4e-433d-85e5-68e78ffa531e", "da2ecf80-5300-4a27-bc8f-c3450c2ee26e", 2 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "DateStart", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), "fcf88b80-400d-459b-9738-59934a2e1147", "46acd8b9-3ec9-465e-8bec-d8b91005d413", 3 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "DateStart", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "fcf88b80-400d-459b-9738-59934a2e1147", "d0431988-d9ee-42f8-9034-8dd817f467e8", 3 });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53f26c91-1f7f-4974-b639-687622fb956e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24b4d3f9-dfa7-439a-ba39-98ac60c62928");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46acd8b9-3ec9-465e-8bec-d8b91005d413");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ac4a948-83a7-46ac-ab68-dcab3380f7b7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f3e1ff5-daa2-4257-bab1-a29998b4d17f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6614bff5-a4eb-42a5-8e10-e8f2139d04c0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6e0ad939-2b4e-433d-85e5-68e78ffa531e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8198dff8-b4ff-42ae-8ad1-eabbc419df13");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa84e156-5d87-43ac-9568-c44b93682083");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0431988-d9ee-42f8-9034-8dd817f467e8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2b20c09-455b-4f27-842f-8b197a22d538");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da2ecf80-5300-4a27-bc8f-c3450c2ee26e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fcf88b80-400d-459b-9738-59934a2e1147");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "TownId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "AspNetUsers",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Lastname",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Firstname",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthdate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e680ff77-3de4-4f6c-a2f1-14bd467f13ac", null, "Doctor", "DOCTOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthdate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "Gender", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Street", "TownId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2999cdc6-0e29-474c-b4f7-41f18abb1f87", 0, new DateTime(1987, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "d394420d-d172-490d-a3cc-ded9d3e01cfb", "henry.rodriguez@example.com", false, "Henry", 1, "Rodriguez", false, null, "HENRY.RODRIGUEZ@EXAMPLE.COM", "HENRY.RODRIGUEZ", "AQAAAAIAAYagAAAAECuyLnN6kpXbnll64dQeOZD3Kys41rvhYqfuVXaNLNYBVlVUDFEG9Tn75VIhMuINXw==", null, false, "801b97f1-47e4-41ca-9bb8-d8664207e695", "Eighth Avenue 56", 8, false, "henry.rodriguez" },
                    { "4844bf54-0f7e-4e06-b839-71600f7d8421", 0, new DateTime(1996, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "9a30a126-be70-433d-b062-0c0208391a2c", "isabella.lee@example.com", false, "Isabella", 0, "Lee", false, null, "ISABELLA.LEE@EXAMPLE.COM", "ISABELLA.LEE", "AQAAAAIAAYagAAAAEGgeJOJlgz6ZCjcx8WOYIm9Glalf1rHiyYKpceOtk2pOLtKm1UoNy2jvQdcLHM0UUQ==", null, false, "23252f40-e491-438f-97a5-dce0a383e08d", "Ninth Street 67", 9, false, "isabella.lee" },
                    { "62af87ff-64be-42a0-90c0-4d0c6b343133", 0, new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "a03c2452-4af3-4636-a034-c0236f1d1a62", "doctor3@example.com", true, "Emily", null, "Johnson", false, null, "DOCTOR3@EXAMPLE.COM", "DOCTOR3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFXVZWxJA27ixggz7Jfkrs75Qi+jZ10tNG+dF4l5jgjQgXP5qdp/6prpp6Cp0f8y7A==", null, false, "c95b4a65-2291-4008-9625-6f8dd842092e", "789 Pine Lane", 3, false, "doctor3@example.com" },
                    { "6a0e2302-56c8-42e5-a983-4a385c182454", 0, new DateTime(1995, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "45e3fb84-68c6-42c6-b781-213c3601943e", "ella.jones@example.com", false, "Ella", 0, "Jones", false, null, "ELLA.JONES@EXAMPLE.COM", "ELLA.JONES", "AQAAAAIAAYagAAAAEHf2BIgZX7FYdaWQN81S67udzvR8RmNZrDA8tSTLOYgcDTyzyxt5+RY/pFs1V+jYwQ==", null, false, "bd552382-26ba-4edf-9b73-5ef5f854559b", "Fifth Avenue 9", 5, false, "ella.jones" },
                    { "74eedd83-1545-4812-b088-8c04dc30502d", 0, new DateTime(1994, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "d02ba84f-96e6-4e17-aaad-c6f359c2572a", "jack.hernandez@example.com", false, "Jack", 1, "Hernandez", false, null, "JACK.HERNANDEZ@EXAMPLE.COM", "JACK.HERNANDEZ", "AQAAAAIAAYagAAAAEFN7VkyPuuAyP4q2MFUH4ICFHesgQJkVeYwyeJ7z1s65Mr9OIFUa1WE8HhUzAynROw==", null, false, "81cb66c0-a0fb-422e-a7dd-64d06626d39f", "Tenth Boulevard 89", 10, false, "jack.hernandez" },
                    { "8e637600-ce78-453a-b297-3ce0215328eb", 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "42053e45-4ace-4044-9b9a-2bbd2a9b55de", "alice.smith@example.com", false, "Alice", 0, "Smith", false, null, "ALICE.SMITH@EXAMPLE.COM", "ALICE.SMITH", "AQAAAAIAAYagAAAAEF+8NKmWkZggzv4RCZ2BJge3iFqXsMKjx44iIqhYTPju5Go9Il/AyNlkWEstoPoySA==", null, false, "680c5fbd-6e8c-4c1f-8ea6-1d7a7d2e7ccd", "Main Street 1", 1, false, "alice.smith" },
                    { "99cf6f56-0131-4ddc-85d1-8d007104691e", 0, new DateTime(1988, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "c363ad93-c687-44e8-ba5d-2ed597411353", "david.brown@example.com", false, "David", 1, "Brown", false, null, "DAVID.BROWN@EXAMPLE.COM", "DAVID.BROWN", "AQAAAAIAAYagAAAAEA/a6xUupTwM6etzdWUZGG3pixFH4aR1ZFFXXPk8g76A95Z9GmDs3YcID6dgvScyOA==", null, false, "4457a6d3-1729-4b49-8d64-55e1276f165e", "Fourth Street 78", 4, false, "david.brown" },
                    { "ab691d2a-e728-43a8-8627-02112ee9c5c7", 0, new DateTime(1993, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "0ab6db12-00a3-4e45-8aac-6fe8af9e55b4", "frank.garcia@example.com", false, "Frank", 1, "Garcia", false, null, "FRANK.GARCIA@EXAMPLE.COM", "FRANK.GARCIA", "AQAAAAIAAYagAAAAEEqGlMh5daURyJEg+UGVnFOuAGmBhYmg1FnO35KOwnZOBED0azAhIobbwNExPc8FdQ==", null, false, "05623898-828a-47dc-b7e8-76ecd8e63ec6", "Sixth Road 23", 6, false, "frank.garcia" },
                    { "acd0a572-a26a-441c-abf9-d64be15fba36", 0, new DateTime(1992, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "61adb137-b20e-411d-87ce-9914294d2e48", "cathy.williams@example.com", false, "Cathy", 0, "Williams", false, null, "CATHY.WILLIAMS@EXAMPLE.COM", "CATHY.WILLIAMS", "AQAAAAIAAYagAAAAEBIPmRLSW41TxsBqfNhT9+/g72R9YRMG11O+nDlmgS5FrgiA6fTu2o/09Ox/m2dkoQ==", null, false, "7fe3194a-8070-4d68-a02e-739b1a353fac", "Third Lane 5", 3, false, "cathy.williams" },
                    { "ad0ab7de-6aac-441f-a0f7-7ee8d0243852", 0, new DateTime(1975, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "f7fb09e7-9f57-42fa-9246-f0ddc396d202", "doctor4@example.com", true, "Michael", null, "Garcia", false, null, "DOCTOR4@EXAMPLE.COM", "DOCTOR4@EXAMPLE.COM", "AQAAAAIAAYagAAAAECzIeGakXO4Q6/eL27GCCILZOJeB3JJOACVNKJQqueNVWFuYV5MDL+cx3SmKRfVYuw==", null, false, "273c8dea-0977-4357-ac62-9c3d1334a47f", "321 Maple Court", 4, false, "doctor4@example.com" },
                    { "c9e3cc49-cbaf-4623-9c1a-3ff56cd384fe", 0, new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "3da68f9e-3d8c-42c4-b16c-776cc2011c2c", "bob.johnson@example.com", false, "Bob", 1, "Johnson", false, null, "BOB.JOHNSON@EXAMPLE.COM", "BOB.JOHNSON", "AQAAAAIAAYagAAAAEM1gabYXAahviP5sOMJs5YSQbjSVFowfqTyH2kv28kph/TgZMwIW0HumDWpwAg3D/Q==", null, false, "b5fb0a4e-c35b-4615-bdbe-ff52479a2b97", "Second Avenue 34", 2, false, "bob.johnson" },
                    { "d964d4b4-474b-476b-933b-264f67f3f980", 0, new DateTime(1991, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "7b45d951-853e-436c-a15d-0d7c287b91a8", "grace.martinez@example.com", false, "Grace", 0, "Martinez", false, null, "GRACE.MARTINEZ@EXAMPLE.COM", "GRACE.MARTINEZ", "AQAAAAIAAYagAAAAED0fpdMTCllYQJ+4EkkIMhtwjv/gNRXp6OxWv/JZqKnC+Ny2m+K66w+AeV4ybC7Y2w==", null, false, "6488b26c-6d71-4878-b82e-de092d04870d", "Seventh Street 11", 7, false, "grace.martinez" },
                    { "f22b29b7-7fe9-409f-97a3-0d3fa57b3aef", 0, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "76b7ce18-41f2-4dd5-b2d3-25a8ae612452", "doctor1@example.com", true, "John", null, "Harris", false, null, "DOCTOR1@EXAMPLE.COM", "DOCTOR1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBSqkzeZIJqaiCXX5/NBAjB8IhDFwgZA9dcI+WgAutShM728vrS+yF4xOnT8bhRXGw==", null, false, "9eb3b20b-d062-4e33-855f-51ea074179e1", "123 Elm Street", 1, false, "doctor1@example.com" },
                    { "fa149267-cf02-4778-8839-05aa0172d2da", 0, new DateTime(1985, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "e138f631-32af-4bb7-8ccd-7eb7f1710c97", "doctor2@example.com", true, "Jane", null, "Smith", false, null, "DOCTOR2@EXAMPLE.COM", "DOCTOR2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHDpexbTAV2pI3qI/pM5SSA5Hu6ccYKUwHexrt776bnghvqU5N0kkUn1tsfmnrnfqA==", null, false, "b15788c8-3afe-485d-9294-cf0dc0b6bb6e", "456 Oak Avenue", 2, false, "doctor2@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "DoctorInfos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DoctorId",
                value: "f22b29b7-7fe9-409f-97a3-0d3fa57b3aef");

            migrationBuilder.UpdateData(
                table: "DoctorInfos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DoctorId",
                value: "fa149267-cf02-4778-8839-05aa0172d2da");

            migrationBuilder.UpdateData(
                table: "DoctorInfos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DoctorId",
                value: "62af87ff-64be-42a0-90c0-4d0c6b343133");

            migrationBuilder.UpdateData(
                table: "DoctorInfos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DoctorId",
                value: "ad0ab7de-6aac-441f-a0f7-7ee8d0243852");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e680ff77-3de4-4f6c-a2f1-14bd467f13ac", "62af87ff-64be-42a0-90c0-4d0c6b343133" },
                    { "e680ff77-3de4-4f6c-a2f1-14bd467f13ac", "ad0ab7de-6aac-441f-a0f7-7ee8d0243852" },
                    { "e680ff77-3de4-4f6c-a2f1-14bd467f13ac", "f22b29b7-7fe9-409f-97a3-0d3fa57b3aef" },
                    { "e680ff77-3de4-4f6c-a2f1-14bd467f13ac", "fa149267-cf02-4778-8839-05aa0172d2da" }
                });

            migrationBuilder.InsertData(
                table: "DoctorPatientServices",
                columns: new[] { "DateStart", "DoctorId", "PatientId", "ServiceId", "DateEnd" },
                values: new object[,]
                {
                    { new DateTime(2025, 1, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), "62af87ff-64be-42a0-90c0-4d0c6b343133", "2999cdc6-0e29-474c-b4f7-41f18abb1f87", 3, new DateTime(2025, 1, 17, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "62af87ff-64be-42a0-90c0-4d0c6b343133", "acd0a572-a26a-441c-abf9-d64be15fba36", 3, new DateTime(2025, 1, 12, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 18, 7, 0, 0, 0, DateTimeKind.Unspecified), "ad0ab7de-6aac-441f-a0f7-7ee8d0243852", "4844bf54-0f7e-4e06-b839-71600f7d8421", 4, new DateTime(2025, 1, 18, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 13, 13, 0, 0, 0, DateTimeKind.Unspecified), "ad0ab7de-6aac-441f-a0f7-7ee8d0243852", "99cf6f56-0131-4ddc-85d1-8d007104691e", 4, new DateTime(2025, 1, 13, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), "f22b29b7-7fe9-409f-97a3-0d3fa57b3aef", "8e637600-ce78-453a-b297-3ce0215328eb", 1, new DateTime(2025, 1, 10, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), "f22b29b7-7fe9-409f-97a3-0d3fa57b3aef", "ab691d2a-e728-43a8-8627-02112ee9c5c7", 1, new DateTime(2025, 1, 15, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), "fa149267-cf02-4778-8839-05aa0172d2da", "c9e3cc49-cbaf-4623-9c1a-3ff56cd384fe", 2, new DateTime(2025, 1, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new DateTime(2025, 1, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), "fa149267-cf02-4778-8839-05aa0172d2da", "d964d4b4-474b-476b-933b-264f67f3f980", 2, new DateTime(2025, 1, 16, 10, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e680ff77-3de4-4f6c-a2f1-14bd467f13ac", "62af87ff-64be-42a0-90c0-4d0c6b343133" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e680ff77-3de4-4f6c-a2f1-14bd467f13ac", "ad0ab7de-6aac-441f-a0f7-7ee8d0243852" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e680ff77-3de4-4f6c-a2f1-14bd467f13ac", "f22b29b7-7fe9-409f-97a3-0d3fa57b3aef" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e680ff77-3de4-4f6c-a2f1-14bd467f13ac", "fa149267-cf02-4778-8839-05aa0172d2da" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a0e2302-56c8-42e5-a983-4a385c182454");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74eedd83-1545-4812-b088-8c04dc30502d");

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "DateStart", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), "62af87ff-64be-42a0-90c0-4d0c6b343133", "2999cdc6-0e29-474c-b4f7-41f18abb1f87", 3 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "DateStart", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "62af87ff-64be-42a0-90c0-4d0c6b343133", "acd0a572-a26a-441c-abf9-d64be15fba36", 3 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "DateStart", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 18, 7, 0, 0, 0, DateTimeKind.Unspecified), "ad0ab7de-6aac-441f-a0f7-7ee8d0243852", "4844bf54-0f7e-4e06-b839-71600f7d8421", 4 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "DateStart", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 13, 13, 0, 0, 0, DateTimeKind.Unspecified), "ad0ab7de-6aac-441f-a0f7-7ee8d0243852", "99cf6f56-0131-4ddc-85d1-8d007104691e", 4 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "DateStart", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), "f22b29b7-7fe9-409f-97a3-0d3fa57b3aef", "8e637600-ce78-453a-b297-3ce0215328eb", 1 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "DateStart", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), "f22b29b7-7fe9-409f-97a3-0d3fa57b3aef", "ab691d2a-e728-43a8-8627-02112ee9c5c7", 1 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "DateStart", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), "fa149267-cf02-4778-8839-05aa0172d2da", "c9e3cc49-cbaf-4623-9c1a-3ff56cd384fe", 2 });

            migrationBuilder.DeleteData(
                table: "DoctorPatientServices",
                keyColumns: new[] { "DateStart", "DoctorId", "PatientId", "ServiceId" },
                keyValues: new object[] { new DateTime(2025, 1, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), "fa149267-cf02-4778-8839-05aa0172d2da", "d964d4b4-474b-476b-933b-264f67f3f980", 2 });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e680ff77-3de4-4f6c-a2f1-14bd467f13ac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2999cdc6-0e29-474c-b4f7-41f18abb1f87");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4844bf54-0f7e-4e06-b839-71600f7d8421");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62af87ff-64be-42a0-90c0-4d0c6b343133");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e637600-ce78-453a-b297-3ce0215328eb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99cf6f56-0131-4ddc-85d1-8d007104691e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab691d2a-e728-43a8-8627-02112ee9c5c7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "acd0a572-a26a-441c-abf9-d64be15fba36");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad0ab7de-6aac-441f-a0f7-7ee8d0243852");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9e3cc49-cbaf-4623-9c1a-3ff56cd384fe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d964d4b4-474b-476b-933b-264f67f3f980");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f22b29b7-7fe9-409f-97a3-0d3fa57b3aef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa149267-cf02-4778-8839-05aa0172d2da");

            migrationBuilder.AlterColumn<int>(
                name: "TownId",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "AspNetUsers",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120);

            migrationBuilder.AlterColumn<string>(
                name: "Lastname",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Firstname",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthdate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "53f26c91-1f7f-4974-b639-687622fb956e", null, "Doctor", "DOCTOR" });

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

            migrationBuilder.UpdateData(
                table: "DoctorInfos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DoctorId",
                value: "5ac4a948-83a7-46ac-ab68-dcab3380f7b7");

            migrationBuilder.UpdateData(
                table: "DoctorInfos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DoctorId",
                value: "6e0ad939-2b4e-433d-85e5-68e78ffa531e");

            migrationBuilder.UpdateData(
                table: "DoctorInfos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DoctorId",
                value: "fcf88b80-400d-459b-9738-59934a2e1147");

            migrationBuilder.UpdateData(
                table: "DoctorInfos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DoctorId",
                value: "6614bff5-a4eb-42a5-8e10-e8f2139d04c0");

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
        }
    }
}
