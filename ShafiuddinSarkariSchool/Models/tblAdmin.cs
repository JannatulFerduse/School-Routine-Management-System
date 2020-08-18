using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShafiuddinSarkariSchool.Models
{
    public class tblAdmin
    {
        [Key]
        public int AdminId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public System.DateTime ExamDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public System.DateTime MarksSubmitDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public System.DateTime ResultPublishDate { get; set; }
    }
}
