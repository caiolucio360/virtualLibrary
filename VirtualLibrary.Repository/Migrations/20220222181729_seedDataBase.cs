using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VirtualLibrary.Repository.Migrations
{
    public partial class seedDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "Email", "Gender", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("2e48902b-dda6-4b74-85f6-3025089eb0d9"), new DateTime(2008, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "caio@gmail.com", "Male", "Caio", "2625929829825" },
                    { new Guid("f7c93d0c-ea2e-489b-870f-089b333ef5ed"), new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fernanda@gmail.com", "Female", "Fernanda", "498749841984" },
                    { new Guid("ea61dabb-8237-4675-9b0a-925e2f95e2cb"), new DateTime(2002, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabriel@gmail.com", "Male", "Gabriel", "198493232312" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("b97b67a7-85a8-4b26-990d-65ca398ccbab"), "Nice Books" },
                    { new Guid("8224dcf3-3379-4a01-aee2-6444841bfa45"), "Grenn Books" },
                    { new Guid("9a3983e7-2976-4823-835d-6eba40f2e44f"), "Amazing Books" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2e48902b-dda6-4b74-85f6-3025089eb0d9"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ea61dabb-8237-4675-9b0a-925e2f95e2cb"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f7c93d0c-ea2e-489b-870f-089b333ef5ed"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("8224dcf3-3379-4a01-aee2-6444841bfa45"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9a3983e7-2976-4823-835d-6eba40f2e44f"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("b97b67a7-85a8-4b26-990d-65ca398ccbab"));
        }
    }
}
