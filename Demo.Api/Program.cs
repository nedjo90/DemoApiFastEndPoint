using FastEndpoints;

WebApplicationBuilder builder = WebApplication.CreateBuilder();
builder.Services.AddFastEndpoints();

WebApplication app = builder.Build();
app.UseFastEndpoints();
app.Run();