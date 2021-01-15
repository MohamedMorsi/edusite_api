using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Auth_API.Migrations
{
    public partial class CurrentActiveUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 14, 10, 16, 58, 663, DateTimeKind.Local).AddTicks(4271),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 1, 10, 12, 4, 51, 358, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Tenants",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 14, 10, 16, 58, 656, DateTimeKind.Local).AddTicks(1411),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 1, 10, 12, 4, 51, 352, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 14, 10, 16, 58, 657, DateTimeKind.Local).AddTicks(2939),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 1, 10, 12, 4, 51, 353, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.CreateTable(
                name: "CurrentActiveUsers",
                columns: table => new
                {
                    CurrentActiveUserId = table.Column<Guid>(type: "char(36)", nullable: false),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: false),
                    UserToken = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentActiveUsers", x => x.CurrentActiveUserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurrentActiveUsers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 10, 12, 4, 51, 358, DateTimeKind.Local).AddTicks(444),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 1, 14, 10, 16, 58, 663, DateTimeKind.Local).AddTicks(4271));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Tenants",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 10, 12, 4, 51, 352, DateTimeKind.Local).AddTicks(4357),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 1, 14, 10, 16, 58, 656, DateTimeKind.Local).AddTicks(1411));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 10, 12, 4, 51, 353, DateTimeKind.Local).AddTicks(6922),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 1, 14, 10, 16, 58, 657, DateTimeKind.Local).AddTicks(2939));
        }
    }
}
