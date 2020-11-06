using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _3._1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountPlan",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountPlan", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Deal",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Agreement = table.Column<float>(nullable: false),
                    Tiker = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<float>(nullable: false),
                    TotalCost = table.Column<int>(nullable: false),
                    Trader = table.Column<int>(nullable: false),
                    Commission = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deal", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Operation",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DealID = table.Column<int>(nullable: false),
                    SubAccountID = table.Column<int>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Sum = table.Column<float>(nullable: false),
                    SaldoInput = table.Column<float>(nullable: false),
                    SaldoOutput = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operation", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SubAccount",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountPlanID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubAccount", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "AccountPlan",
                columns: new[] { "ID", "Name", "Number", "Type" },
                values: new object[,]
                {
                    { 1, "2", 3, "3" },
                    { 2, "3", 2, "4" },
                    { 3, "4", 4, "5" },
                    { 4, "5", 5, "6" },
                    { 5, "6", 6, "7" },
                    { 6, "7", 7, "8" },
                    { 7, "8", 8, "9" }
                });

            migrationBuilder.InsertData(
                table: "Deal",
                columns: new[] { "ID", "Agreement", "Commission", "Date", "Number", "Order", "Price", "Quantity", "Tiker", "TotalCost", "Trader" },
                values: new object[,]
                {
                    { 64, 63f, 777f, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 231, 262, 267f, 27, "163", 2222, 666 },
                    { 101, 202f, 111f, new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 205, 204, 208f, 307, "103", 109, 200 },
                    { 13, 22f, 101f, new DateTime(2020, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 24, 28f, 7, "13", 19, 200 },
                    { 666, 777f, 666f, new DateTime(2020, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 777, 666, 777f, 666, "7676", 666, 777 },
                    { 2, 1f, 2f, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1f, 1, "3", 2, 1 },
                    { 1, 2f, 1f, new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, 2f, 3, "1", 1, 2 },
                    { 11, 22f, 14f, new DateTime(2020, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 23, 25f, 30, "111", 17, 26 }
                });

            migrationBuilder.InsertData(
                table: "Operation",
                columns: new[] { "ID", "Data", "DealID", "Number", "SaldoInput", "SaldoOutput", "SubAccountID", "Sum", "Type" },
                values: new object[,]
                {
                    { 666, new DateTime(2020, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 777, 777, 666f, 777f, 666, 777f, "666" },
                    { 13, new DateTime(2020, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 5, 17f, 18f, 4, 16f, "1643" },
                    { 22, new DateTime(2020, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 15, 32f, 11f, 27, 10f, "154" },
                    { 200, new DateTime(2020, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 111, 112, 321f, 143f, 222, 167f, "1112" },
                    { 2, new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 3f, 1f, 2, 1f, "1" },
                    { 1, new DateTime(2020, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, 1f, 2f, 1, 2f, "3" },
                    { 11, new DateTime(2020, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 22, 11f, 22f, 11, 20f, "30" }
                });

            migrationBuilder.InsertData(
                table: "SubAccount",
                columns: new[] { "ID", "AccountPlanID", "Name", "Number" },
                values: new object[,]
                {
                    { 6, 7, "6", 6 },
                    { 1, 2, "1", 2 },
                    { 2, 3, "2", 1 },
                    { 3, 4, "3", 3 },
                    { 4, 5, "4", 4 },
                    { 5, 6, "5", 5 },
                    { 7, 8, "7", 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountPlan");

            migrationBuilder.DropTable(
                name: "Deal");

            migrationBuilder.DropTable(
                name: "Operation");

            migrationBuilder.DropTable(
                name: "SubAccount");
        }
    }
}
