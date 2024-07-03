using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskService.Models
{
    [Table("NewTasks1")]
    public class Task
    {
        [Key]
        public int? Id { get; set; }
        
        public int? OrderId { get; set; }
        public string? PackagingNote { get; set; }
        public int? InspectionRating { get; set; }
        public string? SandblastingandSolderingNote { get; set; }
        public string? SandblastingandSolderingAmount {  get; set; }
        public string? PaintingNote {  get; set; }
        public string? StepName {  get; set; }
        public string? Color { get; set; }
        public string? Status {  get; set; }
        public string? PaintType {  get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
    }
}
