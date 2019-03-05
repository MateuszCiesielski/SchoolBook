using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class PersonGroup
    {
        [Key]
        public int PersonGroupId { get; set; }
        public int PersonId { get; set; }
        public int GroupId { get; set; }

        public virtual List<Person> Person { get; set; }
        public virtual List<Group> Group { get; set; }
    }
}
