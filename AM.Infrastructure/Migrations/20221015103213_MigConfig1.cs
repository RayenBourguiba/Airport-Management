﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    public partial class MigConfig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Planes_PlaneId",
                table: "Flights");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Planes",
                table: "Planes");

            migrationBuilder.RenameTable(
                name: "Planes",
                newName: "MyPlanes");

            migrationBuilder.RenameColumn(
                name: "Capacity",
                table: "MyPlanes",
                newName: "PlaneCapacity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyPlanes",
                table: "MyPlanes",
                column: "PlaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_MyPlanes_PlaneId",
                table: "Flights",
                column: "PlaneId",
                principalTable: "MyPlanes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flights_MyPlanes_PlaneId",
                table: "Flights");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyPlanes",
                table: "MyPlanes");

            migrationBuilder.RenameTable(
                name: "MyPlanes",
                newName: "Planes");

            migrationBuilder.RenameColumn(
                name: "PlaneCapacity",
                table: "Planes",
                newName: "Capacity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Planes",
                table: "Planes",
                column: "PlaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Planes_PlaneId",
                table: "Flights",
                column: "PlaneId",
                principalTable: "Planes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
