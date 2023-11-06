using Microsoft.EntityFrameworkCore;
using PeopleApi.Data;
using PeopleApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IPersonRepository , PersonRepository>();
builder.Services.AddScoped<IPersonService, PersonService>();
var app = builder.Build();
// Configurationde l'application
ConfigurationManager configuration = builder.Configuration;
//DbContext
builder.Services.AddDbContext<PersonDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnexion"), x => x.MigrationsAssembly("PeopleApi")));
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
