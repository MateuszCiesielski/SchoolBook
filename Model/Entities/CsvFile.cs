using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class CsvFile
    {
        [Required]
        [Display(Name = "Plik CSV")]
        public string UploadedCSVFile { get; set; }
    }
}
