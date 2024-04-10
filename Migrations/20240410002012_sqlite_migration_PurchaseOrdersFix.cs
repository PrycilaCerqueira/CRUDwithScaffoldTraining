using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDwithScaffoldTraining.Migrations
{
    /// <inheritdoc />
    public partial class sqlite_migration_PurchaseOrdersFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_PurchaseOrder_PurchaseOrderId",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_PurchaseOrderId",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "PurchaseOrderId",
                table: "Address");

            migrationBuilder.AddColumn<int>(
                name: "AddressIdId",
                table: "PurchaseOrder",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Delivery_AddressId",
                table: "PurchaseOrder",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateOnly>(
                name: "eTA",
                table: "PurchaseOrder",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_AddressIdId",
                table: "PurchaseOrder",
                column: "AddressIdId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_Delivery_AddressId",
                table: "PurchaseOrder",
                column: "Delivery_AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrder_Address_AddressIdId",
                table: "PurchaseOrder",
                column: "AddressIdId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrder_Address_Delivery_AddressId",
                table: "PurchaseOrder",
                column: "Delivery_AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrder_Address_AddressIdId",
                table: "PurchaseOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrder_Address_Delivery_AddressId",
                table: "PurchaseOrder");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseOrder_AddressIdId",
                table: "PurchaseOrder");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseOrder_Delivery_AddressId",
                table: "PurchaseOrder");

            migrationBuilder.DropColumn(
                name: "AddressIdId",
                table: "PurchaseOrder");

            migrationBuilder.DropColumn(
                name: "Delivery_AddressId",
                table: "PurchaseOrder");

            migrationBuilder.DropColumn(
                name: "eTA",
                table: "PurchaseOrder");

            migrationBuilder.AddColumn<int>(
                name: "PurchaseOrderId",
                table: "Address",
                type: "INTEGER",
                nullable: true);

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
    }
}
