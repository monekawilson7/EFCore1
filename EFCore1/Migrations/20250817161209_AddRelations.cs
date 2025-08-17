using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore1.Migrations
{
    public partial class AddRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Stud_Course",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_Dep_Id",
                table: "Students",
                column: "Dep_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Course_CourseId",
                table: "Stud_Course",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_Dept_Id",
                table: "Instructor",
                column: "Dept_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Ins_Id",
                table: "Departments",
                column: "Ins_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Course_inst_Course_ID",
                table: "Course_inst",
                column: "Course_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Top_Id",
                table: "Course",
                column: "Top_Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_Dep_Id",
                table: "Students",
                column: "Dep_Id",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_Dep_Id",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_Dep_Id",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Stud_Course_CourseId",
                table: "Stud_Course");

            migrationBuilder.DropIndex(
                name: "IX_Instructor_Dept_Id",
                table: "Instructor");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Ins_Id",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Course_inst_Course_ID",
                table: "Course_inst");

            migrationBuilder.DropIndex(
                name: "IX_Course_Top_Id",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Stud_Course");
        }
    }
}
