
using api.Queries;
using HotChocolate.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//https://dev.to/moe23/net-5-api-with-graphql-step-by-step-2b20
//https://blog.jeremylikness.com/blog/graphql-for-dotnet-developers/

builder.Services.AddGraphQLServer().AddQueryType<Query>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

// app.UsePlayground(new PlaygroundOptions
// {
//     QueryPath = "/api",
//     Path = "/playground"
// });

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL("/");
});

app.Run();
