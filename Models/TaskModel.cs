using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission_8.Models
{
    public class TaskModel
    {
        [Key]
        [Required]
        public int TaskId { get; set; }
        [Required]
        public string TaskDescription { get; set; }
        public string DueDate { get; set; }
        [Required]
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        [Required]
        [ForeignKey("QuadrantId")]
        public int QuadrantId { get; set; }
        public bool IsCompleted { get; set; }
    }
}
