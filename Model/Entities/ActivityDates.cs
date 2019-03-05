using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class ActivityDates
    {
        [Key]
        public int ActivityDatesId { get; set; }
        public int GroupId { get; set; }
        public DateTime ActivityDate { get; set; }
        public DateTime TimeEnd { get; set; }
        public int ActivityTermsId { get; set; }

        public virtual List<Group> Group { get; set; }
        public virtual List<ActivityTerms> ActivityTerms { get; set; }
        public virtual Attendance Attendance { get; set; }
    }
}
