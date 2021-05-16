using Microsoft.EntityFrameworkCore.Migrations;

namespace edusite_api.Migrations
{
    public partial class AddTeachersGradesRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeachersGrades_Grades_GradesId",
                table: "TeachersGrades");

            migrationBuilder.DropForeignKey(
                name: "FK_TeachersGrades_Teachers_TeachersTeacherId",
                table: "TeachersGrades");

            migrationBuilder.RenameColumn(
                name: "TeachersTeacherId",
                table: "TeachersGrades",
                newName: "GradeId");

            migrationBuilder.RenameColumn(
                name: "GradesId",
                table: "TeachersGrades",
                newName: "TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_TeachersGrades_TeachersTeacherId",
                table: "TeachersGrades",
                newName: "IX_TeachersGrades_GradeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeachersGrades_Grades_GradeId",
                table: "TeachersGrades",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeachersGrades_Teachers_TeacherId",
                table: "TeachersGrades",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeachersGrades_Grades_GradeId",
                table: "TeachersGrades");

            migrationBuilder.DropForeignKey(
                name: "FK_TeachersGrades_Teachers_TeacherId",
                table: "TeachersGrades");

            migrationBuilder.RenameColumn(
                name: "GradeId",
                table: "TeachersGrades",
                newName: "TeachersTeacherId");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "TeachersGrades",
                newName: "GradesId");

            migrationBuilder.RenameIndex(
                name: "IX_TeachersGrades_GradeId",
                table: "TeachersGrades",
                newName: "IX_TeachersGrades_TeachersTeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeachersGrades_Grades_GradesId",
                table: "TeachersGrades",
                column: "GradesId",
                principalTable: "Grades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeachersGrades_Teachers_TeachersTeacherId",
                table: "TeachersGrades",
                column: "TeachersTeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
