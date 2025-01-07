using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MedicDomusLK.Migrations
{
    /// <inheritdoc />
    public partial class seedtowns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { 13, "Vohenstrauß", "92718" },
                    { 14, "Wenzenbach", "93073" },
                    { 15, "Oberviechtach", "92442" },
                    { 16, "Cham", "93413" },
                    { 17, "Bad Kötzting", "93444" },
                    { 18, "Ensdorf", "92266" },
                    { 19, "Neunburg vorm Wald", "92431" },
                    { 20, "Barbing", "93092" },
                    { 21, "Wiesau", "92699" },
                    { 22, "Bodenwöhr", "92439" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 22);
        }
    }
}
