using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCoreInActionSecondEditionForMvc.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblCities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblDepartments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblDepartments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblGenders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblGenders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblPersons",
                columns: table => new
                {
                    PersonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Age = table.Column<int>(nullable: false),
                    GenderId = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblPersons", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_TblPersons_TblCities_CityId",
                        column: x => x.CityId,
                        principalTable: "TblCities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblPersons_TblDepartments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "TblDepartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblPersons_TblGenders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "TblGenders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblPersons_CityId",
                table: "TblPersons",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_TblPersons_DepartmentId",
                table: "TblPersons",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TblPersons_GenderId",
                table: "TblPersons",
                column: "GenderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblPersons");

            migrationBuilder.DropTable(
                name: "TblCities");

            migrationBuilder.DropTable(
                name: "TblDepartments");

            migrationBuilder.DropTable(
                name: "TblGenders");
        }
    }
}
