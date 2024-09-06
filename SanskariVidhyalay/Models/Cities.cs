using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanskariVidhyalay.Models
{
    public class Cities
    {
        [Key]
        public int CityNumber { get; set; }

        [Required]
        [Column(TypeName = "Varchar(50)")]
        public string City { get; set; }
    }
}
