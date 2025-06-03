namespace GraphQLApi.Domain.Entities
{
    public class Customers
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime DateBirth { get; set; }
    }
}