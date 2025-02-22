﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolManagement.Infrastructure.Persistence.Context;

#nullable disable

namespace SchoolManagement.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    partial class SchoolDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SchoolManagement.Domain.Courses.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ec338b02-8e67-4db4-8f72-d30d714ec1a3"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 883, DateTimeKind.Utc).AddTicks(1038),
                            Title = "matematicas"
                        },
                        new
                        {
                            Id = new Guid("2bda8cc3-3b4b-4be6-bf59-695950d168e5"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 883, DateTimeKind.Utc).AddTicks(1043),
                            Title = "Informatica"
                        });
                });

            modelBuilder.Entity("SchoolManagement.Domain.Grades.Grade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Identification")
                        .HasColumnType("int");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("SchoolManagement.Domain.Students.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirsName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Identification")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Identification")
                        .IsUnique();

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = new Guid("26a6704e-df9d-4c9d-bfc0-d953db7d6b6f"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9261),
                            FirsName = "Juan",
                            Identification = "100000001",
                            LastName = "Lazo"
                        },
                        new
                        {
                            Id = new Guid("468b1e9d-c86b-4a6b-b611-d83785db01cb"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9268),
                            FirsName = "Laura",
                            Identification = "100000002",
                            LastName = "Villa"
                        },
                        new
                        {
                            Id = new Guid("ad4a4b0a-d57c-4a57-b451-75b457dc5c56"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9273),
                            FirsName = "Carlos",
                            Identification = "100000003",
                            LastName = "Ruiz"
                        },
                        new
                        {
                            Id = new Guid("b79a2595-fa35-436e-a8bf-df0aa3cd94ed"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9277),
                            FirsName = "Ana",
                            Identification = "100000004",
                            LastName = "García"
                        },
                        new
                        {
                            Id = new Guid("9e18cc85-3b63-4955-bfc1-fc1fcf935e22"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9291),
                            FirsName = "Pedro",
                            Identification = "100000005",
                            LastName = "Martínez"
                        },
                        new
                        {
                            Id = new Guid("39225a04-9c76-467c-a919-04b8daff76be"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9295),
                            FirsName = "María",
                            Identification = "100000006",
                            LastName = "Fernández"
                        },
                        new
                        {
                            Id = new Guid("930a604c-c215-4fe3-a3b3-874631bc0c22"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9300),
                            FirsName = "Jorge",
                            Identification = "100000007",
                            LastName = "López"
                        },
                        new
                        {
                            Id = new Guid("5b8c6bcf-87be-4e80-8ca3-e9255ba9dab3"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9305),
                            FirsName = "Luisa",
                            Identification = "100000008",
                            LastName = "Hernández"
                        },
                        new
                        {
                            Id = new Guid("2c1f393d-ccf3-4df1-a51d-32dc5c28c6e2"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9309),
                            FirsName = "Andrés",
                            Identification = "100000009",
                            LastName = "Pérez"
                        },
                        new
                        {
                            Id = new Guid("ecfecaf8-95a2-4f56-9a1d-ceb9c2a17159"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9313),
                            FirsName = "Camila",
                            Identification = "100000010",
                            LastName = "Ortiz"
                        },
                        new
                        {
                            Id = new Guid("35dc9989-e251-4b43-9548-e411d64c5479"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9318),
                            FirsName = "Mateo",
                            Identification = "100000011",
                            LastName = "Ramírez"
                        },
                        new
                        {
                            Id = new Guid("1984ee65-63d6-47f3-92a8-2a83f2e79ad0"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9322),
                            FirsName = "Sofía",
                            Identification = "100000012",
                            LastName = "Ríos"
                        },
                        new
                        {
                            Id = new Guid("85727793-531c-47ff-80c8-1280972b9589"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9330),
                            FirsName = "David",
                            Identification = "100000013",
                            LastName = "Morales"
                        },
                        new
                        {
                            Id = new Guid("2f54e577-ca16-4091-997f-a0c4bfa82770"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9335),
                            FirsName = "Valentina",
                            Identification = "100000014",
                            LastName = "Gómez"
                        },
                        new
                        {
                            Id = new Guid("58af6e8c-40ba-4a0d-a34e-946d231ce2ed"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9340),
                            FirsName = "Sebastián",
                            Identification = "100000015",
                            LastName = "Castro"
                        },
                        new
                        {
                            Id = new Guid("53213d96-019c-4e20-9321-8bd29b3b6561"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9344),
                            FirsName = "Isabella",
                            Identification = "100000016",
                            LastName = "Rojas"
                        },
                        new
                        {
                            Id = new Guid("920d97e0-ac40-4de3-a6bd-27fcea669e2c"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9348),
                            FirsName = "Daniel",
                            Identification = "100000017",
                            LastName = "Mendoza"
                        },
                        new
                        {
                            Id = new Guid("9912fac5-4e0d-44e0-95c3-b1df43ccc46e"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9352),
                            FirsName = "Fernanda",
                            Identification = "100000018",
                            LastName = "Reyes"
                        },
                        new
                        {
                            Id = new Guid("d8a0b901-0691-4956-9d16-338d934128bc"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9356),
                            FirsName = "Samuel",
                            Identification = "100000019",
                            LastName = "Cruz"
                        },
                        new
                        {
                            Id = new Guid("02678973-2132-4ce9-a659-7540f01f8e7e"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9361),
                            FirsName = "Mía",
                            Identification = "100000020",
                            LastName = "Peña"
                        },
                        new
                        {
                            Id = new Guid("26c01fc4-2619-441c-a4b0-de1ccef503af"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9369),
                            FirsName = "Gabriel",
                            Identification = "100000021",
                            LastName = "Pacheco"
                        },
                        new
                        {
                            Id = new Guid("561a8013-5599-48a8-9c77-daa956efb715"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9373),
                            FirsName = "Antonia",
                            Identification = "100000022",
                            LastName = "Vargas"
                        },
                        new
                        {
                            Id = new Guid("cf3eaa44-7168-42aa-bb9a-90dfcdbab73d"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9377),
                            FirsName = "Elías",
                            Identification = "100000023",
                            LastName = "Flores"
                        },
                        new
                        {
                            Id = new Guid("322b5393-a807-4cd9-8ecc-2993b9b00107"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9381),
                            FirsName = "Martina",
                            Identification = "100000024",
                            LastName = "Carvajal"
                        },
                        new
                        {
                            Id = new Guid("0df5c5d6-2bb3-4f33-accf-d96196c458a5"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9386),
                            FirsName = "Luciano",
                            Identification = "100000025",
                            LastName = "Navarro"
                        },
                        new
                        {
                            Id = new Guid("27f5193b-fc83-41fd-bea5-9175d6fde188"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9390),
                            FirsName = "Emma",
                            Identification = "100000026",
                            LastName = "Vera"
                        },
                        new
                        {
                            Id = new Guid("fc2549b2-bcdb-4e97-aaeb-68064e7eb3ae"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9395),
                            FirsName = "Tomás",
                            Identification = "100000027",
                            LastName = "Silva"
                        },
                        new
                        {
                            Id = new Guid("65c319b0-9cd7-4869-832b-99d77e0de206"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9399),
                            FirsName = "Abril",
                            Identification = "100000028",
                            LastName = "Salinas"
                        },
                        new
                        {
                            Id = new Guid("9712cfc0-f7d4-4ba8-8651-c9ea9f5ecd6d"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9407),
                            FirsName = "Nicolás",
                            Identification = "100000029",
                            LastName = "Acosta"
                        },
                        new
                        {
                            Id = new Guid("78423234-3daa-4b85-9886-52e3473c20e5"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9412),
                            FirsName = "Renata",
                            Identification = "100000030",
                            LastName = "Arce"
                        },
                        new
                        {
                            Id = new Guid("34f2da9f-c4f2-4bfd-a364-355c69a48d1f"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9417),
                            FirsName = "Agustín",
                            Identification = "100000031",
                            LastName = "Linares"
                        },
                        new
                        {
                            Id = new Guid("b37ad5d2-7040-45a0-9ffe-610ab2d1a424"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9422),
                            FirsName = "Bianca",
                            Identification = "100000032",
                            LastName = "Quintana"
                        },
                        new
                        {
                            Id = new Guid("bf0056a8-0436-4ab9-9dc1-65be9c27887a"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9426),
                            FirsName = "Maximiliano",
                            Identification = "100000033",
                            LastName = "Barrios"
                        },
                        new
                        {
                            Id = new Guid("29514d79-9540-426a-aa65-d5635161c4e5"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9430),
                            FirsName = "Julia",
                            Identification = "100000034",
                            LastName = "Fuentes"
                        },
                        new
                        {
                            Id = new Guid("86677101-6296-4dfb-bcb5-3fb9969b769d"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9434),
                            FirsName = "Felipe",
                            Identification = "100000035",
                            LastName = "Carrillo"
                        },
                        new
                        {
                            Id = new Guid("5331a0e3-b017-4671-8f2c-1aab6438a93f"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9439),
                            FirsName = "Regina",
                            Identification = "100000036",
                            LastName = "Medina"
                        },
                        new
                        {
                            Id = new Guid("c77d22d2-23ef-4632-9710-1475bb06d94c"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9447),
                            FirsName = "Simón",
                            Identification = "100000037",
                            LastName = "Escobar"
                        },
                        new
                        {
                            Id = new Guid("c0d52275-9b0e-4428-b242-7cd63d89562d"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9451),
                            FirsName = "Paulina",
                            Identification = "100000038",
                            LastName = "Campos"
                        },
                        new
                        {
                            Id = new Guid("a9cc7fc9-017f-452d-9e1e-ea8bbbabd434"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9456),
                            FirsName = "Iván",
                            Identification = "100000039",
                            LastName = "Villalobos"
                        },
                        new
                        {
                            Id = new Guid("58059391-7e16-4d1d-b492-a9a61fc9f8d5"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9461),
                            FirsName = "Alejandra",
                            Identification = "100000040",
                            LastName = "Delgado"
                        });
                });

            modelBuilder.Entity("SchoolManagement.Domain.Teachers.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Identification")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("85e10727-046e-4a80-865c-50ebd7cc2540"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 889, DateTimeKind.Utc).AddTicks(4034),
                            FirstName = "Lara",
                            Identification = 0,
                            LastName = "Bonilla"
                        },
                        new
                        {
                            Id = new Guid("5384ef99-2c02-4480-803e-5935915a443e"),
                            CreatedAt = new DateTime(2025, 1, 20, 21, 35, 37, 889, DateTimeKind.Utc).AddTicks(4045),
                            FirstName = "Julian",
                            Identification = 0,
                            LastName = "Caro"
                        });
                });

            modelBuilder.Entity("SchoolManagement.Domain.Courses.Course", b =>
                {
                    b.HasOne("SchoolManagement.Domain.Teachers.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("SchoolManagement.Domain.Grades.Grade", b =>
                {
                    b.HasOne("SchoolManagement.Domain.Courses.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolManagement.Domain.Students.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("SchoolManagement.Domain.Grades.GradeValue", "GradeValue", b1 =>
                        {
                            b1.Property<Guid>("GradeId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<decimal>("Value")
                                .HasColumnType("decimal(3,2)")
                                .HasColumnName("Value");

                            b1.HasKey("GradeId");

                            b1.ToTable("Grades");

                            b1.WithOwner()
                                .HasForeignKey("GradeId");
                        });

                    b.Navigation("Course");

                    b.Navigation("GradeValue")
                        .IsRequired();

                    b.Navigation("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
