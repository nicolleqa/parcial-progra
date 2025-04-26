using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace parcial.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddEquipoToPlayers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Equipo",
                table: "t_players",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Equipo",
                table: "t_players");
        }
    }
}
