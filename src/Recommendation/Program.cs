using MassTransit;
using MassTransit.NewIdProviders;
using Microsoft.AspNetCore.Mvc;
using Recommendation.Handlers;
using Recommendation.Infrastructure.Consumers.IntegrationEvents;
using Recommendation.Registeration;

var builder = WebApplication.CreateBuilder(args);


builder.Services.RegisterBroker(builder.Configuration);
builder.Services.RegisterRedis(builder.Configuration);

builder.Services.AddScoped<IRedisHandler, RedisHandler>();

// Add services to the container.

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


// Configure the HTTP request pipeline.

app.MapGet("/getRecommend", async (Guid userId, 
                                  [FromServices] IPublishEndpoint publishEndpoint, 
                                  [FromServices] IRedisHandler redisHandler) =>
{

    // raise event to user action history to add data to redis
    await publishEndpoint.Publish(new UserActionHistoryEvent(userId));


    // get useraction history info from redis
    var userActionHistoryData = await redisHandler.GetUserActionHistory(userId.ToString());


    return "";

}).WithName("Recommend");



app.Run();

