using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HackathonLoginApp.Migrations;

/// <inheritdoc />
public sealed partial class MigrationA : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Users",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Username = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                Password = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                DisplayName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Users", x => x.Id);
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Users");
    }
}
