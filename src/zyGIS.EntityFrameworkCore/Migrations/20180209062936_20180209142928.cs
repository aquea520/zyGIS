using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace zyGIS.Migrations
{
    public partial class _20180209142928 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ZYGIS_SYS_TableConfigs");

            migrationBuilder.CreateTable(
                name: "TableConfigs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ColumnName = table.Column<string>(nullable: true),
                    DataType = table.Column<string>(nullable: true),
                    DefaultValue = table.Column<string>(nullable: true),
                    Increment = table.Column<int>(nullable: true),
                    IsNull = table.Column<bool>(nullable: true),
                    Precision = table.Column<int>(nullable: true),
                    PrimaryKey = table.Column<bool>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableConfigs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TableConfigs");

            migrationBuilder.CreateTable(
                name: "ZYGIS_SYS_TableConfigs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ColumnName = table.Column<string>(nullable: true),
                    DataType = table.Column<string>(nullable: true),
                    DefaultValue = table.Column<string>(nullable: true),
                    Increment = table.Column<int>(nullable: true),
                    IsNull = table.Column<bool>(nullable: true),
                    Precision = table.Column<int>(nullable: true),
                    PrimaryKey = table.Column<bool>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZYGIS_SYS_TableConfigs", x => x.Id);
                });
        }
    }
}
