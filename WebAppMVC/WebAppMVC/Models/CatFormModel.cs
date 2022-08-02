using System.ComponentModel.DataAnnotations;

namespace WebAppMVC.Models
{
    public class CatFormModel
    {
        [Required]
        public string Name { get; init; }

        [Range(0,20)]
        public int Age { get; init; }
    }
}
