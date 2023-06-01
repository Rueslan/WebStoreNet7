using WebStoreNet7.Infrastructure.Convenctions;
using WebStoreNet7.Infrastructure.Middleware;
using WebStoreNet7.Services;
using WebStoreNet7.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
services.AddSingleton<IEmployeesData,InMemoryEmployeesData>();
services.AddControllersWithViews(opt => opt.Conventions.Add(new TestControllerConvention())).AddRazorRuntimeCompilation();
var app = builder.Build();

#if DEBUG
    app.UseDeveloperExceptionPage();
#endif

//app.UseStatusCodePages();
app.UseStaticFiles();
app.UseRouting();
app.UseMiddleware<TestMiddleware>();
//app.UseStatusCodePagesWithReExecute("/Home/Status/{0}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();