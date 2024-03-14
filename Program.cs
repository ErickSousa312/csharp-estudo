var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => 
{
    Console.WriteLine("teste");
    return "Hello World3!";
 }   );

app.Run();
