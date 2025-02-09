using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSDProject1.Migrations
{
    /// <inheritdoc />
    public partial class Update123 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 2,
                column: "TutorId",
                value: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 2,
                column: "TutorId",
                value: 2);
        }
    }
}
