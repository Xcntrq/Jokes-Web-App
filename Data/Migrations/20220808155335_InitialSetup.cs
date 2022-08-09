namespace Jokes_Web_App.Data.Migrations;

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

/// <summary>
/// SA1601PartialElementsMustBeDocumented.
/// </summary>
public partial class InitialSetup : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Joke",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Question = table.Column<string>(type: "nvarchar(max)", nullable: true),
                Answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Joke", x => x.Id);
            });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Joke");
    }
}
