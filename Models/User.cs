using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Full Name")]
        [Required]
        [MaxLength(48, ErrorMessage = "pls")]
        public string Name { get; set; }

        [DisplayName("Birth Date")]
        [Required(ErrorMessage = "PLEASE")]

        [DisplayFormat(DataFormatString = "{0:MMM, dd yyyy}")]
        public DateTime Birthdate { get; set; }
    }
}
