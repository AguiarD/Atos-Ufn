var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //vs 2019, precisa encontrar o Services e adcionar este comando

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.MapControllerRoute(
    name: "dafault",
    pattern: "{controller=Home}/{action=Index}/{Id?}"
    );

app.Run();
