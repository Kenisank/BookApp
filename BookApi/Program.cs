var builder = WebApplication.CreateBuilder(args);

//Add Services
builder.Services.AddControllers();

var app = builder.Build();


//Add Mapping
app.MapControllers();

app.MapGet("/", () =>
{
    return Results.Redirect("/api/books");
});

app.Run();
