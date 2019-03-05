using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class ActivityTerms
    {
        [Key]
        public int ActivityTermsId { get; set; }
        public int GroupId { get; set; }
        public string DayOfWeek { get; set; }
        public string TimeBegin { get; set; }
        public string TimeEnd { get; set; }

        public virtual List<Group> Group { get; set; }
        public virtual ActivityDates ActivityDates { get; set; }
    }
}
