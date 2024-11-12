using DatabaseApp.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Регистрация зависимостей для IDatabaseConnection и DataManager
builder.Services.AddControllers();
builder.Services.AddTransient<IDatabaseConnection, SqlDatabaseConnection>(); // или NoSqlDatabaseConnection
builder.Services.AddTransient<DataManager>();

// Swagger для документации API
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Настройка конвейера HTTP-запросов
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
