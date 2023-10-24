using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace webapiproject.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Leaguess",
                columns: table => new
                {
                    LeaguesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeagueName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeagueCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MostChampTeam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumbofTeams = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leaguess", x => x.LeaguesId);
                });

            migrationBuilder.CreateTable(
                name: "Teamss",
                columns: table => new
                {
                    TeamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LeaguesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teamss", x => x.TeamId);
                    table.ForeignKey(
                        name: "FK_Teamss_Leaguess_LeaguesId",
                        column: x => x.LeaguesId,
                        principalTable: "Leaguess",
                        principalColumn: "LeaguesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Managerss",
                columns: table => new
                {
                    ManagersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    TeamsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managerss", x => x.ManagersId);
                    table.ForeignKey(
                        name: "FK_Managerss_Teamss_TeamsId",
                        column: x => x.TeamsId,
                        principalTable: "Teamss",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Playerss",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlayerSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MarketValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateofBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playerss", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_Playerss_Teamss_TeamsId",
                        column: x => x.TeamsId,
                        principalTable: "Teamss",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Managerss_TeamsId",
                table: "Managerss",
                column: "TeamsId");

            migrationBuilder.CreateIndex(
                name: "IX_Playerss_TeamsId",
                table: "Playerss",
                column: "TeamsId");

            migrationBuilder.CreateIndex(
                name: "IX_Teamss_LeaguesId",
                table: "Teamss",
                column: "LeaguesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Managerss");

            migrationBuilder.DropTable(
                name: "Playerss");

            migrationBuilder.DropTable(
                name: "Teamss");

            migrationBuilder.DropTable(
                name: "Leaguess");
        }
    }
}
