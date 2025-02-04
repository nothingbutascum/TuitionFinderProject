using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSDProject1.Migrations
{
    /// <inheritdoc />
    public partial class TutorFix2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubjectsTutors");

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
                onDelete: ReferentialAction.Restrict);
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
    }
}
