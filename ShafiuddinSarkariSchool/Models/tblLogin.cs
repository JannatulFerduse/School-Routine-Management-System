using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShafiuddinSarkariSchool.Models
{
    public class tblLogin
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string UserType { get; set; }
        [Required]
        
        [DataType(DataType.Password)]
       
        public string Password { get; set; }
    }
}
