using System.ComponentModel.DataAnnotations;
namespace TaskFlow.Web.Models;
public class TaskItem
{
    public int Id { get; set; }
    [Required, StringLength(200)] public string Title { get; set; } = string.Empty;
    [StringLength(100)] public string? AssignedTo { get; set; }
    [Required, StringLength(50)] public string Status { get; set; } = "To Do";
    [DataType(DataType.Date)] public DateTime? DueDate { get; set; }
}
