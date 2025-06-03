namespace GraphQLApi.Contracts.Customers.Inputs
{
    public class CreateCustomersInput
    {
        public string Name { get; set; } = string.Empty;
        public DateTime DateBirth { get; set; }
    }
}