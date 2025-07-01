var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseRouting();

// Middleware route (Endpoint Routing)
app.UseEndpoints(endpoints =>
{
    // Conventional Routing
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    // Area Routing
    endpoints.MapControllerRoute(
        name: "areas",
        pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");

    // Custom inline middleware
    endpoints.MapGet("/health", async context =>
    {
        await context.Response.WriteAsync("Healthy");
    });
});

app.Run();
