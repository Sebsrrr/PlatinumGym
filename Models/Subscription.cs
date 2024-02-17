namespace PlatinumGym.Models
{
    public class Subscription
    {
        public int SubscriptionID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ICollection<Appointment>? Appointments { get; set;}
    }
}
