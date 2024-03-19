using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Keeper.Domen.Migrations
{
    /// <inheritdoc />
    public partial class _11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Medicines_MedicinesId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_MedicinesId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "MedicinesId",
                table: "Invoices");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpirationDate",
                table: "Medicines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "InvoiceId",
                table: "Medicines",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Issues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_InvoiceId",
                table: "Medicines",
                column: "InvoiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicines_Invoices_InvoiceId",
                table: "Medicines",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicines_Invoices_InvoiceId",
                table: "Medicines");

            migrationBuilder.DropIndex(
                name: "IX_Medicines_InvoiceId",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "ExpirationDate",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Issues");

            migrationBuilder.AddColumn<int>(
                name: "MedicinesId",
                table: "Invoices",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_MedicinesId",
                table: "Invoices",
                column: "MedicinesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Medicines_MedicinesId",
                table: "Invoices",
                column: "MedicinesId",
                principalTable: "Medicines",
                principalColumn: "Id");
        }
    }
}
