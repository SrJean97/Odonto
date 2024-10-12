using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Odonto.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class tableservices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    SER_SERVICE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SER_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SER_DESCRIPTION = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    SER_STATUS = table.Column<bool>(type: "bit", nullable: false, defaultValue: 1),
                    SER_USER_CREATE = table.Column<int>(type: "int", nullable: false),
                    SER_CREATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    SER_USER_UPDATE = table.Column<int>(type: "int", nullable: true),
                    SER_USER_DELETE = table.Column<int>(type: "int", nullable: true),
                    SER_UPDATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SER_DELETE_DATE = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.SER_SERVICE_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
