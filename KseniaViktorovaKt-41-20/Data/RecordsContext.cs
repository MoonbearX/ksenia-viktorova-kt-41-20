using KseniaViktorovaKt_41_20.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace KseniaViktorovaKt_41_20.Data
{
    public class RecordsContext : DbContext
    {
        public RecordsContext(DbContextOptions<RecordsContext> options) : base(options)
        {

        }

        public DbSet<Students> Students { get; set; }
        public DbSet<Groups> Groups { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<RecordsSession> RecordsSession { get; set; }
        public DbSet<RecordsSemester> RecordsSemester { get; set; }
    }
}


