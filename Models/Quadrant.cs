using System.ComponentModel.DataAnnotations;

namespace Mission_8.Models
{
    public class Quadrant
    {
        [Key]
        public int QuadrantId { get; set; }
        public int QuadrantNumber { get; set; }
    }
}
