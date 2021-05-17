using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations.Company
{
    public partial class reward2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reward",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    companyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    rewardDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rewardPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reward", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reward");
        }
    }
}
