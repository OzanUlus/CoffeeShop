using CoffeeShop.DAL.Context;
using CoffeeShop.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlCon"));
});

builder.Services.AddIdentity<AppUser, AppRole>(option =>
{
    option.User.AllowedUserNameCharacters =
    "abc�defg�hi�jklmno�prs�tu�vyz" +
    "ABC�DEFG�H�IJKLMNO�PRS�TU�VYZ" +
    "QWX" + "wqx" + "1234567890";

    option.User.RequireUniqueEmail = true;
    option.SignIn.RequireConfirmedEmail = true;//ileri true
    option.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(3);
    option.Lockout.MaxFailedAccessAttempts = 6;


    option.Password.RequiredLength = 8;
    option.Password.RequireNonAlphanumeric = false;
    option.Password.RequireLowercase = false;
    option.Password.RequireUppercase = false;
    option.Password.RequireDigit = true;


}).AddDefaultTokenProviders()
     .AddEntityFrameworkStores<AppDbContext>();




// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
