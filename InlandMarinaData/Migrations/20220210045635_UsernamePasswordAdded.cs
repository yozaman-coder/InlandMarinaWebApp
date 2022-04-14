﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace InlandMarinaData.Migrations
{
    public partial class UsernamePasswordAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    City = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Dock",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    WaterService = table.Column<bool>(type: "bit", nullable: false),
                    ElectricalService = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dock", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Slip",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false),
                    DockID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slip", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Slip_Dock_DockID",
                        column: x => x.DockID,
                        principalTable: "Dock",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lease",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SlipID = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lease", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Lease_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lease_Slip_SlipID",
                        column: x => x.SlipID,
                        principalTable: "Slip",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "ID", "City", "FirstName", "LastName", "Password", "Phone", "Username" },
                values: new object[,]
                {
                    { 1, "Phoenix", "John", "Doe", "password", "265-555-1212", "jdoe" },
                    { 2, "Calgary", "Sara", "Williams", "password", "403-555-9585", "swilliams" },
                    { 3, "Kansas City", "Ken", "Wong", "password", "802-555-3214", "kwong" }
                });

            migrationBuilder.InsertData(
                table: "Dock",
                columns: new[] { "ID", "ElectricalService", "Name", "WaterService" },
                values: new object[,]
                {
                    { 1, true, "Dock A", true },
                    { 2, false, "Dock B", true },
                    { 3, true, "DockC", false }
                });

            migrationBuilder.InsertData(
                table: "Slip",
                columns: new[] { "ID", "DockID", "Length", "Width" },
                values: new object[,]
                {
                    { 1, 1, 16, 8 },
                    { 65, 3, 22, 10 },
                    { 64, 3, 22, 10 },
                    { 63, 3, 22, 10 },
                    { 62, 3, 22, 10 },
                    { 61, 3, 22, 10 },
                    { 60, 2, 32, 8 },
                    { 59, 2, 32, 8 },
                    { 58, 2, 32, 8 },
                    { 66, 3, 22, 10 },
                    { 57, 2, 32, 8 },
                    { 55, 2, 32, 8 },
                    { 54, 2, 30, 8 },
                    { 53, 2, 30, 8 },
                    { 52, 2, 30, 8 },
                    { 51, 2, 30, 8 },
                    { 50, 2, 30, 8 },
                    { 49, 2, 28, 8 },
                    { 48, 2, 28, 8 },
                    { 56, 2, 32, 8 },
                    { 67, 3, 22, 10 },
                    { 68, 3, 22, 10 },
                    { 69, 3, 22, 10 },
                    { 88, 3, 32, 12 },
                    { 87, 3, 32, 12 },
                    { 86, 3, 32, 12 },
                    { 85, 3, 28, 12 },
                    { 84, 3, 28, 12 },
                    { 83, 3, 28, 12 },
                    { 82, 3, 28, 12 },
                    { 81, 3, 28, 12 },
                    { 80, 3, 28, 12 },
                    { 79, 3, 28, 12 },
                    { 78, 3, 28, 12 },
                    { 77, 3, 24, 10 },
                    { 76, 3, 24, 10 },
                    { 75, 3, 24, 10 },
                    { 74, 3, 24, 10 },
                    { 73, 3, 24, 10 },
                    { 72, 3, 24, 10 },
                    { 71, 3, 24, 10 },
                    { 70, 3, 24, 10 }
                });

            migrationBuilder.InsertData(
                table: "Slip",
                columns: new[] { "ID", "DockID", "Length", "Width" },
                values: new object[,]
                {
                    { 47, 2, 28, 8 },
                    { 46, 2, 24, 8 },
                    { 45, 2, 24, 8 },
                    { 44, 2, 24, 8 },
                    { 20, 1, 26, 8 },
                    { 19, 1, 24, 8 },
                    { 18, 1, 24, 8 },
                    { 17, 1, 24, 8 },
                    { 16, 1, 24, 8 },
                    { 15, 1, 22, 8 },
                    { 14, 1, 22, 8 },
                    { 13, 1, 22, 8 },
                    { 12, 1, 22, 8 },
                    { 11, 1, 20, 8 },
                    { 10, 1, 20, 8 },
                    { 9, 1, 20, 8 },
                    { 8, 1, 20, 8 },
                    { 7, 1, 20, 8 },
                    { 6, 1, 16, 8 },
                    { 5, 1, 16, 8 },
                    { 4, 1, 16, 8 },
                    { 3, 1, 16, 8 },
                    { 2, 1, 16, 8 },
                    { 21, 1, 26, 8 },
                    { 89, 3, 32, 12 },
                    { 22, 1, 26, 8 },
                    { 24, 1, 26, 8 },
                    { 43, 2, 24, 8 },
                    { 42, 2, 22, 8 },
                    { 41, 2, 22, 8 },
                    { 40, 2, 22, 8 },
                    { 39, 2, 20, 8 },
                    { 38, 2, 20, 8 },
                    { 37, 2, 20, 8 },
                    { 36, 2, 18, 8 },
                    { 35, 2, 18, 8 },
                    { 34, 2, 18, 8 },
                    { 33, 2, 18, 8 },
                    { 32, 2, 18, 8 },
                    { 31, 2, 18, 8 },
                    { 30, 1, 28, 8 },
                    { 29, 1, 28, 8 }
                });

            migrationBuilder.InsertData(
                table: "Slip",
                columns: new[] { "ID", "DockID", "Length", "Width" },
                values: new object[,]
                {
                    { 28, 1, 28, 8 },
                    { 27, 1, 28, 8 },
                    { 26, 1, 28, 8 },
                    { 25, 1, 26, 8 },
                    { 23, 1, 26, 8 },
                    { 90, 3, 32, 12 }
                });

            migrationBuilder.InsertData(
                table: "Lease",
                columns: new[] { "ID", "CustomerID", "SlipID" },
                values: new object[] { 1, 1, 20 });

            migrationBuilder.InsertData(
                table: "Lease",
                columns: new[] { "ID", "CustomerID", "SlipID" },
                values: new object[] { 2, 2, 42 });

            migrationBuilder.InsertData(
                table: "Lease",
                columns: new[] { "ID", "CustomerID", "SlipID" },
                values: new object[] { 3, 3, 88 });

            migrationBuilder.CreateIndex(
                name: "IX_Lease_CustomerID",
                table: "Lease",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Lease_SlipID",
                table: "Lease",
                column: "SlipID");

            migrationBuilder.CreateIndex(
                name: "IX_Slip_DockID",
                table: "Slip",
                column: "DockID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lease");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Slip");

            migrationBuilder.DropTable(
                name: "Dock");
        }
    }
}
