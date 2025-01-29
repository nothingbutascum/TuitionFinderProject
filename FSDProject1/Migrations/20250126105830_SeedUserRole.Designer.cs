﻿// <auto-generated />
using System;
using FSDProject1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FSDProject1.Migrations
{
    [DbContext(typeof(FSDProject1Context))]
    [Migration("20250126105830_SeedUserRole")]
    partial class SeedUserRole
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FSDProject1.Data.FSDProject1User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("FSDProject1.Domain.AdminTutor", b =>
                {
                    b.Property<int>("AdminTutorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminTutorId"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("DateCreated")
                        .HasColumnType("date");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int>("TutorId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminTutorId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TutorId");

                    b.ToTable("AdminTutor");

                    b.HasData(
                        new
                        {
                            AdminTutorId = 1,
                            CreatedBy = "SystemAdmin",
                            DateCreated = new DateOnly(2025, 1, 1),
                            DateUpdated = new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            SubjectId = 1,
                            TutorId = 1,
                            UpdatedBy = "SystemAdmin"
                        },
                        new
                        {
                            AdminTutorId = 2,
                            CreatedBy = "AdminUser",
                            DateCreated = new DateOnly(2025, 1, 2),
                            DateUpdated = new DateTime(2025, 1, 2, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            SubjectId = 2,
                            TutorId = 2,
                            UpdatedBy = "AdminUser"
                        },
                        new
                        {
                            AdminTutorId = 3,
                            CreatedBy = "AdminAssistant",
                            DateCreated = new DateOnly(2025, 1, 3),
                            DateUpdated = new DateTime(2025, 1, 3, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            SubjectId = 3,
                            TutorId = 3,
                            UpdatedBy = "AdminAssistant"
                        });
                });

            modelBuilder.Entity("FSDProject1.Domain.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingID"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<int>("TutorID")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookingID");

                    b.HasIndex("StudentUserId");

                    b.HasIndex("TutorID");

                    b.ToTable("Booking");

                    b.HasData(
                        new
                        {
                            BookingID = 1,
                            CreatedBy = "SystemAdmin",
                            Date = new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateCreated = new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc),
                            DateUpdated = new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc),
                            Status = "Confirmed",
                            StudentUserId = 1,
                            Time = new DateTime(2025, 1, 10, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            TutorID = 1,
                            UpdatedBy = "SystemAdmin"
                        },
                        new
                        {
                            BookingID = 2,
                            CreatedBy = "AdminUser",
                            Date = new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateCreated = new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc),
                            DateUpdated = new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc),
                            Status = "Pending",
                            StudentUserId = 2,
                            Time = new DateTime(2025, 1, 11, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            TutorID = 2,
                            UpdatedBy = "AdminUser"
                        },
                        new
                        {
                            BookingID = 3,
                            CreatedBy = "AdminAssistant",
                            Date = new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateCreated = new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc),
                            DateUpdated = new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc),
                            Status = "Cancelled",
                            StudentUserId = 3,
                            Time = new DateTime(2025, 1, 12, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            TutorID = 3,
                            UpdatedBy = "AdminAssistant"
                        });
                });

            modelBuilder.Entity("FSDProject1.Domain.Reviews", b =>
                {
                    b.Property<string>("ReviewsId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Rating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReviewsId");

                    b.HasIndex("BookingId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewsId = "R001",
                            BookingId = 1,
                            Comments = "Excellent session! Very helpful and informative.",
                            CreatedBy = "Student1",
                            DateCreated = new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc),
                            DateUpdated = new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc),
                            Rating = "5",
                            UpdatedBy = "Student1"
                        },
                        new
                        {
                            ReviewsId = "R002",
                            BookingId = 2,
                            Comments = "Good session, but a bit rushed.",
                            CreatedBy = "Student2",
                            DateCreated = new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc),
                            DateUpdated = new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc),
                            Rating = "4",
                            UpdatedBy = "Student2"
                        },
                        new
                        {
                            ReviewsId = "R003",
                            BookingId = 3,
                            Comments = "Session was okay, could be improved.",
                            CreatedBy = "Student3",
                            DateCreated = new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc),
                            DateUpdated = new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc),
                            Rating = "3",
                            UpdatedBy = "Student3"
                        });
                });

            modelBuilder.Entity("FSDProject1.Domain.StudentUser", b =>
                {
                    b.Property<int>("StudentUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentUserId"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentUserId");

                    b.ToTable("StudentUser");

                    b.HasData(
                        new
                        {
                            StudentUserId = 1,
                            Age = 21,
                            CreatedBy = "SystemAdmin",
                            DateCreated = new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc),
                            DateUpdated = new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc),
                            Email = "johndoe@example.com",
                            Name = "John Doe",
                            UpdatedBy = "SystemAdmin"
                        },
                        new
                        {
                            StudentUserId = 2,
                            Age = 22,
                            CreatedBy = "AdminUser",
                            DateCreated = new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc),
                            DateUpdated = new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc),
                            Email = "janesmith@example.com",
                            Name = "Jane Smith",
                            UpdatedBy = "AdminUser"
                        },
                        new
                        {
                            StudentUserId = 3,
                            Age = 20,
                            CreatedBy = "AdminAssistant",
                            DateCreated = new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc),
                            DateUpdated = new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc),
                            Email = "alicejohnson@example.com",
                            Name = "Alice Johnson",
                            UpdatedBy = "AdminAssistant"
                        });
                });

            modelBuilder.Entity("FSDProject1.Domain.Subjects", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectId"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TutorId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubjectId");

                    b.HasIndex("TutorId");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            SubjectId = 1,
                            CreatedBy = "SystemAdmin",
                            DateCreated = new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc),
                            DateUpdated = new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Mathematics",
                            TutorId = 1,
                            UpdatedBy = "SystemAdmin"
                        },
                        new
                        {
                            SubjectId = 2,
                            CreatedBy = "AdminUser",
                            DateCreated = new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc),
                            DateUpdated = new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Physics",
                            TutorId = 2,
                            UpdatedBy = "AdminUser"
                        },
                        new
                        {
                            SubjectId = 3,
                            CreatedBy = "AdminAssistant",
                            DateCreated = new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc),
                            DateUpdated = new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Chemistry",
                            TutorId = 3,
                            UpdatedBy = "AdminAssistant"
                        });
                });

            modelBuilder.Entity("FSDProject1.Domain.Tutors", b =>
                {
                    b.Property<int>("TutorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TutorId"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Experience")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("HourlyRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qualification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Rating")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("StudentUserId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TutorId");

                    b.HasIndex("StudentUserId");

                    b.ToTable("Tutors");

                    b.HasData(
                        new
                        {
                            TutorId = 1,
                            CreatedBy = "SystemAdmin",
                            DateCreated = new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc),
                            DateUpdated = new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc),
                            Experience = "10 years of teaching experience",
                            HourlyRate = 50.00m,
                            Name = "Dr. John Smith",
                            Qualification = "PhD in Mathematics",
                            Rating = 4.8m,
                            StudentUserId = 1,
                            UpdatedBy = "SystemAdmin"
                        },
                        new
                        {
                            TutorId = 2,
                            CreatedBy = "AdminUser",
                            DateCreated = new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc),
                            DateUpdated = new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc),
                            Experience = "8 years of tutoring experience",
                            HourlyRate = 45.00m,
                            Name = "Ms. Jane Doe",
                            Qualification = "Master's in Physics",
                            Rating = 4.6m,
                            StudentUserId = 2,
                            UpdatedBy = "AdminUser"
                        },
                        new
                        {
                            TutorId = 3,
                            CreatedBy = "AdminAssistant",
                            DateCreated = new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc),
                            DateUpdated = new DateTime(2024, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc),
                            Experience = "15 years of academic experience",
                            HourlyRate = 60.00m,
                            Name = "Prof. Alice Brown",
                            Qualification = "PhD in Chemistry",
                            Rating = 4.9m,
                            StudentUserId = 3,
                            UpdatedBy = "AdminAssistant"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("FSDProject1.Domain.AdminTutor", b =>
                {
                    b.HasOne("FSDProject1.Domain.Subjects", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FSDProject1.Domain.Tutors", "Tutor")
                        .WithMany()
                        .HasForeignKey("TutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");

                    b.Navigation("Tutor");
                });

            modelBuilder.Entity("FSDProject1.Domain.Booking", b =>
                {
                    b.HasOne("FSDProject1.Domain.StudentUser", "StudentUser")
                        .WithMany("Bookings")
                        .HasForeignKey("StudentUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FSDProject1.Domain.Tutors", "Tutor")
                        .WithMany()
                        .HasForeignKey("TutorID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("StudentUser");

                    b.Navigation("Tutor");
                });

            modelBuilder.Entity("FSDProject1.Domain.Reviews", b =>
                {
                    b.HasOne("FSDProject1.Domain.Booking", "Booking")
                        .WithMany()
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("FSDProject1.Domain.Subjects", b =>
                {
                    b.HasOne("FSDProject1.Domain.Tutors", "Tutor")
                        .WithMany("Subjects")
                        .HasForeignKey("TutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tutor");
                });

            modelBuilder.Entity("FSDProject1.Domain.Tutors", b =>
                {
                    b.HasOne("FSDProject1.Domain.StudentUser", "StudentUser")
                        .WithMany()
                        .HasForeignKey("StudentUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StudentUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("FSDProject1.Data.FSDProject1User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("FSDProject1.Data.FSDProject1User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FSDProject1.Data.FSDProject1User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("FSDProject1.Data.FSDProject1User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FSDProject1.Domain.StudentUser", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("FSDProject1.Domain.Tutors", b =>
                {
                    b.Navigation("Subjects");
                });
#pragma warning restore 612, 618
        }
    }
}
