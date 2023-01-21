using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSMVCNewsWebsite.Models.Entities
{
    [Table("News")]
    public class News
    {

        [Column("Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("CategoryId")]
        [Display(Name = "Category Id")]
        public int CategoryId { get; set; }

        [Column("Title")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Column("Description")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        public virtual Category? Category { get; set; }
    }
}
