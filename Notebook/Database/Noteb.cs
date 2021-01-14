using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Notebook.Database
{
    public partial class Noteb : DbContext
    {
        public Noteb()
            : base("name=Noteb1")
        {
        }

        public virtual DbSet<LoginDB> LoginDBs { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<NoteDB> NoteDBs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoginDB>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
