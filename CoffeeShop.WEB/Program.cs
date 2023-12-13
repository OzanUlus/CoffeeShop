using CoffeeShop.DAL.Abstract;
using CoffeeShop.DAL.Context;
using CoffeeShop.DAL.Repository;
using CoffeeShop.DAL.UnitOfWork;
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
    "abcçdefgðhiýjklmnoöprsþtuüvyz" +
    "ABCÇDEFGÐHÝIJKLMNOÖPRSÞTUÜVYZ" +
    "QWX" + "wqx" + "1234567890";

    option.User.RequireUniqueEmail = true;
    option.SignIn.RequireConfirmedEmail = false;//ileri true
    option.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(3);
    option.Lockout.MaxFailedAccessAttempts = 6;


    option.Password.RequiredLength = 8;
    option.Password.RequireNonAlphanumeric = false;
    option.Password.RequireLowercase = false;
    option.Password.RequireUppercase = false;
    option.Password.RequireDigit = true;


}).AddDefaultTokenProviders()
     .AddEntityFrameworkStores<AppDbContext>();

builder.Services.AddScoped<ICakeRepository,CakeRepository>();
builder.Services.AddScoped<ICoffeeRepository,CoffeeRepository>();
builder.Services.AddScoped<ICoffeeSizeRepository,CoffeeSizeRepository>();
builder.Services.AddScoped<ICookyRepository,CookyRepository>();
builder.Services.AddScoped<IExtraRepository,ExtraRepository>();
builder.Services.AddScoped<IOrderLineRepository,OrderLineRepository>();
builder.Services.AddScoped<IOrderRepository,OrderRepository>();
builder.Services.AddScoped<IUOW, UOW>();




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
