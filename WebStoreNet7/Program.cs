using WebStoreNet7.Infrastructure.Convenctions;
using WebStoreNet7.Infrastructure.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(opt => opt.Conventions.Add(new TestControllerConvention())).AddRazorRuntimeCompilation();
var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseMiddleware<TestMiddleware>();
//app.MapGet("/", () => "Hello World!");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();