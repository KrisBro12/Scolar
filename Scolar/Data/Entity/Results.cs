using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scolar.Data.Entity
{
    public class Results
    {
        [Key]
        public int Id { get; set; }

        public int Points { get; set; }

        [ForeignKey(nameof(User))]

        public string UserId { get; set; }

        public User User { get; set; }

        
    }
}
