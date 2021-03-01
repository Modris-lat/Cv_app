using Microsoft.EntityFrameworkCore.Migrations;

namespace Cv_App.Data.Migrations
{
    public partial class CvModel1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Education_CvModels_CvModelId",
                table: "Education");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperience_CvModels_CvModelId",
                table: "WorkExperience");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkExperience",
                table: "WorkExperience");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Education",
                table: "Education");

            migrationBuilder.DropColumn(
                name: "AdditionalInformation",
                table: "CvModels");

            migrationBuilder.DropColumn(
                name: "Education",
                table: "CvModels");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "CvModels");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "CvModels");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CvModels");

            migrationBuilder.DropColumn(
                name: "PersonalData",
                table: "CvModels");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "CvModels");

            migrationBuilder.DropColumn(
                name: "WorkExperience",
                table: "CvModels");

            migrationBuilder.RenameTable(
                name: "WorkExperience",
                newName: "WorkExperiences");

            migrationBuilder.RenameTable(
                name: "Education",
                newName: "Educations");

            migrationBuilder.RenameIndex(
                name: "IX_WorkExperience_CvModelId",
                table: "WorkExperiences",
                newName: "IX_WorkExperiences_CvModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Education_CvModelId",
                table: "Educations",
                newName: "IX_Educations_CvModelId");

            migrationBuilder.AddColumn<int>(
                name: "PersonalDataId",
                table: "CvModels",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkExperiences",
                table: "WorkExperiences",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Educations",
                table: "Educations",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "PersonalData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalData", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "PersonalData");

            migrationBuilder.DropIndex(
                name: "IX_CvModels_PersonalDataId",
                table: "CvModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkExperiences",
                table: "WorkExperiences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Educations",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "PersonalDataId",
                table: "CvModels");

            migrationBuilder.RenameTable(
                name: "WorkExperiences",
                newName: "WorkExperience");

            migrationBuilder.RenameTable(
                name: "Educations",
                newName: "Education");

            migrationBuilder.RenameIndex(
                name: "IX_WorkExperiences_CvModelId",
                table: "WorkExperience",
                newName: "IX_WorkExperience_CvModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Educations_CvModelId",
                table: "Education",
                newName: "IX_Education_CvModelId");

            migrationBuilder.AddColumn<string>(
                name: "AdditionalInformation",
                table: "CvModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Education",
                table: "CvModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "CvModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "CvModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CvModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PersonalData",
                table: "CvModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "CvModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkExperience",
                table: "CvModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkExperience",
                table: "WorkExperience",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Education",
                table: "Education",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Education_CvModels_CvModelId",
                table: "Education",
                column: "CvModelId",
                principalTable: "CvModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperience_CvModels_CvModelId",
                table: "WorkExperience",
                column: "CvModelId",
                principalTable: "CvModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
