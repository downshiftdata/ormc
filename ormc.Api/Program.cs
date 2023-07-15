using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Microsoft.AspNetCore.Builder.WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ormc.Ado.Repositories.IReadRepository, ormc.Ado.Repositories.ReadRepository>();
builder.Services.AddSingleton<ormc.Ado.Repositories.IWriteRepository, ormc.Ado.Repositories.WriteRepository>();

builder.Services.AddSingleton<ormc.Dapper.Repositories.IReadRepository, ormc.Dapper.Repositories.ReadRepository>();
builder.Services.AddSingleton<ormc.Dapper.Repositories.IWriteRepository, ormc.Dapper.Repositories.WriteRepository>();

builder.Services.AddDbContext<ormc.DataFirst.Models.Context>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("default"));
});

builder.Services.AddDbContext<ormc.CodeFirst.DataAccess.Context>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("cf"));
});

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    using (var context = scope.ServiceProvider.GetRequiredService<ormc.CodeFirst.DataAccess.Context>())
    {
        ormc.CodeFirst.DataAccess.Initializer.Initialize(context);
    }
}

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
