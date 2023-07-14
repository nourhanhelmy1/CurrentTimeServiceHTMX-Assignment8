var webBuilder = WebApplication.CreateBuilder(args);
var app = webBuilder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/api/current-time", () =>
{
    var currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    return Results.Text(currentTime);
});

app.Run();
