using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }

        [Display(Name = "Nazwa grupy")]
        [StringLength(30)]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Opłata [zł]")]
        [RegularExpression(@"[0-9,.]*")]
        public string Fee { get; set; }

        [Display(Name = "Grupa rekrutacyjna?")]
        public bool IsRecruitment { get; set; }

        [Display(Name = "Aktywna?")]
        public bool IsActive { get; set; }

        [Display(Name = "Miejsce odbywania zajęć")]
        [StringLength(150)]
        public string Place { get; set; }

        [Display(Name = "Szczegółowe informacje")]
        [StringLength(500)]
        public string Info { get; set; }

        public virtual PersonGroup PersonGroup { get; set; }
        public virtual ActivityDates LessonDates { get; set; }
        public virtual ActivityTerms ActivityTerms { get; set; }
    }
}
