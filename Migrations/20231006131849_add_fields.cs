using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FolhaDePagamento.Migrations
{
    public partial class add_fields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Value",
                table: "Payrolls",
                newName: "ValueHour");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Payrolls",
                newName: "NetSalary");

            migrationBuilder.AddColumn<double>(
                name: "FgtsTax",
                table: "Payrolls",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "GrossSalary",
                table: "Payrolls",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "IncomeTax",
                table: "Payrolls",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "InssTax",
                table: "Payrolls",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "QuantityHour",
                table: "Payrolls",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FgtsTax",
                table: "Payrolls");

            migrationBuilder.DropColumn(
                name: "GrossSalary",
                table: "Payrolls");

            migrationBuilder.DropColumn(
                name: "IncomeTax",
                table: "Payrolls");

            migrationBuilder.DropColumn(
                name: "InssTax",
                table: "Payrolls");

            migrationBuilder.DropColumn(
                name: "QuantityHour",
                table: "Payrolls");

            migrationBuilder.RenameColumn(
                name: "ValueHour",
                table: "Payrolls",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "NetSalary",
                table: "Payrolls",
                newName: "Quantity");
        }
    }
}
