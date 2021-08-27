using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeEvaluationAPI.Migrations
{
    public partial class Initial : Migration
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
                name: "Evaluations",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    done_by = table.Column<int>(type: "INTEGER", nullable: false),
                    done_for = table.Column<int>(type: "INTEGER", nullable: false),
                    value = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluations", x => x.id);
                    table.ForeignKey(
                        name: "FK_Evaluations_Employee_done_by",
                        column: x => x.done_by,
                        principalTable: "Employee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evaluations_Employee_done_for",
                        column: x => x.done_for,
                        principalTable: "Employee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "id", "age", "name", "rating" },
                values: new object[] { -1, 22, "Fadi", 0.0 });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "id", "age", "name", "rating" },
                values: new object[] { -2, 30, "Baha", 0.0 });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "id", "age", "name", "rating" },
                values: new object[] { -3, 26, "Joseph", 0.0 });

            migrationBuilder.InsertData(
                table: "Evaluations",
                columns: new[] { "id", "done_by", "done_for", "value" },
                values: new object[] { -1, -1, -2, 80 });

            migrationBuilder.InsertData(
                table: "Evaluations",
                columns: new[] { "id", "done_by", "done_for", "value" },
                values: new object[] { -2, -2, -3, 90 });

            migrationBuilder.InsertData(
                table: "Evaluations",
                columns: new[] { "id", "done_by", "done_for", "value" },
                values: new object[] { -3, -3, -1, 80 });

            migrationBuilder.CreateIndex(
                name: "IX_Evaluations_done_by",
                table: "Evaluations",
                column: "done_by");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluations_done_for",
                table: "Evaluations",
                column: "done_for");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evaluations");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
