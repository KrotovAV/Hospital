﻿// <auto-generated />
using System;
using HospitalDataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HospitalDataLayer.Migrations
{
    [DbContext(typeof(HospitalContext))]
    [Migration("20240910065431_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HospitalDataLayer.Entityes.Cabinet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Num")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK_Cabinet");

                    b.ToTable("Cabinet", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Num = 11
                        },
                        new
                        {
                            Id = 2,
                            Num = 12
                        },
                        new
                        {
                            Id = 3,
                            Num = 13
                        },
                        new
                        {
                            Id = 4,
                            Num = 21
                        },
                        new
                        {
                            Id = 5,
                            Num = 22
                        },
                        new
                        {
                            Id = 6,
                            Num = 23
                        },
                        new
                        {
                            Id = 7,
                            Num = 24
                        },
                        new
                        {
                            Id = 8,
                            Num = 25
                        });
                });

            modelBuilder.Entity("HospitalDataLayer.Entityes.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Num")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK_District");

                    b.ToTable("District", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Num = 1
                        },
                        new
                        {
                            Id = 2,
                            Num = 2
                        },
                        new
                        {
                            Id = 3,
                            Num = 3
                        });
                });

            modelBuilder.Entity("HospitalDataLayer.Entityes.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CabinetId")
                        .HasColumnType("int");

                    b.Property<int?>("DistrictId")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("SpecializationId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK_Doctor");

                    b.HasIndex("CabinetId");

                    b.HasIndex("DistrictId");

                    b.HasIndex("SpecializationId");

                    b.ToTable("Doctor", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CabinetId = 1,
                            DistrictId = 1,
                            FullName = "Сергеев Сергей Сергеевич",
                            SpecializationId = 1
                        },
                        new
                        {
                            Id = 2,
                            CabinetId = 2,
                            DistrictId = 1,
                            FullName = "Иванов Иван Иванович",
                            SpecializationId = 2
                        },
                        new
                        {
                            Id = 3,
                            CabinetId = 3,
                            DistrictId = 1,
                            FullName = "Дмитриев Дмитрий Дмитриевич",
                            SpecializationId = 3
                        },
                        new
                        {
                            Id = 4,
                            CabinetId = 4,
                            DistrictId = 1,
                            FullName = "Александров Александр Александрович",
                            SpecializationId = 4
                        },
                        new
                        {
                            Id = 5,
                            CabinetId = 5,
                            DistrictId = 2,
                            FullName = "Михайлов Михаил Михайлович",
                            SpecializationId = 5
                        },
                        new
                        {
                            Id = 6,
                            CabinetId = 6,
                            DistrictId = 2,
                            FullName = "Романов Роман Романович",
                            SpecializationId = 5
                        },
                        new
                        {
                            Id = 7,
                            CabinetId = 7,
                            DistrictId = 3,
                            FullName = "Викторов Виктор Викторович",
                            SpecializationId = 1
                        });
                });

            modelBuilder.Entity("HospitalDataLayer.Entityes.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("BirthdayDate")
                        .HasColumnType("datetime");

                    b.Property<int>("DistrictId")
                        .HasColumnType("int");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Patronymic")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id")
                        .HasName("PK_Patient");

                    b.HasIndex("DistrictId");

                    b.ToTable("Patient", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Тенистая, д.11, кв.1",
                            BirthdayDate = new DateTime(1991, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DistrictId = 1,
                            Gender = true,
                            Name = "Петр",
                            Patronymic = "Петрович",
                            Surname = "Петров"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Тенистая, д.22, кв.2",
                            BirthdayDate = new DateTime(1992, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DistrictId = 1,
                            Gender = false,
                            Name = "Ольгович",
                            Patronymic = "Олеговна",
                            Surname = "Ольга"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Горная, д.33, кв.3",
                            BirthdayDate = new DateTime(1993, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DistrictId = 2,
                            Gender = true,
                            Name = "Пашутов",
                            Patronymic = "Павлович",
                            Surname = "Павел"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Горная, д.44, кв.4",
                            BirthdayDate = new DateTime(1994, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DistrictId = 2,
                            Gender = true,
                            Name = "Васильев",
                            Patronymic = "Васильевич",
                            Surname = "Василий"
                        },
                        new
                        {
                            Id = 5,
                            Address = "Васильковая, д.55, кв.5",
                            BirthdayDate = new DateTime(1995, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DistrictId = 3,
                            Gender = true,
                            Name = "Антонов",
                            Patronymic = "Антонович",
                            Surname = "Антон"
                        },
                        new
                        {
                            Id = 6,
                            Address = "Васильковая, д.66, кв.6",
                            BirthdayDate = new DateTime(1996, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DistrictId = 3,
                            Gender = true,
                            Name = "Геннадьев",
                            Patronymic = "Геннадьевич",
                            Surname = "Геннадий"
                        },
                        new
                        {
                            Id = 7,
                            Address = "Васильковая, д.77, кв.7",
                            BirthdayDate = new DateTime(1997, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DistrictId = 3,
                            Gender = false,
                            Name = "Александрова",
                            Patronymic = "Александровна",
                            Surname = "Александра"
                        });
                });

            modelBuilder.Entity("HospitalDataLayer.Entityes.Specialization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("PK_Specialization");

                    b.ToTable("Specialization", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Педиатр"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Кардиолог"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Хирург"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Окулист"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Терапевт"
                        });
                });

            modelBuilder.Entity("HospitalDataLayer.Entityes.Doctor", b =>
                {
                    b.HasOne("HospitalDataLayer.Entityes.Cabinet", "Cabinet")
                        .WithMany("Doctors")
                        .HasForeignKey("CabinetId")
                        .IsRequired()
                        .HasConstraintName("FK_Doctor_Cabinet");

                    b.HasOne("HospitalDataLayer.Entityes.District", "District")
                        .WithMany("Doctors")
                        .HasForeignKey("DistrictId")
                        .HasConstraintName("FK_Doctor_District");

                    b.HasOne("HospitalDataLayer.Entityes.Specialization", "Specialization")
                        .WithMany("Doctors")
                        .HasForeignKey("SpecializationId")
                        .IsRequired()
                        .HasConstraintName("FK_Doctor_Specialization");

                    b.Navigation("Cabinet");

                    b.Navigation("District");

                    b.Navigation("Specialization");
                });

            modelBuilder.Entity("HospitalDataLayer.Entityes.Patient", b =>
                {
                    b.HasOne("HospitalDataLayer.Entityes.District", "District")
                        .WithMany("Patients")
                        .HasForeignKey("DistrictId")
                        .IsRequired()
                        .HasConstraintName("FK_Patient_District");

                    b.Navigation("District");
                });

            modelBuilder.Entity("HospitalDataLayer.Entityes.Cabinet", b =>
                {
                    b.Navigation("Doctors");
                });

            modelBuilder.Entity("HospitalDataLayer.Entityes.District", b =>
                {
                    b.Navigation("Doctors");

                    b.Navigation("Patients");
                });

            modelBuilder.Entity("HospitalDataLayer.Entityes.Specialization", b =>
                {
                    b.Navigation("Doctors");
                });
#pragma warning restore 612, 618
        }
    }
}
