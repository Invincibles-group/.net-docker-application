using Microsoft.EntityFrameworkCore;
using TaskFlow.Web.Data;

var builder = WebApplication.CreateBuilder(args);
var conn = builder.Configuration.GetConnectionString("DefaultConnection") ??
           Environment.GetEnvironmentVariable("ConnectionStrings__DefaultConnection") ??
           "Server=localhost;Database=TaskFlowDb;User ID=sa;Password=YourStrong!Passw0rd;TrustServerCertificate=True;";
builder.Services.AddDbContext<ApplicationDbContext>(o => o.UseSqlServer(conn));
builder.Services.AddControllersWithViews();

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    db.Database.EnsureCreated();
    await DbInitializer.SeedAsync(db);
}
app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
