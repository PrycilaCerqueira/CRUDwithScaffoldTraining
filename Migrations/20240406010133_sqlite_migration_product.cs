using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDwithScaffoldTraining.Migrations
{
    /// <inheritdoc />
    public partial class sqlite_migration_product : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Maker = table.Column<string>(type: "TEXT", nullable: true),
                    SKU = table.Column<string>(type: "TEXT", nullable: true),
                    Qty_InStock = table.Column<int>(type: "INTEGER", nullable: true),
                    UnitPrice = table.Column<double>(type: "REAL", nullable: true),
                    UnitPrice_Total = table.Column<double>(type: "REAL", nullable: true),
                    Qty_Received = table.Column<int>(type: "INTEGER", nullable: true),
                    CostPrice = table.Column<double>(type: "REAL", nullable: true),
                    CostPrice_Total = table.Column<double>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
