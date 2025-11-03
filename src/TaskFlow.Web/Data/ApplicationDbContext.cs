using Microsoft.EntityFrameworkCore;
using TaskFlow.Web.Models;
namespace TaskFlow.Web.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    public DbSet<TaskItem> Tasks => Set<TaskItem>();
}
