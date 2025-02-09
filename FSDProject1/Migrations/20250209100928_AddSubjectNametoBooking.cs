using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSDProject1.Migrations
{
    /// <inheritdoc />
    public partial class AddSubjectNametoBooking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SubjectName",
                table: "Booking",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 1,
                column: "SubjectName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 2,
                column: "SubjectName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 3,
                column: "SubjectName",
                value: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubjectName",
                table: "Booking");
        }
    }
}
