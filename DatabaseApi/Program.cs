using DatabaseApp.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// ����������� ������������ ��� IDatabaseConnection � DataManager
builder.Services.AddControllers();
builder.Services.AddTransient<IDatabaseConnection, SqlDatabaseConnection>(); // ��� NoSqlDatabaseConnection
builder.Services.AddTransient<DataManager>();

// Swagger ��� ������������ API
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// ��������� ��������� HTTP-��������
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
