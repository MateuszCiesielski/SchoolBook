using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }

        [Display(Name = "Imię")]
        [StringLength(30, MinimumLength = 2)]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Nazwisko")]
        [StringLength(30, MinimumLength = 2)]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Data urodzenia")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Adres zamieszkania")]
        [StringLength(150)]
        public string Address { get; set; }

        [Display(Name = "Numer telefonu")]
        [RegularExpression(@"[0-9+ ]*")]
        [StringLength(15)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Numer telefonu opiekuna")]
        [RegularExpression(@"[0-9+ ]*")]
        [StringLength(15)]
        public string GuardianPhoneNumber { get; set; }

        [Display(Name = "Waga [kg]")]
        [RegularExpression(@"[0-9,.]*")]
        [StringLength(7)]
        public string Weight { get; set; }

        [Display(Name = "Nauczyciel?")]
        public bool IsTeacher { get; set; }

        [Display(Name = "Aktywny?")]
        public bool IsActive { get; set; }

        [Display(Name = "Szczegółowe informacje")]
        [StringLength(500)]
        public string Info { get; set; }

        [Display(Name = "Data rozpoczęcia zajęć")]
        [DataType(DataType.Date)]
        public DateTime DateOfBeginning { get; set; }

        [Display(Name = "Zdjęcie")]
        public byte[] Photo { get; set; }

        public virtual PersonGroup PersonGroup { get; set; }
        public virtual UserPerson UserPerson { get; set; }
        public virtual Attendance Attendance { get; set; }
        public virtual Message Message { get; set; }
        public virtual MessageReceiver MessageReceiver { get; set; }
    }
}
