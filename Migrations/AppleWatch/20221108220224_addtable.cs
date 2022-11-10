using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoApi.Migrations.AppleWatch
{
    public partial class addtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppleWatchItems",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    device_id = table.Column<int>(type: "int", nullable: false),
                    access_token = table.Column<int>(type: "int", nullable: false),
                    refresh_token = table.Column<int>(type: "int", nullable: false),
                    registered_date = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppleWatch_1_Items", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppleWatch_1_Items");
        }
    }
}
