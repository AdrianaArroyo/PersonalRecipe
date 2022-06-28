
using System.ComponentModel.DataAnnotations;

namespace Lab6_AdrianaAH_JonathanRM.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

    }
}
