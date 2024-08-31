using TallerTarea02Minimal.Infra.Data;
using TallerTarea02Minimal.Model;
using TallerTarea02Minimal.DTOs;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

//inyeccion de dependecias
builder.Services.AddSingleton<ITareaRepo, TareaRepo>();

var app = builder.Build();

app.MapGet("/", () => "Bienvenido!");

//curl http://localhost:5065/saludar
app.MapGet("/saludar", () => "Hola, como estás?");

//curl http://localhost:5065/tareas
app.MapGet("/tareas", (ITareaRepo tareaRepo) =>
{
    return Results.Ok(tareaRepo.GetTareas());
});

app.MapGet("/tareas/{id}", (int id, ITareaRepo tareaRepo) =>
{
    //Ejemplo con parseo de parámetros en url
    return Results.Ok(tareaRepo.Get(id));
});


// curl  -Method DELETE http://localhost:5065/tareas/1
app.MapDelete("/tareas/{id}", (int id, ITareaRepo tareaRepo) =>
{
    tareaRepo.Delete(id);
    return Results.Ok();
});

// int id, string? nombre, string? desc, int? duracion, string? responsable
// curl  -Method POST -ContentType  'application/json' -Body '{"id":5, "nombre":"Redes de Datos", "desc":"Alguna materia", "duracion":"5", "responsable":"El Profe"}' -Uri https://localhost:5065/tareas
app.MapPost("/tareas", ([FromBody] DTTarea dtTarea, ITareaRepo tareaRepo) =>
{
    Tarea newTarea = new(dtTarea.Id, dtTarea.Nombre, dtTarea.Desc, dtTarea.Duracion, dtTarea.Responsable); 
    tareaRepo.Add(newTarea);
    return Results.Ok();
});

app.Run();
