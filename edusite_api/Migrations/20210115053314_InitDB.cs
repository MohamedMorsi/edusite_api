using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace edusite_api.Migrations
{
    public partial class InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    FirstName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    LastName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    UserEmail = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Password = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    Language = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false, defaultValue: "en"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2021, 1, 15, 7, 33, 14, 569, DateTimeKind.Local).AddTicks(1705)),
                    ExpiryDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AccountId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
