using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VirtualLibrary.Repository.Migrations
{
    public partial class databaseOptimization2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3eef9a14-d738-49c0-91d1-3cab845db8c3"),
                column: "Name",
                value: "Nice Books");

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("c8dcaf61-9400-4907-866b-3f83f05361c4"),
                column: "Name",
                value: "Grenn Books");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3eef9a14-d738-49c0-91d1-3cab845db8c3"),
                column: "Name",
                value: "Grenn Books");

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("c8dcaf61-9400-4907-866b-3f83f05361c4"),
                column: "Name",
                value: "Nice Books");
        }
    }
}
