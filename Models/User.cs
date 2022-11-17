using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        //Name
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Full Name")]
        [Required]
        [MaxLength(48, ErrorMessage = "pls")]
        public string Name { get; set; } = default!;

        //Bday
        [DisplayName("Birth Date")]
        [Required(ErrorMessage = "Birth Date is required")]
        //[DisplayFormat(DataFormatString = "{0:MMM, dd yyyy}")]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        //Email
        [Display(Name = "Email address")]
        [Column(TypeName = "nvarchar(100)")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailAdd { get; set; } = default!;

        //Address
        [Display(Name = "Present Address")]
        public string PresentAdd { get; set; } = default!;

        [DisplayName("Modifed Date")]
        public DateTime Date { get; set; }
    }
}
