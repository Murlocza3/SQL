using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _3._1.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Deal",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Deal",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Deal",
                keyColumn: "ID",
                keyValue: 13);

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
                    { 7, 777f, 666f, new DateTime(2020, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 777, 666, 777f, 666, "7676", 666, 777 },
                    { 3, 22f, 14f, new DateTime(2020, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 23, 25f, 30, "111", 17, 26 },
                    { 5, 202f, 111f, new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 205, 204, 208f, 307, "103", 109, 200 },
                    { 4, 22f, 101f, new DateTime(2020, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 24, 28f, 7, "13", 19, 200 },
                    { 6, 63f, 777f, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 231, 262, 267f, 27, "163", 2222, 666 }
                });

            migrationBuilder.UpdateData(
                table: "Operation",
                keyColumn: "ID",
                keyValue: 1,
                column: "DealID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Operation",
                keyColumn: "ID",
                keyValue: 2,
                column: "DealID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Operation",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DealID", "SubAccountID" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Operation",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DealID", "SubAccountID" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Operation",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "DealID", "SubAccountID" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "Operation",
                keyColumn: "ID",
                keyValue: 200,
                columns: new[] { "DealID", "SubAccountID" },
                values: new object[] { 6, 6 });

            migrationBuilder.UpdateData(
                table: "Operation",
                keyColumn: "ID",
                keyValue: 666,
                columns: new[] { "DealID", "SubAccountID" },
                values: new object[] { 7, 7 });

            migrationBuilder.UpdateData(
                table: "SubAccount",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AccountPlanID", "Name", "Number" },
                values: new object[] { 4, "4", 4 });

            migrationBuilder.InsertData(
                table: "SubAccount",
                columns: new[] { "ID", "AccountPlanID", "Name", "Number" },
                values: new object[,]
                {
                    { 3, 3, "3", 3 },
                    { 5, 5, "5", 5 },
                    { 6, 6, "6", 6 },
                    { 7, 7, "7", 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Deal",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Deal",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Deal",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Deal",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Deal",
                keyColumn: "ID",
                keyValue: 7);

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
                    { 777, 777f, 666f, new DateTime(2020, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 777, 666, 777f, 666, "7676", 666, 777 },
                    { 11, 22f, 14f, new DateTime(2020, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 23, 25f, 30, "111", 17, 26 },
                    { 9, 202f, 111f, new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 205, 204, 208f, 307, "103", 109, 200 },
                    { 13, 22f, 101f, new DateTime(2020, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 24, 28f, 7, "13", 19, 200 },
                    { 111, 63f, 777f, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 231, 262, 267f, 27, "163", 2222, 666 }
                });

            migrationBuilder.UpdateData(
                table: "Operation",
                keyColumn: "ID",
                keyValue: 1,
                column: "DealID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Operation",
                keyColumn: "ID",
                keyValue: 2,
                column: "DealID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Operation",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DealID", "SubAccountID" },
                values: new object[] { 22, 11 });

            migrationBuilder.UpdateData(
                table: "Operation",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DealID", "SubAccountID" },
                values: new object[] { 9, 4 });

            migrationBuilder.UpdateData(
                table: "Operation",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "DealID", "SubAccountID" },
                values: new object[] { 13, 27 });

            migrationBuilder.UpdateData(
                table: "Operation",
                keyColumn: "ID",
                keyValue: 200,
                columns: new[] { "DealID", "SubAccountID" },
                values: new object[] { 111, 222 });

            migrationBuilder.UpdateData(
                table: "Operation",
                keyColumn: "ID",
                keyValue: 666,
                columns: new[] { "DealID", "SubAccountID" },
                values: new object[] { 777, 666 });

            migrationBuilder.UpdateData(
                table: "SubAccount",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AccountPlanID", "Name", "Number" },
                values: new object[] { 5, "5", 5 });

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
    }
}
