using Microsoft.EntityFrameworkCore;
using SanskariVidhyalay.Context;
using SanskariVidhyalay.Model;
using SanskariVidhyalay.Models;
using SanskariVidhyalay.Services;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseSerilog((context, services, configuration) => configuration
                .ReadFrom.Configuration(context.Configuration));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSession();

builder.Services.AddDbContext<StudentEntriesDB>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnect")));

builder.Services.AddDbContext<ContactDB>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnect")));

builder.Services.AddDbContext<CitiesDB>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnect")));

builder.Services.AddScoped<IStudentEntriesService, StudentEntriesService>();
builder.Services.AddScoped<IContact, IContactServices>();
builder.Services.AddScoped<ICities, ICitiesServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
