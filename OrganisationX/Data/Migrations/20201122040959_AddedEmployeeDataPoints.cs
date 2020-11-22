using Microsoft.EntityFrameworkCore.Migrations;

namespace OrganisationX.Data.Migrations
{
    public partial class AddedEmployeeDataPoints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Attrition",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BusinessTravel",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DistanceFromHome",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EnvironmentSatisfaction",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaritialStatus",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumCompaniesWorked",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Over18",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Attrition",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BusinessTravel",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DistanceFromHome",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EnvironmentSatisfaction",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MaritialStatus",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NumCompaniesWorked",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Over18",
                table: "AspNetUsers");
        }
    }
}
