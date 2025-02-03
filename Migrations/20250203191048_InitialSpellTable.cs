using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkyfallAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialSpellTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Spells",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Execution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Range = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Target = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Components = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attack = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Effect = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Miss = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Special = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spells", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Spells");
        }
    }
}
