var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();


app.MapGet("Hello", () => "This is very cool I hope asdf");
app.MapGet("Product", () => "Get some Product from azure SQL");

app.MapPost("Product", (Product p) => "Product saved in SQL");
app.MapDelete("Product", (string name) => "Deleted");

app.MapPost("Chat", (Message msg) => "Message posted to chat SQL");


app.Run();

// Some Data Contracts

public record class Message(string name, string Msg);
public record class Product(string name, string Picture,int price);

