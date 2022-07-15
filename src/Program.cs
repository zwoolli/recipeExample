using DataAccess;
using Domain;
using Settings;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<IDbConfiguration, DbConfiguration>();

WebApplication app = builder.Build();

if(!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseRouting();
app.MapControllers();
app.Run();
