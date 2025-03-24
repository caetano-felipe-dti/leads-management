using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    public partial class AddSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 123456);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 258147);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 654321);

            migrationBuilder.InsertData(
                table: "Leads",
                columns: new[] { "Id", "Category", "Description", "Email", "FirstName", "LastName", "PhoneNumber", "Price", "Status", "Suburb" },
                values: new object[,]
                {
                    { 123457, "Technology", "Looking for IT consulting services.", "jane.smith@example.com", "Jane", "Smith", "9876543210", 1200m, 0, "Melbourne" },
                    { 123458, "Education", "Interested in online learning platforms.", "michael.johnson@example.com", "Michael", "Johnson", "4567891230", 800m, 0, "Brisbane" },
                    { 123459, "Healthcare", "Seeking health insurance options.", "emily.davis@example.com", "Emily", "Davis", "1230984567", 500m, 0, "Perth" },
                    { 123460, "Finance", "Looking for investment opportunities.", "chris.brown@example.com", "Chris", "Brown", "3216549870", 1500m, 0, "Adelaide" },
                    { 123461, "Real Estate", "Searching for commercial properties.", "sarah.wilson@example.com", "Sarah", "Wilson", "6543217890", 2000m, 0, "Canberra" },
                    { 123462, "Travel", "Planning a vacation package.", "david.martinez@example.com", "David", "Martinez", "7890123456", 700m, 0, "Gold Coast" },
                    { 123463, "Food & Beverage", "Looking for catering services.", "laura.garcia@example.com", "Laura", "Garcia", "8901234567", 300m, 0, "Hobart" },
                    { 123464, "Construction", "Interested in home renovation.", "james.anderson@example.com", "James", "Anderson", "5678901234", 2500m, 0, "Darwin" },
                    { 123465, "Retail", "Looking for wholesale suppliers.", "sophia.lee@example.com", "Sophia", "Lee", "4321098765", 1000m, 0, "Newcastle" },
                    { 123466, "Automotive", "Interested in buying a new car.", "daniel.taylor@example.com", "Daniel", "Taylor", "6789012345", 30000m, 0, "Geelong" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 123457);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 123458);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 123459);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 123460);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 123461);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 123462);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 123463);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 123464);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 123465);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 123466);

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
    }
}
