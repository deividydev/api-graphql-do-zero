using GraphQL.Server.Ui.GraphiQL;
using GraphQLApi.Application.CustomersServices;
using GraphQLApi.Domain.Repositories;
using GraphQLApi.Infrastructure.Repositories;
using GraphQLApi.Presentation.GraphQL.Customers.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ICustomersRepository, InMemoryCustomersRepository>();
builder.Services.AddSingleton<ICustomersServices, CustomersService>();

builder.Services.AddCustomersGraphQLSchema();

var app = builder.Build();

app.UseRouting();

app.UseGraphQL("/graphql");

app.UseGraphQLGraphiQL("/", new GraphiQLOptions
{
    GraphQLEndPoint = "/graphql",
    SubscriptionsEndPoint = "/graphql",
});


app.Run();