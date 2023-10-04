using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Infra.Migrations
{
    /// <inheritdoc />
    public partial class _20230830_TabelaAgendamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "singleBads",
                table: "Rooms",
                newName: "SingleBads");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SingleBads",
                table: "Rooms",
                newName: "singleBads");
        }
    }
}
