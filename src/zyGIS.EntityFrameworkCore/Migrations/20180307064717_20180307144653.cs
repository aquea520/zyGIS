using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace zyGIS.Migrations
{
    public partial class _20180307144653 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrimaryKey",
                table: "TableConfigs",
                newName: "IsPrimaryKey");

            migrationBuilder.RenameColumn(
                name: "Precision",
                table: "TableConfigs",
                newName: "Scale");

            migrationBuilder.RenameColumn(
                name: "IsNull",
                table: "TableConfigs",
                newName: "IsNullable");

            migrationBuilder.RenameColumn(
                name: "Increment",
                table: "TableConfigs",
                newName: "IsIdentity");

            migrationBuilder.RenameColumn(
                name: "DataType",
                table: "TableConfigs",
                newName: "ColumnType");

            migrationBuilder.AddColumn<int>(
                name: "ByteLength",
                table: "TableConfigs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CSharpType",
                table: "TableConfigs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CharLength",
                table: "TableConfigs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DBId",
                table: "TableConfigs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ByteLength",
                table: "TableConfigs");

            migrationBuilder.DropColumn(
                name: "CSharpType",
                table: "TableConfigs");

            migrationBuilder.DropColumn(
                name: "CharLength",
                table: "TableConfigs");

            migrationBuilder.DropColumn(
                name: "DBId",
                table: "TableConfigs");

            migrationBuilder.RenameColumn(
                name: "Scale",
                table: "TableConfigs",
                newName: "Precision");

            migrationBuilder.RenameColumn(
                name: "IsPrimaryKey",
                table: "TableConfigs",
                newName: "PrimaryKey");

            migrationBuilder.RenameColumn(
                name: "IsNullable",
                table: "TableConfigs",
                newName: "IsNull");

            migrationBuilder.RenameColumn(
                name: "IsIdentity",
                table: "TableConfigs",
                newName: "Increment");

            migrationBuilder.RenameColumn(
                name: "ColumnType",
                table: "TableConfigs",
                newName: "DataType");
        }
    }
}
