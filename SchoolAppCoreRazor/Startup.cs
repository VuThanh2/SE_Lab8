using System.Configuration;
using Microsoft.EntityFrameworkCore;
using SchoolAppCoreRazor.Models;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

ConfigureServices(builder.Services);
void ConfigureServices(IServiceCollection services)
{
    var configuration = builder.Configuration;
    services.AddDbContext<SchoolContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("SchoolDBConnectionString")));
    services.AddRazorPages();
    services.AddAuthorization();
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();