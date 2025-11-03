using TaskFlow.Web.Models;
namespace TaskFlow.Web.Data;
public static class DbInitializer
{
    public static async Task SeedAsync(ApplicationDbContext db)
    {
        if (!db.Tasks.Any())
        {
            db.Tasks.AddRange(
                new TaskItem { Title = "Set up CI/CD", AssignedTo = "Hemant", Status = "In Progress", DueDate = DateTime.UtcNow.AddDays(3) },
                new TaskItem { Title = "Containerize MVC app", AssignedTo = "You", Status = "To Do", DueDate = DateTime.UtcNow.AddDays(7) }
            );
            await db.SaveChangesAsync();
        }
    }
}
