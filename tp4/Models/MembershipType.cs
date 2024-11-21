namespace tp4.Models
{
    public class MembershipType
    {
        public int Id { get; set; }
        public decimal SignUpFee { get; set; }
        public int DurationInMonths { get; set; }
        public int DiscountRate { get; set; }

        public ICollection<Customer> Customers { get; set; }
    }
}