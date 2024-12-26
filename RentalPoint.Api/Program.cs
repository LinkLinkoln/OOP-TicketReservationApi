using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using TicketBookingApplication.Api;
using TicketBookingApplication.Api.Interfaces.Repositories;
using TicketBookingApplication.Api.Interfaces.Services;
using TicketBookingApplication.Api.Middlewares;
using TicketBookingApplication.Api.Profiles;
using TicketBookingApplication.Api.Repositories;
using TicketBookingApplication.Api.Repositories.TicketBookingApplication.Api.Repositories;
using TicketBookingApplication.Api.Services;
using TicketBookingApplication.Api.Validators;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
                            ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection")))); 

builder.Services.AddControllers();

builder.Services.AddSwaggerGen();

builder.Services.AddFluentValidationAutoValidation()
    .AddFluentValidationClientsideAdapters()
    .AddValidatorsFromAssemblyContaining<ClientRequestValidator>();

builder.Services.AddScoped<IGenreRepository, GenreRepository>();
builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<ISessionRepository, SessionRepository>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<ITicketRepository, TicketRepository>();

builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<ITicketService, TicketService>();
builder.Services.AddScoped<ISessionService, SessionService>();
builder.Services.AddScoped<IGenreService, GenreService>();

builder.Services.AddAutoMapper(typeof(ApiProfile));

var app = builder.Build();

app.UseMiddleware<ExceptionHandlingMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.ApplyMigrations();
}


app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
