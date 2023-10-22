using KseniaViktorovaKt_41_20.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using KseniaViktorovaKt_41_20.Data.Configurations;

namespace KseniaViktorovaKt_41_20.Data
{
    public class RecordsContext : DbContext
    {
        public RecordsContext(DbContextOptions<RecordsContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        //public DbSet<Subjects> Subjects { get; set; }
        //public DbSet<RecordsSession> RecordsSession { get; set; }
        //public DbSet<RecordsSemester> RecordsSemester { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
            //modelBuilder.ApplyConfiguration(new SemesterConfiguration());
            //modelBuilder.ApplyConfiguration(new SessionConfiguration());
            //modelBuilder.ApplyConfiguration(new SubjectConfiguration());
        }
    }
}



