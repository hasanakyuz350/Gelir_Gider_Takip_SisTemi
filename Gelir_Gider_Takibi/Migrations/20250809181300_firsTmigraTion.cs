using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gelir_Gider_Takibi.Migrations
{
    /// <inheritdoc />
    public partial class firsTmigraTion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "caTegory",
                columns: table => new
                {
                    caTegoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    caTegoryname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_caTegory", x => x.caTegoryID);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    userID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.userID);
                });

            migrationBuilder.CreateTable(
                name: "ThismonThsalary",
                columns: table => new
                {
                    monThID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    monThname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    year = table.Column<int>(type: "int", nullable: false),
                    salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    userID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThismonThsalary", x => x.monThID);
                    table.ForeignKey(
                        name: "FK_ThismonThsalary_user_userID",
                        column: x => x.userID,
                        principalTable: "user",
                        principalColumn: "userID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThismonThsalaryspending",
                columns: table => new
                {
                    salaryspendingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    amounT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    monThID = table.Column<int>(type: "int", nullable: false),
                    caTegoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThismonThsalaryspending", x => x.salaryspendingID);
                    table.ForeignKey(
                        name: "FK_ThismonThsalaryspending_ThismonThsalary_monThID",
                        column: x => x.monThID,
                        principalTable: "ThismonThsalary",
                        principalColumn: "monThID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ThismonThsalaryspending_caTegory_caTegoryID",
                        column: x => x.caTegoryID,
                        principalTable: "caTegory",
                        principalColumn: "caTegoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ThismonThsalary_userID",
                table: "ThismonThsalary",
                column: "userID");

            migrationBuilder.CreateIndex(
                name: "IX_ThismonThsalaryspending_caTegoryID",
                table: "ThismonThsalaryspending",
                column: "caTegoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ThismonThsalaryspending_monThID",
                table: "ThismonThsalaryspending",
                column: "monThID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ThismonThsalaryspending");

            migrationBuilder.DropTable(
                name: "ThismonThsalary");

            migrationBuilder.DropTable(
                name: "caTegory");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
