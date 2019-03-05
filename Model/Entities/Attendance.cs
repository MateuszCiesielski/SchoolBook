using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Attendance
    {
        [Key]
        public int AttendanceId { get; set; }
        public int ActivityDatesId { get; set; }
        public int PersonId { get; set; }
        public bool IsPresent { get; set; }

        public virtual List<Person> Person { get; set; }
        public virtual List<ActivityDates> ActivityDates { get; set; }
    }
}
