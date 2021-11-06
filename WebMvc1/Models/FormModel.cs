using System.ComponentModel.DataAnnotations;

namespace WebMvc1.Models
{
    public class FormModel
    {
        [Display(Name = "Imie")]
        public string Name { get; set; }

        public System.DateTime DateOfBirth { get; set; }

        [Display(Name = "Dni od urodzin")]
        public double Days { get; set; }
        
    }
}
