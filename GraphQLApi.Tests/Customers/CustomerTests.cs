using FluentAssertions;
using GraphQL;
using GraphQL.Types;
using GraphQLApi.Application.CustomersServices;
using GraphQLApi.Contracts.Customers.Dtos;
using GraphQLApi.Contracts.Customers.Inputs;
using GraphQLApi.Presentation.GraphQL.Customers.Mutations;
using GraphQLApi.Presentation.GraphQL.Customers.Queries;
using GraphQLApi.Presentation.GraphQL.Customers.Types;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Xunit;

namespace GraphQLApi.Tests.Customers
{
    public class CustomerTests
    {
        [Fact]
        public async Task Should_Query_Customers()
        {
            // Arrange
            var mockService = new Mock<ICustomersServices>();
            mockService.Setup(x => x.GetAllAsync())
                .ReturnsAsync(new[] { new CustomersDto { Name = "Test", DateBirth = new DateTime(2000, 1, 1) } });

            var services = new ServiceCollection();
            services.AddSingleton(mockService.Object);
            services.AddSingleton<CustomerType>();
            services.AddSingleton<CustomersQuery>();
            services.AddSingleton<ISchema, Schema>(provider => new Schema
            {
                Query = provider.GetRequiredService<CustomersQuery>()
            });

            var provider = services.BuildServiceProvider();
            var executor = new DocumentExecuter();

            // Act
            var result = await executor.ExecuteAsync(_ =>
            {
                _.Schema = provider.GetRequiredService<ISchema>();
                _.Query = "{ customers { name dateBirth } }";
                _.RequestServices = provider;
            });

            // Assert
            result.Errors.Should().BeNull();
            result.Data.Should().NotBeNull();
        }
    }
}