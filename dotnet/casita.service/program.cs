using casita.service;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(Server.Index);

app.Run();
