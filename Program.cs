var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //подключение MVC 

var app = builder.Build();

app.UseStaticFiles();// подключение статических файлов

app.MapControllerRoute(
    name:"default",
    pattern:"{controller=News}/{action=News}");// настройка роутинга

app.Run();
