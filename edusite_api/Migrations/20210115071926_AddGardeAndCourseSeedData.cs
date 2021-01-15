using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace edusite_api.Migrations
{
    public partial class AddGardeAndCourseSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Teachers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 15, 9, 19, 26, 383, DateTimeKind.Local).AddTicks(5119),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 1, 15, 9, 3, 47, 269, DateTimeKind.Local).AddTicks(1703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Students",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 15, 9, 19, 26, 387, DateTimeKind.Local).AddTicks(3474),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 1, 15, 9, 3, 47, 273, DateTimeKind.Local).AddTicks(994));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Roles",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 15, 9, 19, 26, 379, DateTimeKind.Local).AddTicks(2062),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 1, 15, 9, 3, 47, 266, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Grades",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 15, 9, 19, 26, 380, DateTimeKind.Local).AddTicks(9169),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 1, 15, 9, 3, 47, 274, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Courses",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 15, 9, 19, 26, 382, DateTimeKind.Local).AddTicks(47),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 1, 15, 9, 3, 47, 274, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Accounts",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 15, 9, 19, 26, 374, DateTimeKind.Local).AddTicks(1330),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 1, 15, 9, 3, 47, 261, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "GradeId", "ExpiryDate", "GradeName" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "الصف الأول الثانوى" });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "GradeId", "ExpiryDate", "GradeName" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "الصف الثانى الثانوى" });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "GradeId", "ExpiryDate", "GradeName" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "الصف الثالث الثانوى" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseName", "ExpiryDate", "GradeId" },
                values: new object[] { 1, "مادة الرياضيات 1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseName", "ExpiryDate", "GradeId" },
                values: new object[] { 2, "مادة الرياضيات 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeId",
                keyValue: 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Teachers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 15, 9, 3, 47, 269, DateTimeKind.Local).AddTicks(1703),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 1, 15, 9, 19, 26, 383, DateTimeKind.Local).AddTicks(5119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Students",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 15, 9, 3, 47, 273, DateTimeKind.Local).AddTicks(994),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 1, 15, 9, 19, 26, 387, DateTimeKind.Local).AddTicks(3474));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Roles",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 15, 9, 3, 47, 266, DateTimeKind.Local).AddTicks(9360),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 1, 15, 9, 19, 26, 379, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Grades",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 15, 9, 3, 47, 274, DateTimeKind.Local).AddTicks(8736),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 1, 15, 9, 19, 26, 380, DateTimeKind.Local).AddTicks(9169));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Courses",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 15, 9, 3, 47, 274, DateTimeKind.Local).AddTicks(2583),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 1, 15, 9, 19, 26, 382, DateTimeKind.Local).AddTicks(47));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Accounts",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 15, 9, 3, 47, 261, DateTimeKind.Local).AddTicks(7167),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 1, 15, 9, 19, 26, 374, DateTimeKind.Local).AddTicks(1330));
        }
    }
}
