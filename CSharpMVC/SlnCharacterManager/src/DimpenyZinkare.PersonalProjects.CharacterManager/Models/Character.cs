using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DimpenyZinkare.PersonalProjects.CharacterManager.Models
{
    [Table("Character")]
    public class Character
    {
        
        [Column("id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("name")]
        [Display(Name ="Name")]
        public string Name { get; set; }

        [Column("age")]
        [Display(Name ="Age")]
        public int Age { get; set; }

        [Column("SexId")]
        [Display(Name ="Sex")]
        public int SexId { get; set; }


    }
}
