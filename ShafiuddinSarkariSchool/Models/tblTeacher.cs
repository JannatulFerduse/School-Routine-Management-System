using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShafiuddinSarkariSchool.Models
{
    public class tblTeacher
    {

        [Key]
        public int TeacherId { get; set; }
        [Required]
        [Display(Name = "Teacher Name")]
        public string Name { get; set; }
       
        [Required]
        public Nullable<int> ClassId { get; set; }
        [Required]
        public Nullable<int> SectionId { get; set; }
        [Required]
        public Nullable<int> StudentId { get; set; }
        [Required]
        public Nullable<int> ExamId { get; set; }

        [Required]
        public decimal Bangla { get; set; }

        [Required]
        public decimal English { get; set; }
        [Required]
        public decimal Math { get; set; }

        [Required]
        public decimal Religion { get; set; }


        [Required]
        public decimal SocialScience { get; set; }
        [Required]
        public decimal Science { get; set; }
        [Required]
        public decimal TotalMarks { get; set; }
        public virtual tblClass tblClass { get; set; }
        public virtual tblExam tblExam { get; set; }
        public virtual tblSection tblSection { get; set; }
        public virtual tblStudent tblStudent { get; set; }
    }
}
