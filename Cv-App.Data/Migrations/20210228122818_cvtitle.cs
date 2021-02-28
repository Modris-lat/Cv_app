using Microsoft.EntityFrameworkCore.Migrations;

namespace Cv_App.Data.Migrations
{
    public partial class cvtitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Property_CvModels_CvModelId",
                table: "Property");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Property",
                table: "Property");

            migrationBuilder.RenameTable(
                name: "Property",
                newName: "Properties");

            migrationBuilder.RenameIndex(
                name: "IX_Property_CvModelId",
                table: "Properties",
                newName: "IX_Properties_CvModelId");

            migrationBuilder.AddColumn<string>(
                name: "CvTitle",
                table: "CvModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CvModelId",
                table: "Properties",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Properties",
                table: "Properties",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_CvModels_CvModelId",
                table: "Properties",
                column: "CvModelId",
                principalTable: "CvModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_CvModels_CvModelId",
                table: "Properties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Properties",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "CvTitle",
                table: "CvModels");

            migrationBuilder.RenameTable(
                name: "Properties",
                newName: "Property");

            migrationBuilder.RenameIndex(
                name: "IX_Properties_CvModelId",
                table: "Property",
                newName: "IX_Property_CvModelId");

            migrationBuilder.AlterColumn<int>(
                name: "CvModelId",
                table: "Property",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Property",
                table: "Property",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_CvModels_CvModelId",
                table: "Property",
                column: "CvModelId",
                principalTable: "CvModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
