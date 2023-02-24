using System.ComponentModel.DataAnnotations;

namespace Scolar.Data.Entity
{
    public class Schools
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string address { get; set; }

        public virtual ICollection<Category> Category { get; set; }

    }
}
