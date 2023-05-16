﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class bruh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Payment_paymentID",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_paymentID",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "paymentID",
                table: "Item");

            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "firstName",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lastName",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "phone",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "totalPrice",
                table: "Payment",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "productName",
                table: "Item",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "productPrice",
                table: "Item",
                type: "float",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c28305c3-93f5-4490-ae59-05d0401bcee3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1901f392-16d7-48b3-a53d-d722c4463c42", "AQAAAAIAAYagAAAAEFyTLjBoq52uoxYHD2/Ad8tzEmmbLnEA5GipdLzvI7rD1Je8aRWlNcm0CEhStm1BqA==", "413c684a-4af4-490f-b9ab-917f26602018" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "address",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "firstName",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "lastName",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "phone",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "totalPrice",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "productName",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "productPrice",
                table: "Item");

            migrationBuilder.AddColumn<string>(
                name: "paymentID",
                table: "Item",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c28305c3-93f5-4490-ae59-05d0401bcee3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b937fc2-fa24-4bff-850b-e9daf864a334", "AQAAAAIAAYagAAAAEIBDhKMDGDUrImNVJBk/pOdDInU7KPMT6ZQPec889y7IJIplkcUplNwGazCavET2cQ==", "c144bf17-f38d-4bfd-8426-3ed0dedf19d6" });

            migrationBuilder.CreateIndex(
                name: "IX_Item_paymentID",
                table: "Item",
                column: "paymentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Payment_paymentID",
                table: "Item",
                column: "paymentID",
                principalTable: "Payment",
                principalColumn: "paymentID");
        }
    }
}