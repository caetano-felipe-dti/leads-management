using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Infra
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Lead> Leads { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Lead>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.FirstName).IsRequired().HasMaxLength(100);
                entity.Property(e => e.LastName).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(150);
                entity.Property(e => e.PhoneNumber).HasMaxLength(15);
                entity.Property(e => e.Suburb).HasMaxLength(100);
                entity.Property(e => e.Category).HasMaxLength(50);
                entity.Property(e => e.Description).HasMaxLength(500);
                entity.Property(e => e.Price).HasColumnType("decimal(18,2)");
                entity.Property(e => e.Status).IsRequired();
            });

            modelBuilder.Entity<Lead>().HasData(
                new Lead
                {
                    Id = 123457,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Email = "jane.smith@example.com",
                    PhoneNumber = "9876543210",
                    Suburb = "Melbourne",
                    Category = "Technology",
                    Description = "Looking for IT consulting services.",
                    Price = 1200,
                    Status = LeadStatus.Invited
                },
                new Lead
                {
                    Id = 123458,
                    FirstName = "Michael",
                    LastName = "Johnson",
                    Email = "michael.johnson@example.com",
                    PhoneNumber = "4567891230",
                    Suburb = "Brisbane",
                    Category = "Education",
                    Description = "Interested in online learning platforms.",
                    Price = 800,
                    Status = LeadStatus.Invited
                },
                new Lead
                {
                    Id = 123459,
                    FirstName = "Emily",
                    LastName = "Davis",
                    Email = "emily.davis@example.com",
                    PhoneNumber = "1230984567",
                    Suburb = "Perth",
                    Category = "Healthcare",
                    Description = "Seeking health insurance options.",
                    Price = 500,
                    Status = LeadStatus.Invited
                },
                new Lead
                {
                    Id = 123460,
                    FirstName = "Chris",
                    LastName = "Brown",
                    Email = "chris.brown@example.com",
                    PhoneNumber = "3216549870",
                    Suburb = "Adelaide",
                    Category = "Finance",
                    Description = "Looking for investment opportunities.",
                    Price = 1500,
                    Status = LeadStatus.Invited
                },
                new Lead
                {
                    Id = 123461,
                    FirstName = "Sarah",
                    LastName = "Wilson",
                    Email = "sarah.wilson@example.com",
                    PhoneNumber = "6543217890",
                    Suburb = "Canberra",
                    Category = "Real Estate",
                    Description = "Searching for commercial properties.",
                    Price = 2000,
                    Status = LeadStatus.Invited
                },
                new Lead
                {
                    Id = 123462,
                    FirstName = "David",
                    LastName = "Martinez",
                    Email = "david.martinez@example.com",
                    PhoneNumber = "7890123456",
                    Suburb = "Gold Coast",
                    Category = "Travel",
                    Description = "Planning a vacation package.",
                    Price = 700,
                    Status = LeadStatus.Invited
                },
                new Lead
                {
                    Id = 123463,
                    FirstName = "Laura",
                    LastName = "Garcia",
                    Email = "laura.garcia@example.com",
                    PhoneNumber = "8901234567",
                    Suburb = "Hobart",
                    Category = "Food & Beverage",
                    Description = "Looking for catering services.",
                    Price = 300,
                    Status = LeadStatus.Invited
                },
                new Lead
                {
                    Id = 123464,
                    FirstName = "James",
                    LastName = "Anderson",
                    Email = "james.anderson@example.com",
                    PhoneNumber = "5678901234",
                    Suburb = "Darwin",
                    Category = "Construction",
                    Description = "Interested in home renovation.",
                    Price = 2500,
                    Status = LeadStatus.Invited
                },
                new Lead
                {
                    Id = 123465,
                    FirstName = "Sophia",
                    LastName = "Lee",
                    Email = "sophia.lee@example.com",
                    PhoneNumber = "4321098765",
                    Suburb = "Newcastle",
                    Category = "Retail",
                    Description = "Looking for wholesale suppliers.",
                    Price = 1000,
                    Status = LeadStatus.Invited
                },
                new Lead
                {
                    Id = 123466,
                    FirstName = "Daniel",
                    LastName = "Taylor",
                    Email = "daniel.taylor@example.com",
                    PhoneNumber = "6789012345",
                    Suburb = "Geelong",
                    Category = "Automotive",
                    Description = "Interested in buying a new car.",
                    Price = 30000,
                    Status = LeadStatus.Invited
                }
            );
        }
    }
}
