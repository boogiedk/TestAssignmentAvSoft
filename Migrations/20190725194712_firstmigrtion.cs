using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestAssignmentAvSoft.Migrations
{
    public partial class firstmigrtion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Counters",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Counters", x => x.Guid);
                });

            migrationBuilder.InsertData(
                table: "Counters",
                columns: new[] { "Guid", "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("2475094d-3975-40ff-9782-b9d4cd09ef6b"), 1, 1 },
                    { new Guid("ca630fce-083e-4d28-a646-9ba8677035f3"), 1, 2 },
                    { new Guid("e38c4443-4a30-4b1d-ac24-ffa7ba89e209"), 1, 3 },
                    { new Guid("58799f87-519e-460d-bc94-33fa6eff2e6c"), 2, 1 },
                    { new Guid("1e8239d2-518c-42b9-9637-33308b0dc814"), 2, 1 },
                    { new Guid("837997c9-7b48-4fe3-b700-604c9534b046"), 2, 3 },
                    { new Guid("3fb1ce83-8661-4bc7-95ef-3c6bd5129269"), 2, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Counters");
        }
    }
}
