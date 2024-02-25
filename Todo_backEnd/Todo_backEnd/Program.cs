using Todo_backEnd.Repository;
using Todo_backEnd.Repository.LogInRepositoryImpl;
using Todo_backEnd.Repository.LogInRepositoryInterface;
using Todo_backEnd.Repository.RepositoryImpl;
using Todo_backEnd.Service.LogInServiseImpl;
using Todo_backEnd.Service.LogInServiseInterface;
using Todo_backEnd.Service.serviceImpl;
using Todo_backEnd.Service.serviceInterface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();




builder.Services.AddScoped<ILogInGet, rLogInGet>();
builder.Services.AddScoped<ILogInGetService, LogInGetService>();

builder.Services.AddScoped<ILogInAdd, rLogInAdd>();
builder.Services.AddScoped<ILogInAddService, LogInAddService>();

builder.Services.AddScoped<ICrudGetById, CrudGetById>();
builder.Services.AddScoped<ICrudGetByIdService, CrudGetByIdService>();

builder.Services.AddScoped<ICrudUpdate, CrudUpdate>();
builder.Services.AddScoped<ICrudUpdateService, CrudUpdateService>();

builder.Services.AddScoped<ICrudDelete, CrudDelete>();
builder.Services.AddScoped<ICrudDeleteService, CrudDeleteService>();

builder.Services.AddScoped<ICrudAdd, CrudAdd>();
builder.Services.AddScoped<ICrudAddService, CrudAddService>();

builder.Services.AddScoped<ICrudGet, CrudGet>();
builder.Services.AddScoped<ICrudGetService, CrudGetService>();





var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
