namespace GraphQLApi.Contracts.Customers.Dtos
{
    public class CustomersDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime DateBirth { get; set; }
    }
}