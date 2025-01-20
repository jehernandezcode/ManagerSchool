using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagement.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addseeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CreatedAt", "DeleteAt", "TeacherId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2bda8cc3-3b4b-4be6-bf59-695950d168e5"), new DateTime(2025, 1, 20, 21, 35, 37, 883, DateTimeKind.Utc).AddTicks(1043), null, null, "Informatica", null },
                    { new Guid("ec338b02-8e67-4db4-8f72-d30d714ec1a3"), new DateTime(2025, 1, 20, 21, 35, 37, 883, DateTimeKind.Utc).AddTicks(1038), null, null, "matematicas", null }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedAt", "DeleteAt", "FirsName", "Identification", "LastName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("02678973-2132-4ce9-a659-7540f01f8e7e"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9361), null, "Mía", "100000020", "Peña", null },
                    { new Guid("0df5c5d6-2bb3-4f33-accf-d96196c458a5"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9386), null, "Luciano", "100000025", "Navarro", null },
                    { new Guid("1984ee65-63d6-47f3-92a8-2a83f2e79ad0"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9322), null, "Sofía", "100000012", "Ríos", null },
                    { new Guid("26a6704e-df9d-4c9d-bfc0-d953db7d6b6f"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9261), null, "Juan", "100000001", "Lazo", null },
                    { new Guid("26c01fc4-2619-441c-a4b0-de1ccef503af"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9369), null, "Gabriel", "100000021", "Pacheco", null },
                    { new Guid("27f5193b-fc83-41fd-bea5-9175d6fde188"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9390), null, "Emma", "100000026", "Vera", null },
                    { new Guid("29514d79-9540-426a-aa65-d5635161c4e5"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9430), null, "Julia", "100000034", "Fuentes", null },
                    { new Guid("2c1f393d-ccf3-4df1-a51d-32dc5c28c6e2"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9309), null, "Andrés", "100000009", "Pérez", null },
                    { new Guid("2f54e577-ca16-4091-997f-a0c4bfa82770"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9335), null, "Valentina", "100000014", "Gómez", null },
                    { new Guid("322b5393-a807-4cd9-8ecc-2993b9b00107"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9381), null, "Martina", "100000024", "Carvajal", null },
                    { new Guid("34f2da9f-c4f2-4bfd-a364-355c69a48d1f"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9417), null, "Agustín", "100000031", "Linares", null },
                    { new Guid("35dc9989-e251-4b43-9548-e411d64c5479"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9318), null, "Mateo", "100000011", "Ramírez", null },
                    { new Guid("39225a04-9c76-467c-a919-04b8daff76be"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9295), null, "María", "100000006", "Fernández", null },
                    { new Guid("468b1e9d-c86b-4a6b-b611-d83785db01cb"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9268), null, "Laura", "100000002", "Villa", null },
                    { new Guid("53213d96-019c-4e20-9321-8bd29b3b6561"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9344), null, "Isabella", "100000016", "Rojas", null },
                    { new Guid("5331a0e3-b017-4671-8f2c-1aab6438a93f"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9439), null, "Regina", "100000036", "Medina", null },
                    { new Guid("561a8013-5599-48a8-9c77-daa956efb715"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9373), null, "Antonia", "100000022", "Vargas", null },
                    { new Guid("58059391-7e16-4d1d-b492-a9a61fc9f8d5"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9461), null, "Alejandra", "100000040", "Delgado", null },
                    { new Guid("58af6e8c-40ba-4a0d-a34e-946d231ce2ed"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9340), null, "Sebastián", "100000015", "Castro", null },
                    { new Guid("5b8c6bcf-87be-4e80-8ca3-e9255ba9dab3"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9305), null, "Luisa", "100000008", "Hernández", null },
                    { new Guid("65c319b0-9cd7-4869-832b-99d77e0de206"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9399), null, "Abril", "100000028", "Salinas", null },
                    { new Guid("78423234-3daa-4b85-9886-52e3473c20e5"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9412), null, "Renata", "100000030", "Arce", null },
                    { new Guid("85727793-531c-47ff-80c8-1280972b9589"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9330), null, "David", "100000013", "Morales", null },
                    { new Guid("86677101-6296-4dfb-bcb5-3fb9969b769d"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9434), null, "Felipe", "100000035", "Carrillo", null },
                    { new Guid("920d97e0-ac40-4de3-a6bd-27fcea669e2c"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9348), null, "Daniel", "100000017", "Mendoza", null },
                    { new Guid("930a604c-c215-4fe3-a3b3-874631bc0c22"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9300), null, "Jorge", "100000007", "López", null },
                    { new Guid("9712cfc0-f7d4-4ba8-8651-c9ea9f5ecd6d"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9407), null, "Nicolás", "100000029", "Acosta", null },
                    { new Guid("9912fac5-4e0d-44e0-95c3-b1df43ccc46e"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9352), null, "Fernanda", "100000018", "Reyes", null },
                    { new Guid("9e18cc85-3b63-4955-bfc1-fc1fcf935e22"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9291), null, "Pedro", "100000005", "Martínez", null },
                    { new Guid("a9cc7fc9-017f-452d-9e1e-ea8bbbabd434"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9456), null, "Iván", "100000039", "Villalobos", null },
                    { new Guid("ad4a4b0a-d57c-4a57-b451-75b457dc5c56"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9273), null, "Carlos", "100000003", "Ruiz", null },
                    { new Guid("b37ad5d2-7040-45a0-9ffe-610ab2d1a424"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9422), null, "Bianca", "100000032", "Quintana", null },
                    { new Guid("b79a2595-fa35-436e-a8bf-df0aa3cd94ed"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9277), null, "Ana", "100000004", "García", null },
                    { new Guid("bf0056a8-0436-4ab9-9dc1-65be9c27887a"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9426), null, "Maximiliano", "100000033", "Barrios", null },
                    { new Guid("c0d52275-9b0e-4428-b242-7cd63d89562d"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9451), null, "Paulina", "100000038", "Campos", null },
                    { new Guid("c77d22d2-23ef-4632-9710-1475bb06d94c"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9447), null, "Simón", "100000037", "Escobar", null },
                    { new Guid("cf3eaa44-7168-42aa-bb9a-90dfcdbab73d"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9377), null, "Elías", "100000023", "Flores", null },
                    { new Guid("d8a0b901-0691-4956-9d16-338d934128bc"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9356), null, "Samuel", "100000019", "Cruz", null },
                    { new Guid("ecfecaf8-95a2-4f56-9a1d-ceb9c2a17159"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9313), null, "Camila", "100000010", "Ortiz", null },
                    { new Guid("fc2549b2-bcdb-4e97-aaeb-68064e7eb3ae"), new DateTime(2025, 1, 20, 21, 35, 37, 888, DateTimeKind.Utc).AddTicks(9395), null, "Tomás", "100000027", "Silva", null }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CreatedAt", "DeleteAt", "FirstName", "Identification", "LastName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("5384ef99-2c02-4480-803e-5935915a443e"), new DateTime(2025, 1, 20, 21, 35, 37, 889, DateTimeKind.Utc).AddTicks(4045), null, "Julian", 0, "Caro", null },
                    { new Guid("85e10727-046e-4a80-865c-50ebd7cc2540"), new DateTime(2025, 1, 20, 21, 35, 37, 889, DateTimeKind.Utc).AddTicks(4034), null, "Lara", 0, "Bonilla", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("2bda8cc3-3b4b-4be6-bf59-695950d168e5"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("ec338b02-8e67-4db4-8f72-d30d714ec1a3"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("02678973-2132-4ce9-a659-7540f01f8e7e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("0df5c5d6-2bb3-4f33-accf-d96196c458a5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("1984ee65-63d6-47f3-92a8-2a83f2e79ad0"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("26a6704e-df9d-4c9d-bfc0-d953db7d6b6f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("26c01fc4-2619-441c-a4b0-de1ccef503af"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("27f5193b-fc83-41fd-bea5-9175d6fde188"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("29514d79-9540-426a-aa65-d5635161c4e5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2c1f393d-ccf3-4df1-a51d-32dc5c28c6e2"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2f54e577-ca16-4091-997f-a0c4bfa82770"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("322b5393-a807-4cd9-8ecc-2993b9b00107"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("34f2da9f-c4f2-4bfd-a364-355c69a48d1f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("35dc9989-e251-4b43-9548-e411d64c5479"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("39225a04-9c76-467c-a919-04b8daff76be"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("468b1e9d-c86b-4a6b-b611-d83785db01cb"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("53213d96-019c-4e20-9321-8bd29b3b6561"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("5331a0e3-b017-4671-8f2c-1aab6438a93f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("561a8013-5599-48a8-9c77-daa956efb715"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("58059391-7e16-4d1d-b492-a9a61fc9f8d5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("58af6e8c-40ba-4a0d-a34e-946d231ce2ed"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("5b8c6bcf-87be-4e80-8ca3-e9255ba9dab3"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("65c319b0-9cd7-4869-832b-99d77e0de206"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("78423234-3daa-4b85-9886-52e3473c20e5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("85727793-531c-47ff-80c8-1280972b9589"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("86677101-6296-4dfb-bcb5-3fb9969b769d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("920d97e0-ac40-4de3-a6bd-27fcea669e2c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("930a604c-c215-4fe3-a3b3-874631bc0c22"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("9712cfc0-f7d4-4ba8-8651-c9ea9f5ecd6d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("9912fac5-4e0d-44e0-95c3-b1df43ccc46e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("9e18cc85-3b63-4955-bfc1-fc1fcf935e22"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a9cc7fc9-017f-452d-9e1e-ea8bbbabd434"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("ad4a4b0a-d57c-4a57-b451-75b457dc5c56"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("b37ad5d2-7040-45a0-9ffe-610ab2d1a424"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("b79a2595-fa35-436e-a8bf-df0aa3cd94ed"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("bf0056a8-0436-4ab9-9dc1-65be9c27887a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c0d52275-9b0e-4428-b242-7cd63d89562d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c77d22d2-23ef-4632-9710-1475bb06d94c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("cf3eaa44-7168-42aa-bb9a-90dfcdbab73d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d8a0b901-0691-4956-9d16-338d934128bc"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("ecfecaf8-95a2-4f56-9a1d-ceb9c2a17159"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fc2549b2-bcdb-4e97-aaeb-68064e7eb3ae"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("5384ef99-2c02-4480-803e-5935915a443e"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("85e10727-046e-4a80-865c-50ebd7cc2540"));
        }
    }
}
