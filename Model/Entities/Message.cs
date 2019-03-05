using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }

        [Required]
        [Display(Name = "Data")]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Temat")]
        [StringLength(30)]
        public string Topic { get; set; }

        [Display(Name = "Treść")]
        public string ShortText { get; set; }

        [Required]
        [Display(Name = "Treść")]
        [StringLength(1000)]
        public string LongText { get; set; }

        public string SenderId { get; set; }

        public virtual List<ApplicationUser> Sender { get; set; }
        public virtual MessageReceiver MessageReceiver { get; set; }
    }
}
