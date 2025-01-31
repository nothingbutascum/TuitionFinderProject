using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSDProject1.Migrations
{
    /// <inheritdoc />
    public partial class Studentchangenonnullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tutors_StudentUser_StudentUserId",
                table: "Tutors");

            migrationBuilder.AlterColumn<int>(
                name: "StudentUserId",
                table: "Tutors",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Tutors_StudentUser_StudentUserId",
                table: "Tutors",
                column: "StudentUserId",
                principalTable: "StudentUser",
                principalColumn: "StudentUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tutors_StudentUser_StudentUserId",
                table: "Tutors");

            migrationBuilder.AlterColumn<int>(
                name: "StudentUserId",
                table: "Tutors",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tutors_StudentUser_StudentUserId",
                table: "Tutors",
                column: "StudentUserId",
                principalTable: "StudentUser",
                principalColumn: "StudentUserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
