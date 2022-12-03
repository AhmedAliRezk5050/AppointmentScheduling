using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using AppointmentScheduling.Data;
using AppointmentScheduling.Models;


var builder = WebApplication.CreateBuilder(args);

var config = builder.Configuration;

builder.Services.AddDbContext<AppDbContext>(o => 
    o.UseSqlServer(config.GetConnectionString("DefaultConnection")));
builder.Services.AddControllersWithViews();

builder.Services.AddDefaultIdentity<AppUser>()
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
