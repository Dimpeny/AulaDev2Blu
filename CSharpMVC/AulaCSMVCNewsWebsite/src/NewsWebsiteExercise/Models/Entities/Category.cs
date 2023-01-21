using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsWebsiteExercise.Models.Entities
{
    [Table("Category")]
    public class Category
    {
        [Column("Id")]
        [Display(Name="Id")]
        public int Id { get; set; }

        [Column("Name")]
        [Display(Name="Category")]
        public string Name { get; set; }

        public ICollection<News>? News { get; set; }
    }
}
