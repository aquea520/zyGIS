using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace zyGIS.Migrations
{
    public partial class _20180208154009 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Peoples",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Peoples",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Peoples",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "Peoples",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Peoples",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "Peoples",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Peoples",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Peoples");
        }
    }
}
