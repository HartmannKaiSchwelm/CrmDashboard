namespace CrmDashboard.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string Company { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public decimal Revenue { get; set; }

    }
}