using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Leads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Suburb = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Category = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leads", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Leads",
                columns: new[] { "Id", "Category", "Description", "Email", "FirstName", "LastName", "PhoneNumber", "Price", "Status", "Suburb" },
                values: new object[] { 123456, "Real Estate", "Looking for a house in Sydney.", "john.doe@example.com", "Johndotnet ef migrations add AddLeadSeeds", "Doe", "1234567890", 600m, 0, "Sydney" });

            migrationBuilder.InsertData(
                table: "Leads",
                columns: new[] { "Id", "Category", "Description", "Email", "FirstName", "LastName", "PhoneNumber", "Price", "Status", "Suburb" },
                values: new object[] { 258147, "Technology", "Needs IT consulting services.", "alice.johnson@example.com", "Alice", "Johnson", "1122334455", 800m, 1, "Brisbane" });

            migrationBuilder.InsertData(
                table: "Leads",
                columns: new[] { "Id", "Category", "Description", "Email", "FirstName", "LastName", "PhoneNumber", "Price", "Status", "Suburb" },
                values: new object[] { 654321, "Automotive", "Interested in buying a car.", "jane.smith@example.com", "Jane", "Smith", "0987654321", 300m, 0, "Melbourne" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Leads");
        }
    }
}
