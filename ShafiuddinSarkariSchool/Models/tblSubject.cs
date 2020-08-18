using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShafiuddinSarkariSchool.Models
{
    public class tblSubject
    {
        [Key]
        public int SubjectId { get; set; }
        public string Name { get; set; }
    }
}
