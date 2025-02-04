using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSDProject1.Migrations
{
    /// <inheritdoc />
    public partial class NewBooking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Tutors_TutorID",
                table: "Booking");

            migrationBuilder.RenameColumn(
                name: "TutorID",
                table: "Booking",
                newName: "TutorId");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_TutorID",
                table: "Booking",
                newName: "IX_Booking_TutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Tutors_TutorId",
                table: "Booking",
                column: "TutorId",
                principalTable: "Tutors",
                principalColumn: "TutorId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Tutors_TutorId",
                table: "Booking");

            migrationBuilder.RenameColumn(
                name: "TutorId",
                table: "Booking",
                newName: "TutorID");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_TutorId",
                table: "Booking",
                newName: "IX_Booking_TutorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Tutors_TutorID",
                table: "Booking",
                column: "TutorID",
                principalTable: "Tutors",
                principalColumn: "TutorId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
