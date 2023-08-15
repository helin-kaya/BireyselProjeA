using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelProjesiEntity
{
    public class Personel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }
        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string Email { get; set; }
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
        [Required]
        [MinLength(11)]
        [StringLength(11, ErrorMessage = "TcKimlik numarası 11 haneli olmalıdır!")]
        [Display(Name = "TC Kimlik Numarası")]
        public string TCNumber { get; set; }

        [Required]
        public string Gender { get; set; }
        [Required]
        public string EducationStatus { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
    }
}
