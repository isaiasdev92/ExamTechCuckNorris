using ExamenTech.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

var builderApp = new ConfigurationBuilder()
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName.ToLower()}.json", optional: true, reloadOnChange: true);

builderApp.AddEnvironmentVariables();

IConfigurationRoot config = builderApp.Build();
builder.Configuration.AddConfiguration(config);


builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddHttpClient();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
