using Microsoft.EntityFrameworkCore.Migrations;

namespace Cv_App.Data.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CvModels_PersonalData_PersonalDataId",
                table: "CvModels");

            migrationBuilder.DropForeignKey(
                name: "FK_Educations_CvModels_CvModelId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_CvModels_CvModelId",
                table: "WorkExperiences");

            migrationBuilder.DropIndex(
                name: "IX_CvModels_PersonalDataId",
                table: "CvModels");

            migrationBuilder.DropColumn(
                name: "PersonalDataId",
                table: "CvModels");

            migrationBuilder.AlterColumn<int>(
                name: "CvModelId",
                table: "WorkExperiences",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CvModelId",
                table: "PersonalData",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CvModelId",
                table: "Educations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonalData_CvModelId",
                table: "PersonalData",
                column: "CvModelId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_CvModels_CvModelId",
                table: "Educations",
                column: "CvModelId",
                principalTable: "CvModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalData_CvModels_CvModelId",
                table: "PersonalData",
                column: "CvModelId",
                principalTable: "CvModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_CvModels_CvModelId",
                table: "WorkExperiences",
                column: "CvModelId",
                principalTable: "CvModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_CvModels_CvModelId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalData_CvModels_CvModelId",
                table: "PersonalData");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_CvModels_CvModelId",
                table: "WorkExperiences");

            migrationBuilder.DropIndex(
                name: "IX_PersonalData_CvModelId",
                table: "PersonalData");

            migrationBuilder.DropColumn(
                name: "CvModelId",
                table: "PersonalData");

            migrationBuilder.AlterColumn<int>(
                name: "CvModelId",
                table: "WorkExperiences",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CvModelId",
                table: "Educations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "PersonalDataId",
                table: "CvModels",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CvModels_PersonalDataId",
                table: "CvModels",
                column: "PersonalDataId");

            migrationBuilder.AddForeignKey(
                name: "FK_CvModels_PersonalData_PersonalDataId",
                table: "CvModels",
                column: "PersonalDataId",
                principalTable: "PersonalData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_CvModels_CvModelId",
                table: "Educations",
                column: "CvModelId",
                principalTable: "CvModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_CvModels_CvModelId",
                table: "WorkExperiences",
                column: "CvModelId",
                principalTable: "CvModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
