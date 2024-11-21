namespace tp4.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int? MembershipTypeId { get; set; }
        public MembershipType MembershipType { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }
}