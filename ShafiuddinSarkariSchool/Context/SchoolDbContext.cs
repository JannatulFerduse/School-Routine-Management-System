using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShafiuddinSarkariSchool.Models;

namespace ShafiuddinSarkariSchool.Context
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
            : base(options)
        {

        }

        public DbSet<ShafiuddinSarkariSchool.Models.tblBloodGroup> tblBloodGroup { get; set; }
        public DbSet<ShafiuddinSarkariSchool.Models.tblClass> tblClass { get; set; }
        public DbSet<ShafiuddinSarkariSchool.Models.tblGender> tblGender { get; set; }

        public DbSet<ShafiuddinSarkariSchool.Models.tblMedium> tblMedium { get; set; }
      
        public DbSet<ShafiuddinSarkariSchool.Models.tblReligion> tblReligion { get; set; }

        public DbSet<ShafiuddinSarkariSchool.Models.tblTeacher> tblTeacher { get; set; }
        public DbSet<ShafiuddinSarkariSchool.Models.tblStudent> tblStudent { get; set; }
        public DbSet<ShafiuddinSarkariSchool.Models.tblSubject> tblSubject { get; set; }
        public DbSet<ShafiuddinSarkariSchool.Models.tblAdmin> tblAdmin { get; set; }
        public DbSet<ShafiuddinSarkariSchool.Models.tblSection> tblSection { get; set; }
        public DbSet<ShafiuddinSarkariSchool.Models.tblExam> tblExam { get; set; }
        public DbSet<ShafiuddinSarkariSchool.Models.tblLogin> tblLogin { get; set; }
    



    }
}
