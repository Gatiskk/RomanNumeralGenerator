using RomanNumeralConverter.Data;
using RomanNumeralConverter.Interfaces;
using RomanNumeralConverter.Models;
using RomanNumeralConverter.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<IRomanNumeralGeneratorDbContext, RomanNumeralGeneratorDbContext>();
builder.Services.AddScoped<IDbService, DbService>();
builder.Services.AddScoped<IEntityService<HistoryLog>, EntityService<HistoryLog>>();
builder.Services.AddScoped<IHistoryLogService, LogHistoryService>();
builder.Services.AddScoped<IRomanNumeralGenerator, Generator>();

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