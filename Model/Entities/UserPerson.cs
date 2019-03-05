using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class UserPerson
    {
        [Key]
        public int UserPersonId { get; set; }
        public int PersonId { get; set; }
        public string UserId { get; set; }

        public virtual List<Person> Person { get; set; }
        public virtual List<ApplicationUser> User { get; set; }
    }
}
