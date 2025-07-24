namespace Domain.Entities
{
    public class Transaction
    {
        public string Id { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string Type { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}
