var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();


app.MapGet("Hello", () => "This is very cool I hope");
app.MapGet("Product", () => "Get some Product from azure SQL");

app.Run();

