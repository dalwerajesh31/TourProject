using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETourProject1.Migrations
{
    /// <inheritdoc />
    public partial class Cost_MasterInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cost_Master",
                columns: table => new
                {
                    CostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    SinglePersonCost = table.Column<int>(type: "int", nullable: false),
                    ExtraPersonCost = table.Column<int>(type: "int", nullable: false),
                    ChildWithBed = table.Column<int>(type: "int", nullable: false),
                    ChildWithoutBed = table.Column<int>(type: "int", nullable: false),
                    ValidFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValidTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    pkgId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cost_Master", x => x.CostId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cost_Master");
        }
    }
}
