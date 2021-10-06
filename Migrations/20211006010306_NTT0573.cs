using Microsoft.EntityFrameworkCore.Migrations;

namespace NguyenThiTrang573.Migrations
{
    public partial class NTT0573 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NTT0573",
                columns: table => new
                {
                    NTTId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NTTName = table.Column<string>(type: "TEXT", nullable: true),
                    NTTGender = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NTT0573", x => x.NTTId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NTT0573");
        }
    }
}
