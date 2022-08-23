using LibraryProject.Domain.AutoMapper;
using LibraryProject.Domain.Handlers.HandlerCommands;
using LibraryProject.Domain.Interfaces;
using LibraryProject.Domain.Interfaces.Implementations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<LibraryDBContext>
    (opt => opt.UseMySQL
         ("Data Source=localhost;DataBase=LIBRARYAPI;Uid=root;Pwd:semps4naNH#"));


builder.Services.AddAutoMapper(typeof(DomainProfileCore));

builder.Services.AddScoped<IBookCommand, CreateBookHandler>();
builder.Services.AddScoped<IBookService, BookServices>();
builder.Services.AddScoped<IBookRepository, BookRepository>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();