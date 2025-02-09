using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSDProject1.Migrations
{
    /// <inheritdoc />
    public partial class backtosquare1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubjectName",
                table: "Booking");

            migrationBuilder.AddColumn<int>(
                name: "TutorId",
                table: "Subjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TutorSubject",
                columns: table => new
                {
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    TutorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TutorSubject", x => new { x.SubjectId, x.TutorId });
                    table.ForeignKey(
                        name: "FK_TutorSubject_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TutorSubject_Tutors_TutorId",
                        column: x => x.TutorId,
                        principalTable: "Tutors",
                        principalColumn: "TutorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 1,
                column: "TutorId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 2,
                column: "TutorId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 3,
                column: "TutorId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_TutorId",
                table: "Subjects",
                column: "TutorId");

            migrationBuilder.CreateIndex(
                name: "IX_TutorSubject_TutorId",
                table: "TutorSubject",
                column: "TutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Tutors_TutorId",
                table: "Subjects",
                column: "TutorId",
                principalTable: "Tutors",
                principalColumn: "TutorId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Tutors_TutorId",
                table: "Subjects");

            migrationBuilder.DropTable(
                name: "TutorSubject");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_TutorId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "TutorId",
                table: "Subjects");

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
    }
}
