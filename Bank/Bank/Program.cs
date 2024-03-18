using Bank.midaleWare;
using Pagi.Core;
using Pagi.Core.Reposiroty;
using Pagi.Core.Services;
using Pagi.Data;
using Pagi.Data.Repository;
using Pagi.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IClerkService, ClerkService>();
builder.Services.AddScoped<IClerkRepository, ClerkRepository>();
builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<ITurnService,TurnService>();
builder.Services.AddScoped<ITurnRepository, TurnRepository>();
//builder.Services.AddSingleton<DataContext>(); 
builder.Services.AddDbContext<DataContext>();
builder.Services.AddAutoMapper(typeof(MappingProfile));
var policy = "policy";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: policy, policy =>
    {
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.UseMiddleware<shabatMidaleWare>();
app.MapControllers();
app.Run();
