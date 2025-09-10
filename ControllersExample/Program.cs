var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();//Adds all Controllers

var app = builder.Build();
app.MapControllers();//Call Controllers
app.Run();
