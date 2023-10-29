﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP_NET__INMN3_hybryda__PA1._1_sp_wszyscy_Z1.Migrations
{
    /// <inheritdoc />
    public partial class Wstępna : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Miasta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Powierzchnia = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Populacja = table.Column<decimal>(type: "decimal(20,0)", nullable: true),
                    DataZałożenia = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Miasta", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Miasta");
        }
    }
}
