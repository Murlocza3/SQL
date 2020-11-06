using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _3._1.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Deal",
                keyColumn: "ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Deal",
                keyColumn: "ID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Deal",
                keyColumn: "ID",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "SubAccount",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubAccount",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SubAccount",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SubAccount",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Deal",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Agreement", "Commission", "Date", "Number", "Order", "Price", "Quantity", "Tiker", "TotalCost", "Trader" },
                values: new object[] { 1f, 2f, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1f, 1, "3", 2, 1 });

            migrationBuilder.UpdateData(
                table: "Deal",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Agreement", "Commission", "Date", "Number", "Order", "Price", "Quantity", "Tiker", "TotalCost", "Trader" },
                values: new object[] { 2f, 1f, new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, 2f, 3, "1", 1, 2 });

            migrationBuilder.InsertData(
                table: "Deal",
                columns: new[] { "ID", "Agreement", "Commission", "Date", "Number", "Order", "Price", "Quantity", "Tiker", "TotalCost", "Trader" },
                values: new object[,]
                {
                    { 9, 202f, 111f, new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 205, 204, 208f, 307, "103", 109, 200 },
                    { 111, 63f, 777f, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 231, 262, 267f, 27, "163", 2222, 666 },
                    { 777, 777f, 666f, new DateTime(2020, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 777, 666, 777f, 666, "7676", 666, 777 }
                });

            migrationBuilder.UpdateData(
                table: "Operation",
                keyColumn: "ID",
                keyValue: 22,
                column: "DealID",
                value: 13);

            migrationBuilder.UpdateData(
                table: "SubAccount",
                keyColumn: "ID",
                keyValue: 1,
                column: "AccountPlanID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SubAccount",
                keyColumn: "ID",
                keyValue: 2,
                column: "AccountPlanID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "SubAccount",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Name", "Number" },
                values: new object[] { "5", 5 });

            migrationBuilder.InsertData(
                table: "SubAccount",
                columns: new[] { "ID", "AccountPlanID", "Name", "Number" },
                values: new object[,]
                {
                    { 11, 3, "3", 3 },
                    { 27, 4, "4", 4 },
                    { 222, 6, "6", 6 },
                    { 666, 7, "7", 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Deal",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Deal",
                keyColumn: "ID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Deal",
                keyColumn: "ID",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "SubAccount",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SubAccount",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SubAccount",
                keyColumn: "ID",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "SubAccount",
                keyColumn: "ID",
                keyValue: 666);

            migrationBuilder.UpdateData(
                table: "Deal",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Agreement", "Commission", "Date", "Number", "Order", "Price", "Quantity", "Tiker", "TotalCost", "Trader" },
                values: new object[] { 2f, 1f, new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, 2f, 3, "1", 1, 2 });

            migrationBuilder.UpdateData(
                table: "Deal",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Agreement", "Commission", "Date", "Number", "Order", "Price", "Quantity", "Tiker", "TotalCost", "Trader" },
                values: new object[] { 1f, 2f, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1f, 1, "3", 2, 1 });

            migrationBuilder.InsertData(
                table: "Deal",
                columns: new[] { "ID", "Agreement", "Commission", "Date", "Number", "Order", "Price", "Quantity", "Tiker", "TotalCost", "Trader" },
                values: new object[,]
                {
                    { 101, 202f, 111f, new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 205, 204, 208f, 307, "103", 109, 200 },
                    { 64, 63f, 777f, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 231, 262, 267f, 27, "163", 2222, 666 },
                    { 666, 777f, 666f, new DateTime(2020, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 777, 666, 777f, 666, "7676", 666, 777 }
                });

            migrationBuilder.UpdateData(
                table: "Operation",
                keyColumn: "ID",
                keyValue: 22,
                column: "DealID",
                value: 11);

            migrationBuilder.UpdateData(
                table: "SubAccount",
                keyColumn: "ID",
                keyValue: 1,
                column: "AccountPlanID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "SubAccount",
                keyColumn: "ID",
                keyValue: 2,
                column: "AccountPlanID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "SubAccount",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Name", "Number" },
                values: new object[] { "4", 4 });

            migrationBuilder.InsertData(
                table: "SubAccount",
                columns: new[] { "ID", "AccountPlanID", "Name", "Number" },
                values: new object[,]
                {
                    { 3, 4, "3", 3 },
                    { 5, 6, "5", 5 },
                    { 6, 7, "6", 6 },
                    { 7, 8, "7", 7 }
                });
        }
    }
}
