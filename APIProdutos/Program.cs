using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlite("Data Source=app.db"));

var app = builder.Build();

app.MapGet("/produtos/{id}", (int id, AppDbContext db) =>
{
    var produto = db.Produtos.Find(id);
    if (produto == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(produto);
});

app.MapPost("/produtoa", (Produto produto, AppDbContext db) =>
{
    db.Produtos.Add(produto);
    db.SaveChanges();
    return Results.Created();
});

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.Run();

