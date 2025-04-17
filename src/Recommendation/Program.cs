var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.


app.MapGet("/getRecommend", (Guid userId) =>
{
    return "";
});


app.Run();

