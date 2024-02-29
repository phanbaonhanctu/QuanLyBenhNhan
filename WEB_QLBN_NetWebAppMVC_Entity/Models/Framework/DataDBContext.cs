using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AspWebMvc.Models.Framework
{
    public partial class DataDBContext : DbContext
    {
        public DataDBContext()
            : base("name=DataDBContext")
        {
        }

        public virtual DbSet<ACCOUNT> ACCOUNTs { get; set; }
        public virtual DbSet<BENHNHAN> BENHNHANs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BENHNHAN>()
                .Property(e => e.phone)
                .IsFixedLength();

            modelBuilder.Entity<BENHNHAN>()
                .Property(e => e.gender)
                .IsFixedLength();
        }
    }
}
