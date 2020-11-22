using Microsoft.EntityFrameworkCore.Migrations;

namespace OrganisationX.Data.Migrations
{
    public partial class AddedEmployeesDetailsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<string>(nullable: true),
                    EducationLevel = table.Column<int>(nullable: false),
                    EducationField = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Educations_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JobInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Department = table.Column<string>(nullable: false),
                    EmployeeCount = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<string>(nullable: true),
                    JobInvolvement = table.Column<int>(nullable: false),
                    JobLevel = table.Column<int>(nullable: false),
                    JobRole = table.Column<string>(nullable: true),
                    JobSatisfaction = table.Column<int>(nullable: false),
                    PerformanceRating = table.Column<int>(nullable: false),
                    RelationshipSatisfaction = table.Column<int>(nullable: false),
                    StandardHours = table.Column<int>(nullable: false),
                    StockOptionLevel = table.Column<int>(nullable: false),
                    TotalWorkingYears = table.Column<int>(nullable: false),
                    TrainingTimesLastYear = table.Column<int>(nullable: false),
                    WorkLifeBalance = table.Column<int>(nullable: false),
                    YearsAtCompany = table.Column<int>(nullable: false),
                    YearsInCurrentRole = table.Column<int>(nullable: false),
                    YearsSinceLastPromotion = table.Column<int>(nullable: false),
                    YearsWithCurrManager = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobInfos_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Salaries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DailyRate = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<string>(nullable: true),
                    HourlyRate = table.Column<int>(nullable: false),
                    MonthlyIncome = table.Column<int>(nullable: false),
                    MonthlyRate = table.Column<int>(nullable: false),
                    OverTime = table.Column<string>(nullable: true),
                    PercentSalaryHike = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Salaries_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Educations_EmployeeId",
                table: "Educations",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobInfos_EmployeeId",
                table: "JobInfos",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Salaries_EmployeeId",
                table: "Salaries",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "JobInfos");

            migrationBuilder.DropTable(
                name: "Salaries");
        }
    }
}
