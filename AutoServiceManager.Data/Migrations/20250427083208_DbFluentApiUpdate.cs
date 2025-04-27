using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoServiceManager.Data.Migrations
{
    /// <inheritdoc />
    public partial class DbFluentApiUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Customers_CustomerId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairOrderEmployees_Employees_EmployeeId",
                table: "RepairOrderEmployees");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairOrderEmployees_RepairOrders_RepairOrderId",
                table: "RepairOrderEmployees");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairOrderParts_Parts_PartId",
                table: "RepairOrderParts");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairOrderParts_RepairOrders_RepairOrderId",
                table: "RepairOrderParts");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairOrders_Cars_CarId",
                table: "RepairOrders");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Customers_CustomerId",
                table: "Cars",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RepairOrderEmployees_Employees_EmployeeId",
                table: "RepairOrderEmployees",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RepairOrderEmployees_RepairOrders_RepairOrderId",
                table: "RepairOrderEmployees",
                column: "RepairOrderId",
                principalTable: "RepairOrders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RepairOrderParts_Parts_PartId",
                table: "RepairOrderParts",
                column: "PartId",
                principalTable: "Parts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RepairOrderParts_RepairOrders_RepairOrderId",
                table: "RepairOrderParts",
                column: "RepairOrderId",
                principalTable: "RepairOrders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RepairOrders_Cars_CarId",
                table: "RepairOrders",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Customers_CustomerId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairOrderEmployees_Employees_EmployeeId",
                table: "RepairOrderEmployees");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairOrderEmployees_RepairOrders_RepairOrderId",
                table: "RepairOrderEmployees");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairOrderParts_Parts_PartId",
                table: "RepairOrderParts");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairOrderParts_RepairOrders_RepairOrderId",
                table: "RepairOrderParts");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairOrders_Cars_CarId",
                table: "RepairOrders");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Customers_CustomerId",
                table: "Cars",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RepairOrderEmployees_Employees_EmployeeId",
                table: "RepairOrderEmployees",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RepairOrderEmployees_RepairOrders_RepairOrderId",
                table: "RepairOrderEmployees",
                column: "RepairOrderId",
                principalTable: "RepairOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RepairOrderParts_Parts_PartId",
                table: "RepairOrderParts",
                column: "PartId",
                principalTable: "Parts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RepairOrderParts_RepairOrders_RepairOrderId",
                table: "RepairOrderParts",
                column: "RepairOrderId",
                principalTable: "RepairOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RepairOrders_Cars_CarId",
                table: "RepairOrders",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
