using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoProject.Migrations
{
    public partial class AddDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(maxLength: 100, nullable: true),
                    Password = table.Column<string>(maxLength: 100, nullable: true),
                    First_Name = table.Column<string>(maxLength: 100, nullable: true),
                    Last_Name = table.Column<string>(maxLength: 100, nullable: true),
                    Phone_No = table.Column<long>(nullable: false),
                    Designation = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WasteConsumers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(maxLength: 100, nullable: true),
                    Password = table.Column<string>(maxLength: 100, nullable: true),
                    First_Name = table.Column<string>(maxLength: 100, nullable: true),
                    Last_Name = table.Column<string>(maxLength: 100, nullable: true),
                    Phone_No = table.Column<long>(nullable: false),
                    Purchased_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WasteConsumers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WasteProducers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(maxLength: 100, nullable: true),
                    Password = table.Column<string>(maxLength: 100, nullable: true),
                    First_Name = table.Column<string>(maxLength: 100, nullable: true),
                    Last_Name = table.Column<string>(maxLength: 100, nullable: true),
                    Phone_No = table.Column<long>(nullable: false),
                    Created_at = table.Column<DateTime>(nullable: false),
                    Updated_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WasteProducers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "WasteConsumers");

            migrationBuilder.DropTable(
                name: "WasteProducers");
        }
    }
}
