using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //importante

builder.Services
    .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options => options.LoginPath = "/Usuario/Index");

builder.Services.Configure<CookiePolicyOptions>(options =>
{
    options.CheckConsentNeeded = context => true;
    options.MinimumSameSitePolicy = SameSiteMode.None; //para dizer se dentro do mesmo site tem cookies diferentes
});

/*builder.Services.AddSession(option => option.IdleTimeout = TimeSpan.FromHours(4));  //Quanto tempo vai durar essa sessão a vida util do cookie. 
builder.Services.AddMemoryCache();*/   //********Descomentar aqui para mudar a forma de cookie com session

var app = builder.Build();

app.MapControllerRoute
    (
        name: "default",
        pattern: "{controller=Usuario}/{action=Index}/{id?}"
    );

app.UseAuthentication();
app.UseAuthorization();
app.UseCookiePolicy();
//app.UseSession();    // ********Descomentar aqui para mudar a forma de cookie com session

//app.MapGet("/", () => "Hello World!");

app.Run();
