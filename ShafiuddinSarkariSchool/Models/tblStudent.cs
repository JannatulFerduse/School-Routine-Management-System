using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShafiuddinSarkariSchool.Models
{
    public class tblStudent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblStudent()
        {
            this.tblTeachers = new HashSet<tblTeacher>();
        }
        [Key]
        public int StudentId { get; set; }
        [Required]
        public Nullable<int> MediumId { get; set; }
        [Required]
        public Nullable<int> ClassId { get; set; }
        [Required]
        public Nullable<int> RollNo { get; set; }
        [Required]
        public Nullable<int> SectionId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> AdmissionDate { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [Required]
        public string FathersName { get; set; }
        [Required]
        public string MothersName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public System.DateTime DateOfBirth { get; set; }
        [Required]
        public Nullable<int> GenderId { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Nationality { get; set; }
        [Required]
        public Nullable<int> BloodGroupId { get; set; }
        [Required]
        public Nullable<int> ReligionId { get; set; }
        [Required]
        public string ParentsCell { get; set; }


        public virtual tblBloodGroup tblBloodGroup { get; set; }
        public virtual tblClass tblClass { get; set; }
        public virtual tblGender tblGender { get; set; }
        public virtual tblMedium tblMedium { get; set; }
        public virtual tblReligion tblReligion { get; set; }
        public virtual tblSection tblSection { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTeacher> tblTeachers { get; set; }
    }
}
