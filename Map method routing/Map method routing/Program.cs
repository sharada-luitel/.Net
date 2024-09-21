var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseRouting();
app.UseEndpoints(endpoints =>
{

    endpoints.MapGet("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is Home page");
    });
});

//app.Map("/Home", () => "Hello World!");
//app.MapGet("/Home", () => "Hello World!-Get");
//app.MapPost("/Home", () => "Hello World!-post");
//app.MapPut("/Home", () => "Hello World!-put");
//app.MapDelete("/Home", () => "Hello World!Delete");

app.Run();
