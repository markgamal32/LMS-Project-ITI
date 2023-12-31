﻿// <auto-generated />
using System;
using FinalProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinalProject.Migrations
{
    [DbContext(typeof(HRContext))]
    [Migration("20230712073600_reports")]
    partial class reports
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FinalProject.Models.AttendanceReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("AttendanceReport");
                });

            modelBuilder.Entity("FinalProject.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("FinalProject.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ssn")
                        .HasColumnType("int");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("attend_from")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("attend_to")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("birth_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("deleted_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("dept_id")
                        .HasColumnType("int");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("hire_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("job_title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("national_number")
                        .HasColumnType("bigint");

                    b.Property<string>("nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("phone")
                        .HasColumnType("bigint");

                    b.Property<double>("salary")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("Ssn")
                        .IsUnique();

                    b.HasIndex("dept_id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("FinalProject.Models.EmployeeAttendance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("AttendForm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("AttendTo")
                        .HasColumnType("datetime2");

                    b.Property<int>("AttendanceReportId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CheckIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("DeductionHours")
                        .HasColumnType("time");

                    b.Property<double>("DeductionValue")
                        .HasColumnType("float");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsVacation")
                        .HasColumnType("bit");

                    b.Property<TimeSpan>("OverTimeHours")
                        .HasColumnType("time");

                    b.Property<double>("OverTimeValue")
                        .HasColumnType("float");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<double>("SalaryPerHour")
                        .HasColumnType("float");

                    b.Property<string>("VacationName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AttendanceReportId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeAttendance");
                });

            modelBuilder.Entity("FinalProject.Models.GeneralSettings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("add_hours")
                        .HasColumnType("float");

                    b.Property<double>("sub_hours")
                        .HasColumnType("float");

                    b.Property<string>("weekly_vacation1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("weekly_vacation2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GeneralSettings");
                });

            modelBuilder.Entity("FinalProject.Models.Vacation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vacations");
                });

            modelBuilder.Entity("FinalProject.Models.AttendanceReport", b =>
                {
                    b.HasOne("FinalProject.Models.Employee", "Employee")
                        .WithMany("AttendanceReport")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("FinalProject.Models.Employee", b =>
                {
                    b.HasOne("FinalProject.Models.Department", "Department")
                        .WithMany("Employee")
                        .HasForeignKey("dept_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("FinalProject.Models.EmployeeAttendance", b =>
                {
                    b.HasOne("FinalProject.Models.AttendanceReport", "AttendanceReport")
                        .WithMany("EmployeeAttendance")
                        .HasForeignKey("AttendanceReportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalProject.Models.Employee", "Employee")
                        .WithMany("EmployeeAttendances")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AttendanceReport");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("FinalProject.Models.AttendanceReport", b =>
                {
                    b.Navigation("EmployeeAttendance");
                });

            modelBuilder.Entity("FinalProject.Models.Department", b =>
                {
                    b.Navigation("Employee");
                });

            modelBuilder.Entity("FinalProject.Models.Employee", b =>
                {
                    b.Navigation("AttendanceReport");

                    b.Navigation("EmployeeAttendances");
                });
#pragma warning restore 612, 618
        }
    }
}
