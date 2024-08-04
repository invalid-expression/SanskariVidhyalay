using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanskariVidhyalay.Models
{
    public class Contact
    {
        [Key]
        public int No { get; set; }
        
        [Column("Name", TypeName = "Varchar(30)")]
        [Required]
        public string Name {  get; set; }

        [Column("Email Address", TypeName = "Varchar(80)")]
        [Required]
        public string Email { get; set; }

        [Column("Subject",TypeName = "Varchar(100)")]
        [Required]
        public string Subject { get; set; }

        [Column("Message", TypeName = "Varchar(Max)")]
        [Required]
        public string Message { get; set; }
    }
}
