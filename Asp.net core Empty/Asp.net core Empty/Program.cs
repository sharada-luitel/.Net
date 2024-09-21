var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Welcome To ASP.Net Core");
    await next(context);
});
app.Run(async (context) =>
{
await context.Response.WriteAsync("Hello");
});

app.Run();
