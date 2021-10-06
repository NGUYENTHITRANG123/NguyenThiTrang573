using Microsoft.EntityFrameworkCore.Migrations;

namespace NguyenThiTrang573.Migrations
{
    public partial class PersionNTT573 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersionNTT573",
                columns: table => new
                {
                    PersionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PersionName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersionNTT573", x => x.PersionId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersionNTT573");
        }
    }
}
