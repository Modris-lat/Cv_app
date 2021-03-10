using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cv_App.Data.Migrations
{
    public partial class CvModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    School = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    From = table.Column<DateTime>(type: "datetime2", nullable: false),
                    To = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CvModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Education_CvModels_CvModelId",
                        column: x => x.CvModelId,
                        principalTable: "CvModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkExperience",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    From = table.Column<DateTime>(type: "datetime2", nullable: false),
                    To = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JobDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CvModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkExperience", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkExperience_CvModels_CvModelId",
                        column: x => x.CvModelId,
                        principalTable: "CvModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Education_CvModelId",
                table: "Education",
                column: "CvModelId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperience_CvModelId",
                table: "WorkExperience",
                column: "CvModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "WorkExperience");

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
        }
    }
}
