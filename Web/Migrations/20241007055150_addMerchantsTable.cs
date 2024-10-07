using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Migrations
{
    /// <inheritdoc />
    public partial class addMerchantsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Merchants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LupCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LupRSType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Connectivity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LupCardType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LupDiscMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LupAcctType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LupStmtDest = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LupAuthType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LupDailyDisc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LupMCCType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchants", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Merchants");
        }
    }
}
