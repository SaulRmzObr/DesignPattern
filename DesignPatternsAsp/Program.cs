using DesignPatternsAsp.Configuration;
using Tools.Ganancias;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.Configure<MyConfig>(builder.Configuration.GetSection("MyConfig"));
builder.Services.AddTransient((factory) =>
{
    return new FactoryGananciaLocal(builder.Configuration.GetSection("MyConfig").GetValue<double>("PorcentajeGanaciaLocal"));
});
builder.Services.AddTransient((factory) =>
{
    return new FactoryGananciaExtranjero(
        builder.Configuration.GetSection("MyConfig").GetValue<double>("PorcentajeGananciaExtranjero"),
        builder.Configuration.GetSection("MyConfig").GetValue<double>("ComisionExtranjero"));
});

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
