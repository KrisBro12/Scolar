using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scolar.Data.Entity
{
    public class Answers
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }  
        public virtual ICollection<Category> Category { get; set; }

        [ForeignKey(nameof(Questions))]
        public int QuestionsId { get; set; }

        public Questions Questions { get; set; }


    }
}
