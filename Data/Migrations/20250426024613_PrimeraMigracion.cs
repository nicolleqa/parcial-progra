using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace parcial.Data.Migrations
{
    /// <inheritdoc />
    public partial class PrimeraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "t_players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Edad = table.Column<int>(type: "INTEGER", nullable: false),
                    Posicion = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "t_teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "t_playersteams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdPlayer = table.Column<int>(type: "INTEGER", nullable: true),
                    IdTeam = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_playersteams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_t_playersteams_t_players_IdPlayer",
                        column: x => x.IdPlayer,
                        principalTable: "t_players",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_t_playersteams_t_teams_IdTeam",
                        column: x => x.IdTeam,
                        principalTable: "t_teams",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_t_playersteams_IdPlayer",
                table: "t_playersteams",
                column: "IdPlayer");

            migrationBuilder.CreateIndex(
                name: "IX_t_playersteams_IdTeam",
                table: "t_playersteams",
                column: "IdTeam");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t_playersteams");

            migrationBuilder.DropTable(
                name: "t_players");

            migrationBuilder.DropTable(
                name: "t_teams");
        }
    }
}
