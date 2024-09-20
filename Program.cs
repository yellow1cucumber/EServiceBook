using DAL;

using Domain.Core.Users;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Context>(options => options.UseInMemoryDatabase("EServiceBook"));
builder.Services.AddTransient<Repository<User>>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

if (app.Environment.IsDevelopment())
{
    app.MapGet("/users", async (Repository<User> users) => await users.GetAllAsync().ToArrayAsync());
    app.MapGet("/users/id", async (Repository<User> users, int id) => await users.GetAsync(id));
    app.MapPost("/users", async (Repository<User> users, User user) => await users.AddAsync(user));
    app.MapPut("/users", async (Repository<User> users, User user) => await users.UpdateAsync(user));
    app.MapDelete("/users", async (Repository<User> users, int id) => await users.RemoveAsync(id));
}

app.Run();
