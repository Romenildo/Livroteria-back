using Livroteria_back.Data;
using Livroteria_back.Repository;
using Livroteria_back.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionStringDB = builder.Configuration.GetConnectionString("DataBase");

builder.Services.AddDbContext<DataContext>(
                    options => options.UseSqlServer(connectionStringDB)
         );

//injecoes de dependencias
builder.Services.AddScoped<ILivroRepository, LivroRepository>();

builder.Services.AddCors(opt => {
    opt.AddPolicy("CorsPolicy", builder => builder
    .AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod()

    );
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
