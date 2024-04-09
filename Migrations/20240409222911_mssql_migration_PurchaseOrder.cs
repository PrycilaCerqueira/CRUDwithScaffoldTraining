using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDwithScaffoldTraining.Migrations
{
    /// <inheritdoc />
    public partial class mssql_migration_PurchaseOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PurchaseOrderId",
                table: "Address",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PurchaseOrder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Quote = table.Column<string>(type: "TEXT", nullable: false),
                    Invoice = table.Column<string>(type: "TEXT", nullable: false),
                    Supplier = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    SalesRep_Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrder", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_PurchaseOrderId",
                table: "Address",
                column: "PurchaseOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_PurchaseOrder_PurchaseOrderId",
                table: "Address",
                column: "PurchaseOrderId",
                principalTable: "PurchaseOrder",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_PurchaseOrder_PurchaseOrderId",
                table: "Address");

            migrationBuilder.DropTable(
                name: "PurchaseOrder");

            migrationBuilder.DropIndex(
                name: "IX_Address_PurchaseOrderId",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "PurchaseOrderId",
                table: "Address");
        }
    }
}
