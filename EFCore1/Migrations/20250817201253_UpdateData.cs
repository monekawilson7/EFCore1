using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore1.Migrations
{
    public partial class UpdateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Departments_DepartmentId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Instructor_InstructorId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Topics_Top_Id",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_inst_Course_Course_ID",
                table: "Course_inst");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_inst_Instructor_Inst_ID",
                table: "Course_inst");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructor_Ins_Id",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Departments_Dept_Id",
                table: "Instructor");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Course_CourseId",
                table: "Stud_Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Students_Stud_ID",
                table: "Stud_Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_inst",
                table: "Course_inst");

            migrationBuilder.DropIndex(
                name: "IX_Course_inst_Course_ID",
                table: "Course_inst");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_InstructorId",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "Inst_Id",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "InstructorId",
                table: "Course");

            migrationBuilder.RenameTable(
                name: "Stud_Course",
                newName: "StudCourses");

            migrationBuilder.RenameTable(
                name: "Instructor",
                newName: "Instructors");

            migrationBuilder.RenameTable(
                name: "Course_inst",
                newName: "CourseInsts");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "Courses");

            migrationBuilder.RenameColumn(
                name: "Course_ID",
                table: "StudCourses",
                newName: "Course_Id");

            migrationBuilder.RenameColumn(
                name: "Stud_ID",
                table: "StudCourses",
                newName: "Stud_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Stud_Course_CourseId",
                table: "StudCourses",
                newName: "IX_StudCourses_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Instructor_Dept_Id",
                table: "Instructors",
                newName: "IX_Instructors_Dept_Id");

            migrationBuilder.RenameColumn(
                name: "Course_ID",
                table: "CourseInsts",
                newName: "Course_Id");

            migrationBuilder.RenameColumn(
                name: "Inst_ID",
                table: "CourseInsts",
                newName: "Inst_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Course_Top_Id",
                table: "Courses",
                newName: "IX_Courses_Top_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Course_DepartmentId",
                table: "Courses",
                newName: "IX_Courses_DepartmentId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Topics",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "HiringDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "StudCourses",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Evaluate",
                table: "CourseInsts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "CourseInsts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InstructorId",
                table: "CourseInsts",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldUnicode: false,
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudCourses",
                table: "StudCourses",
                columns: new[] { "Stud_Id", "Course_Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseInsts",
                table: "CourseInsts",
                columns: new[] { "Inst_Id", "Course_Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_StudCourses_StudentId",
                table: "StudCourses",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseInsts_CourseId",
                table: "CourseInsts",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseInsts_InstructorId",
                table: "CourseInsts",
                column: "InstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseInsts_Courses_CourseId",
                table: "CourseInsts",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseInsts_Instructors_InstructorId",
                table: "CourseInsts",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_DepartmentId",
                table: "Courses",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topics_Top_Id",
                table: "Courses",
                column: "Top_Id",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_Ins_Id",
                table: "Departments",
                column: "Ins_Id",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_Dept_Id",
                table: "Instructors",
                column: "Dept_Id",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudCourses_Courses_CourseId",
                table: "StudCourses",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudCourses_Students_StudentId",
                table: "StudCourses",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseInsts_Courses_CourseId",
                table: "CourseInsts");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseInsts_Instructors_InstructorId",
                table: "CourseInsts");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_DepartmentId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_Top_Id",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_Ins_Id",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_Dept_Id",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_StudCourses_Courses_CourseId",
                table: "StudCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_StudCourses_Students_StudentId",
                table: "StudCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudCourses",
                table: "StudCourses");

            migrationBuilder.DropIndex(
                name: "IX_StudCourses_StudentId",
                table: "StudCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseInsts",
                table: "CourseInsts");

            migrationBuilder.DropIndex(
                name: "IX_CourseInsts_CourseId",
                table: "CourseInsts");

            migrationBuilder.DropIndex(
                name: "IX_CourseInsts_InstructorId",
                table: "CourseInsts");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "StudCourses");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "CourseInsts");

            migrationBuilder.DropColumn(
                name: "InstructorId",
                table: "CourseInsts");

            migrationBuilder.RenameTable(
                name: "StudCourses",
                newName: "Stud_Course");

            migrationBuilder.RenameTable(
                name: "Instructors",
                newName: "Instructor");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Course");

            migrationBuilder.RenameTable(
                name: "CourseInsts",
                newName: "Course_inst");

            migrationBuilder.RenameColumn(
                name: "Course_Id",
                table: "Stud_Course",
                newName: "Course_ID");

            migrationBuilder.RenameColumn(
                name: "Stud_Id",
                table: "Stud_Course",
                newName: "Stud_ID");

            migrationBuilder.RenameIndex(
                name: "IX_StudCourses_CourseId",
                table: "Stud_Course",
                newName: "IX_Stud_Course_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Instructors_Dept_Id",
                table: "Instructor",
                newName: "IX_Instructor_Dept_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_Top_Id",
                table: "Course",
                newName: "IX_Course_Top_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_DepartmentId",
                table: "Course",
                newName: "IX_Course_DepartmentId");

            migrationBuilder.RenameColumn(
                name: "Course_Id",
                table: "Course_inst",
                newName: "Course_ID");

            migrationBuilder.RenameColumn(
                name: "Inst_Id",
                table: "Course_inst",
                newName: "Inst_ID");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Topics",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Departments",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "HiringDate",
                table: "Departments",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Instructor",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Instructor",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Course",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Course",
                type: "varchar(200)",
                unicode: false,
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Inst_Id",
                table: "Course",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InstructorId",
                table: "Course",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Evaluate",
                table: "Course_inst",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course",
                columns: new[] { "Stud_ID", "Course_ID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_inst",
                table: "Course_inst",
                columns: new[] { "Inst_ID", "Course_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_Course_InstructorId",
                table: "Course",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_inst_Course_ID",
                table: "Course_inst",
                column: "Course_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Departments_DepartmentId",
                table: "Course",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Instructor_InstructorId",
                table: "Course",
                column: "InstructorId",
                principalTable: "Instructor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Topics_Top_Id",
                table: "Course",
                column: "Top_Id",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_inst_Course_Course_ID",
                table: "Course_inst",
                column: "Course_ID",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_inst_Instructor_Inst_ID",
                table: "Course_inst",
                column: "Inst_ID",
                principalTable: "Instructor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructor_Ins_Id",
                table: "Departments",
                column: "Ins_Id",
                principalTable: "Instructor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_Departments_Dept_Id",
                table: "Instructor",
                column: "Dept_Id",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Course_CourseId",
                table: "Stud_Course",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Students_Stud_ID",
                table: "Stud_Course",
                column: "Stud_ID",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
