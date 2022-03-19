using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Identity;
using WebApplication3;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
var app = builder.Build();
var identities = new List<Users>();


app.UseSwagger();
app.UseSwaggerUI();
app.MapGet("/", () =>
{

});

app.MapPost(pattern: "/signup", handler: (Users Person) =>
{
    identities.Add(Person);
    return "Done";

});

app.MapPost(pattern: "/signin", handler: (Body person) =>
{
    var ulogin = identities.Find(i => i.Login == person.Login);
    if (ulogin == null)
    {
        return "Введен неверный логин";

    }

    var upassword = identities.Find(i => i.Password == person.Password);
    if (upassword == null)
    {

        return "Введен неверный пароль";

    }

    return "Данные не введены";
});


app.Run();
