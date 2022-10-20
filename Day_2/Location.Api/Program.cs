var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

var locations = new Location.Api.Location[]
{
    new Location.Api.Location
    {
        id = 1,
        Name = "Trixxo arena",
        Capacity = 16_000
    },
    new Location.Api.Location
    {
        id = 2,
        Name = "Sportpaleis",
        Capacity = 23_359
    },
    new Location.Api.Location
    {
        id = 3,
        Name = "Vorst Nationaal",
        Capacity = 8_000
    },
    new Location.Api.Location
    {
        id = 4,
        Name = "Paleis 12",
        Capacity = 15_000
    },
    new Location.Api.Location
    {
        id = 5,
        Name = "Trix",
        Capacity = 1_100
    },

};

app.MapGet("/location", () =>
{
    return locations;
});

app.MapGet("/location/{id:int}", (int id) =>
{
    var location = locations.FirstOrDefault(l => l.id == id);
    if (location == null)
        return Results.NotFound();
    return Results.Json(location);
});

app.Run();
