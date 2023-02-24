using System.ComponentModel.DataAnnotations;

namespace Scolar.Data.Entity
{
    public class Questions
    {
        [Key]
        public int Id { get; set; } 
        public string Question { get; set; }
    }
}
