using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeEvaluationAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    age = table.Column<int>(type: "INTEGER", nullable: false),
                    rating = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Evaluation",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    done_by = table.Column<int>(type: "INTEGER", nullable: true),
                    done_for = table.Column<int>(type: "INTEGER", nullable: true),
                    value = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluation", x => x.id);
                    table.ForeignKey(
                        name: "FK_Evaluation_Employee_done_by",
                        column: x => x.done_by,
                        principalTable: "Employee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Evaluation_Employee_done_for",
                        column: x => x.done_for,
                        principalTable: "Employee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Evaluation_done_by",
                table: "Evaluation",
                column: "done_by");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluation_done_for",
                table: "Evaluation",
                column: "done_for");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evaluation");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
