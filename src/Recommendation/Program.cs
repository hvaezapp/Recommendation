using MassTransit;
using Microsoft.AspNetCore.Http.HttpResults;
using Recommendation.Infrastructure.Consumers.IntegrationEvents;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.MapGet("/getRecommend", async (Guid userId , IPublishEndpoint publishEndpoint) =>
{
    await publishEndpoint.Publish(new GetUserActionHistoryEvent(userId));


    return "";
});



app.Run();

