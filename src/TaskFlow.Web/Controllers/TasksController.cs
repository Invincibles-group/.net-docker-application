using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskFlow.Web.Data;
using TaskFlow.Web.Models;
namespace TaskFlow.Web.Controllers;
public class TasksController : Controller
{
    private readonly ApplicationDbContext _db;
    public TasksController(ApplicationDbContext db) => _db = db;
    public async Task<IActionResult> Index() => View(await _db.Tasks.ToListAsync());
}
