using MiddlewareTest.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

Console.WriteLine("PIG: app built");
// -----
app.Use(async (context, next) =>
{
    Console.WriteLine("PIG: 1 start");

    await next.Invoke();

    Console.WriteLine("PIG: 1 end");
});
app.UseMiddleware<CatMiddleware>();
app.UseMiddleware<DogMiddleware>();
//app.UseCATCATMiddleware();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    Console.WriteLine("PIG: Swagger");
    app.UseSwaggerUI();
    Console.WriteLine("PIG: SwaggerUI");
}

app.UseHttpsRedirection();
Console.WriteLine("PIG: UseHttpsRedirection");

app.UseAuthorization();
Console.WriteLine("PIG: UseAuthorization");




app.MapControllers();
Console.WriteLine("PIG: MapControllers");

app.Run();
Console.WriteLine("PIG: app.Run");