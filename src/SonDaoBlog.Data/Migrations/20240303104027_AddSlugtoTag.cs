﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SonDaoBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSlugtoTag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Tags",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Tags");
        }
    }
}