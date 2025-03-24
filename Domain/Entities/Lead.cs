namespace Domain.Entities
{
    public class Lead
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Suburb { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public LeadStatus Status { get; set; }

        public Lead()
        {

        }

        public void Accept()
        {
            if (Price > 500)
            {
                Price -= Price * 0.10m;
            }
            Status = LeadStatus.Accepted;
        }

        public void Decline()
        {
            Status = LeadStatus.Declined;
        }
    }

    public enum LeadStatus
    {
        Invited,
        Accepted,
        Declined
    }
}
