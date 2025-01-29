using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FSDProject1.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Makes",
                table: "StudentUser");

            migrationBuilder.InsertData(
                table: "StudentUser",
                columns: new[] { "StudentUserId", "Age", "CreatedBy", "DateCreated", "DateUpdated", "Email", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 21, "SystemAdmin", new DateTime(2025, 1, 26, 9, 0, 0, 364, DateTimeKind.Utc).AddTicks(1013), new DateTime(2025, 1, 26, 9, 0, 0, 364, DateTimeKind.Utc).AddTicks(1014), "johndoe@example.com", "John Doe", "SystemAdmin" },
                    { 2, 22, "AdminUser", new DateTime(2025, 1, 26, 9, 0, 0, 364, DateTimeKind.Utc).AddTicks(1022), new DateTime(2025, 1, 26, 9, 0, 0, 364, DateTimeKind.Utc).AddTicks(1022), "janesmith@example.com", "Jane Smith", "AdminUser" },
                    { 3, 20, "AdminAssistant", new DateTime(2025, 1, 26, 9, 0, 0, 364, DateTimeKind.Utc).AddTicks(1026), new DateTime(2025, 1, 26, 9, 0, 0, 364, DateTimeKind.Utc).AddTicks(1026), "alicejohnson@example.com", "Alice Johnson", "AdminAssistant" }
                });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "TutorId", "CreatedBy", "DateCreated", "DateUpdated", "Experience", "HourlyRate", "Name", "Qualification", "Rating", "StudentUserId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "SystemAdmin", new DateTime(2025, 1, 26, 9, 0, 0, 364, DateTimeKind.Utc).AddTicks(1577), new DateTime(2025, 1, 26, 9, 0, 0, 364, DateTimeKind.Utc).AddTicks(1578), "10 years of teaching experience", 50.00m, "Dr. John Smith", "PhD in Mathematics", 4.8m, 1, "SystemAdmin" },
                    { 2, "AdminUser", new DateTime(2025, 1, 26, 9, 0, 0, 364, DateTimeKind.Utc).AddTicks(1584), new DateTime(2025, 1, 26, 9, 0, 0, 364, DateTimeKind.Utc).AddTicks(1585), "8 years of tutoring experience", 45.00m, "Ms. Jane Doe", "Master's in Physics", 4.6m, 2, "AdminUser" },
                    { 3, "AdminAssistant", new DateTime(2025, 1, 26, 9, 0, 0, 364, DateTimeKind.Utc).AddTicks(1589), new DateTime(2025, 1, 26, 9, 0, 0, 364, DateTimeKind.Utc).AddTicks(1590), "15 years of academic experience", 60.00m, "Prof. Alice Brown", "PhD in Chemistry", 4.9m, 3, "AdminAssistant" }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "BookingID", "CreatedBy", "Date", "DateCreated", "DateUpdated", "Status", "StudentUserId", "Time", "TutorID", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "SystemAdmin", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 26, 9, 0, 0, 364, DateTimeKind.Utc).AddTicks(1810), new DateTime(2025, 1, 26, 9, 0, 0, 364, DateTimeKind.Utc).AddTicks(1811), "Confirmed", 1, new DateTime(2025, 1, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, "SystemAdmin" },
                    { 2, "AdminUser", new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 26, 9, 0, 0, 364, DateTimeKind.Utc).AddTicks(1816), new DateTime(2025, 1, 26, 9, 0, 0, 364, DateTimeKind.Utc).AddTicks(1817), "Pending", 2, new DateTime(2025, 1, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, "AdminUser" },
                    { 3, "AdminAssistant", new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 26, 9, 0, 0, 364, DateTimeKind.Utc).AddTicks(1822), new DateTime(2025, 1, 26, 9, 0, 0, 364, DateTimeKind.Utc).AddTicks(1822), "Cancelled", 3, new DateTime(2025, 1, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, "AdminAssistant" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "CreatedBy", "DateCreated", "DateUpdated", "Name", "TutorId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "SystemAdmin", new DateTime(2025, 1, 26, 9, 0, 0, 364, DateTimeKind.Utc).AddTicks(1250), new DateTime(2025, 1, 26, 9, 0, 0, 364, DateTimeKind.Utc).AddTicks(1251), "Mathematics", 1, "SystemAdmin" },
                    { 2, "AdminUser", new DateTime(2025, 1, 26, 9, 0, 0, 364, DateTimeKind.Utc).AddTicks(1255), new DateTime(2025, 1, 26, 9, 0, 0, 364, DateTimeKind.Utc).AddTicks(1256), "Physics", 2, "AdminUser" },
                    { 3, "AdminAssistant", new DateTime(2025, 1, 26, 9, 0, 0, 364, DateTimeKind.Utc).AddTicks(1259), new DateTime(2025, 1, 26, 9, 0, 0, 364, DateTimeKind.Utc).AddTicks(1260), "Chemistry", 3, "AdminAssistant" }
                });

            migrationBuilder.InsertData(
                table: "AdminTutor",
                columns: new[] { "AdminTutorId", "CreatedBy", "DateCreated", "DateUpdated", "SubjectId", "TutorId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "SystemAdmin", new DateOnly(2025, 1, 1), new DateTime(2025, 1, 26, 9, 0, 0, 364, DateTimeKind.Utc).AddTicks(343), 1, 1, "SystemAdmin" },
                    { 2, "AdminUser", new DateOnly(2025, 1, 2), new DateTime(2025, 1, 26, 9, 0, 0, 364, DateTimeKind.Utc).AddTicks(354), 2, 2, "AdminUser" },
                    { 3, "AdminAssistant", new DateOnly(2025, 1, 3), new DateTime(2025, 1, 26, 9, 0, 0, 364, DateTimeKind.Utc).AddTicks(358), 3, 3, "AdminAssistant" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewsId", "BookingId", "Comments", "CreatedBy", "DateCreated", "DateUpdated", "Rating", "UpdatedBy" },
                values: new object[,]
                {
                    { "R001", 1, "Excellent session! Very helpful and informative.", "Student1", new DateTime(2025, 1, 26, 9, 0, 0, 364, DateTimeKind.Utc).AddTicks(2027), new DateTime(2025, 1, 26, 9, 0, 0, 364, DateTimeKind.Utc).AddTicks(2028), "5", "Student1" },
                    { "R002", 2, "Good session, but a bit rushed.", "Student2", new DateTime(2025, 1, 26, 9, 0, 0, 364, DateTimeKind.Utc).AddTicks(2033), new DateTime(2025, 1, 26, 9, 0, 0, 364, DateTimeKind.Utc).AddTicks(2034), "4", "Student2" },
                    { "R003", 3, "Session was okay, could be improved.", "Student3", new DateTime(2025, 1, 26, 9, 0, 0, 364, DateTimeKind.Utc).AddTicks(2037), new DateTime(2025, 1, 26, 9, 0, 0, 364, DateTimeKind.Utc).AddTicks(2038), "3", "Student3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdminTutor",
                keyColumn: "AdminTutorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AdminTutor",
                keyColumn: "AdminTutorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AdminTutor",
                keyColumn: "AdminTutorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewsId",
                keyValue: "R001");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewsId",
                keyValue: "R002");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewsId",
                keyValue: "R003");

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "TutorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "TutorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "TutorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StudentUser",
                keyColumn: "StudentUserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StudentUser",
                keyColumn: "StudentUserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StudentUser",
                keyColumn: "StudentUserId",
                keyValue: 3);

            migrationBuilder.AddColumn<int>(
                name: "Makes",
                table: "StudentUser",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
