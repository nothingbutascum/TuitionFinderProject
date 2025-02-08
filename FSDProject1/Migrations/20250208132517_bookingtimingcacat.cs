using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSDProject1.Migrations
{
    /// <inheritdoc />
    public partial class bookingtimingcacat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Booking_TutorId",
                table: "Booking");

            migrationBuilder.AlterColumn<string>(
                name: "Time",
                table: "Booking",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_TutorId_Date_Time",
                table: "Booking",
                columns: new[] { "TutorId", "Date", "Time" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Booking_TutorId_Date_Time",
                table: "Booking");

            migrationBuilder.AlterColumn<string>(
                name: "Time",
                table: "Booking",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_TutorId",
                table: "Booking",
                column: "TutorId");
        }
    }
}
