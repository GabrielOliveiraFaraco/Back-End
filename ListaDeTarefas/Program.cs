var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

var tarefas = new List<Tarefas>();

app.MapGet("/tarefas", () =>
{
    return Results.Ok(tarefas);
});

app.MapGet("/tarefas/{id}", (int id) =>
{
    var tarefa = tarefas.FirstOrDefault(t => t.Id == id);
    return tarefa is not null ? Results.Ok(tarefa) : Results.NotFound();
});

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();


app.Run();