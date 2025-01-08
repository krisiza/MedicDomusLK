using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MedicDomusLK.Migrations
{
    /// <inheritdoc />
    public partial class doctorpatientservices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DoctorPatientServices",
                columns: table => new
                {
                    DoctorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorPatientServices", x => new { x.DoctorId, x.PatientId, x.ServiceId });
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
                table: "Services",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "General Consultation", 50.00m },
                    { 2, "Pediatric Check-Up", 60.00m },
                    { 3, "Vaccination", 30.00m },
                    { 4, "Blood Test", 45.00m },
                    { 5, "Physical Therapy Session", 70.00m },
                    { 6, "Specialist Consultation", 100.00m }
                });

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
                name: "DoctorPatientServices");

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
