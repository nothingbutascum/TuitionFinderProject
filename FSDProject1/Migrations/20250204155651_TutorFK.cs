using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSDProject1.Migrations
{
    /// <inheritdoc />
    public partial class TutorFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Tutors_TutorId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_TutorId",
                table: "Subjects");

            migrationBuilder.CreateTable(
                name: "SubjectsTutors",
                columns: table => new
                {
                    SubjectsSubjectId = table.Column<int>(type: "int", nullable: false),
                    TutorsTutorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectsTutors", x => new { x.SubjectsSubjectId, x.TutorsTutorId });
                    table.ForeignKey(
                        name: "FK_SubjectsTutors_Subjects_SubjectsSubjectId",
                        column: x => x.SubjectsSubjectId,
                        principalTable: "Subjects",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubjectsTutors_Tutors_TutorsTutorId",
                        column: x => x.TutorsTutorId,
                        principalTable: "Tutors",
                        principalColumn: "TutorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubjectsTutors_TutorsTutorId",
                table: "SubjectsTutors",
                column: "TutorsTutorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubjectsTutors");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_TutorId",
                table: "Subjects",
                column: "TutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Tutors_TutorId",
                table: "Subjects",
                column: "TutorId",
                principalTable: "Tutors",
                principalColumn: "TutorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
