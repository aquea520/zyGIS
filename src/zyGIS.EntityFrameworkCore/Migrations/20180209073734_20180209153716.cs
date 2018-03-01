using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace zyGIS.Migrations
{
    public partial class _20180209153716 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Increment",
                table: "TableConfigs",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Increment",
                table: "TableConfigs",
                nullable: true,
                oldClrType: typeof(bool),
                oldNullable: true);
        }
    }
}
