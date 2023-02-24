using System.ComponentModel.DataAnnotations;

namespace Scolar.Data.Entity
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Answers> Answers { get; set; }

        public virtual ICollection<Schools> Schools { get; set; }


    }
}
