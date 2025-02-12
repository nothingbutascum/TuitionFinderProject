using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FSDProject1.Migrations
{
    /// <inheritdoc />
    public partial class Start : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentUser",
                columns: table => new
                {
                    StudentUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentUser", x => x.StudentUserId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tutors",
                columns: table => new
                {
                    TutorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qualification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Experience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HourlyRate = table.Column<int>(type: "int", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutors", x => x.TutorId);
                    table.ForeignKey(
                        name: "FK_Tutors_StudentUser_StudentUserId",
                        column: x => x.StudentUserId,
                        principalTable: "StudentUser",
                        principalColumn: "StudentUserId");
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    BookingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentUserId = table.Column<int>(type: "int", nullable: false),
                    TutorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.BookingID);
                    table.ForeignKey(
                        name: "FK_Booking_StudentUser_StudentUserId",
                        column: x => x.StudentUserId,
                        principalTable: "StudentUser",
                        principalColumn: "StudentUserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Booking_Tutors_TutorId",
                        column: x => x.TutorId,
                        principalTable: "Tutors",
                        principalColumn: "TutorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    SubjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TutorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.SubjectId);
                    table.ForeignKey(
                        name: "FK_Subjects_Tutors_TutorId",
                        column: x => x.TutorId,
                        principalTable: "Tutors",
                        principalColumn: "TutorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewsId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Rating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewsId);
                    table.ForeignKey(
                        name: "FK_Reviews_Booking_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Booking",
                        principalColumn: "BookingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdminTutor",
                columns: table => new
                {
                    AdminTutorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateOnly>(type: "date", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TutorId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminTutor", x => x.AdminTutorId);
                    table.ForeignKey(
                        name: "FK_AdminTutor_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdminTutor_Tutors_TutorId",
                        column: x => x.TutorId,
                        principalTable: "Tutors",
                        principalColumn: "TutorId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TutorSubject_Tutors_TutorId",
                        column: x => x.TutorId,
                        principalTable: "Tutors",
                        principalColumn: "TutorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "StudentUser",
                columns: new[] { "StudentUserId", "Age", "CreatedBy", "DateCreated", "DateUpdated", "Email", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 21, "SystemAdmin", new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), "johndoe@example.com", "John Doe", "SystemAdmin" },
                    { 2, 22, "AdminUser", new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), "janesmith@example.com", "Jane Smith", "AdminUser" },
                    { 3, 20, "AdminAssistant", new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), "alicejohnson@example.com", "Alice Johnson", "AdminAssistant" }
                });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "TutorId", "CreatedBy", "DateCreated", "DateUpdated", "Experience", "HourlyRate", "Name", "Qualification", "Rating", "StudentUserId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "SystemAdmin", new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), "10 years of teaching experience", 50, "Dr. John Smith", "PhD in Mathematics", 4, 1, "SystemAdmin" },
                    { 2, "AdminUser", new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), "8 years of tutoring experience", 45, "Ms. Jane Doe", "Master's in Physics", 4, 2, "AdminUser" },
                    { 3, "AdminAssistant", new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), "15 years of academic experience", 60, "Prof. Alice Brown", "PhD in Chemistry", 4, 3, "AdminAssistant" }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "BookingID", "CreatedBy", "Date", "DateCreated", "DateUpdated", "Status", "StudentUserId", "Time", "TutorId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "SystemAdmin", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), "Confirmed", 1, "10:00", 1, "SystemAdmin" },
                    { 2, "AdminUser", new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), "Pending", 2, "14:00", 2, "AdminUser" },
                    { 3, "AdminAssistant", new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), "Cancelled", 3, "16:00", 3, "AdminAssistant" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "CreatedBy", "DateCreated", "DateUpdated", "Name", "TutorId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "SystemAdmin", new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), "Mathematics", 1, "SystemAdmin" },
                    { 2, "AdminUser", new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), "Physics", 1, "AdminUser" },
                    { 3, "AdminAssistant", new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), "Chemistry", 3, "AdminAssistant" }
                });

            migrationBuilder.InsertData(
                table: "AdminTutor",
                columns: new[] { "AdminTutorId", "CreatedBy", "DateCreated", "DateUpdated", "SubjectId", "TutorId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "SystemAdmin", new DateOnly(2025, 1, 1), new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "SystemAdmin" },
                    { 2, "AdminUser", new DateOnly(2025, 1, 2), new DateTime(2025, 1, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "AdminUser" },
                    { 3, "AdminAssistant", new DateOnly(2025, 1, 3), new DateTime(2025, 1, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, "AdminAssistant" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewsId", "BookingId", "Comments", "CreatedBy", "DateCreated", "DateUpdated", "Rating", "UpdatedBy" },
                values: new object[,]
                {
                    { "R001", 1, "Excellent session! Very helpful and informative.", "Student1", new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), "5", "Student1" },
                    { "R002", 2, "Good session, but a bit rushed.", "Student2", new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), "4", "Student2" },
                    { "R003", 3, "Session was okay, could be improved.", "Student3", new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), "3", "Student3" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdminTutor_SubjectId",
                table: "AdminTutor",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminTutor_TutorId",
                table: "AdminTutor",
                column: "TutorId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_StudentUserId",
                table: "Booking",
                column: "StudentUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_TutorId",
                table: "Booking",
                column: "TutorId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BookingId",
                table: "Reviews",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_TutorId",
                table: "Subjects",
                column: "TutorId");

            migrationBuilder.CreateIndex(
                name: "IX_Tutors_StudentUserId",
                table: "Tutors",
                column: "StudentUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TutorSubject_TutorId",
                table: "TutorSubject",
                column: "TutorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminTutor");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "TutorSubject");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Tutors");

            migrationBuilder.DropTable(
                name: "StudentUser");
        }
    }
}
