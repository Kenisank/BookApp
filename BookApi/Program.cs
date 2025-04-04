var builder = WebApplication.CreateBuilder(args);

//Add Services
builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyCors", builder =>
    {
        builder
        .WithOrigins("http://localhost:4200")
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors("MyCors");
//Add Mapping
app.MapControllers();

app.MapGet("/", () =>
{
    return Results.Redirect("/api/books");
});

app.Run();
