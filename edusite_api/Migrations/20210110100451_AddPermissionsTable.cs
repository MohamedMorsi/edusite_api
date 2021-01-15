using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Auth_API.Migrations
{
    public partial class AddPermissionsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    PermissionId = table.Column<Guid>(type: "char(36)", nullable: false),
                    PermissionName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.PermissionId);
                });





            migrationBuilder.CreateTable(
                name: "TenantsPermissions",
                columns: table => new
                {
                    PermissionsPermissionId = table.Column<Guid>(type: "char(36)", nullable: false),
                    TenantsTenantId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TenantsPermissions", x => new { x.PermissionsPermissionId, x.TenantsTenantId });
                    table.ForeignKey(
                        name: "FK_TenantsPermissions_Permissions_PermissionsPermissionId",
                        column: x => x.PermissionsPermissionId,
                        principalTable: "Permissions",
                        principalColumn: "PermissionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TenantsPermissions_Tenants_TenantsTenantId",
                        column: x => x.TenantsTenantId,
                        principalTable: "Tenants",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                });






            migrationBuilder.CreateIndex(
                name: "IX_TenantsPermissions_TenantsTenantId",
                table: "TenantsPermissions",
                column: "TenantsTenantId");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TenantsPermissions");



            migrationBuilder.DropTable(
                name: "Permissions");

        }
    }
}
