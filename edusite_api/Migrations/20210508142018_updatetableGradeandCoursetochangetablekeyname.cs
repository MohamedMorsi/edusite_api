using Microsoft.EntityFrameworkCore.Migrations;

namespace edusite_api.Migrations
{
    public partial class updatetableGradeandCoursetochangetablekeyname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GradeId",
                table: "Grades",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Courses",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Grades",
                newName: "GradeId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Courses",
                newName: "CourseId");
        }
    }
}
