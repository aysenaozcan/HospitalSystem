using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Entity
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<tbl_bolum> tbl_bolum { get; set; }
        public virtual DbSet<tbl_doktor> tbl_doktor { get; set; }
        public virtual DbSet<tbl_hasta> tbl_hasta { get; set; }
        public virtual DbSet<tbl_randevu> tbl_randevu { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_bolum>()
                .HasMany(e => e.tbl_randevu)
                .WithOptional(e => e.tbl_bolum)
                .HasForeignKey(e => e.randevubolumid);

            modelBuilder.Entity<tbl_doktor>()
                .HasMany(e => e.tbl_randevu)
                .WithOptional(e => e.tbl_doktor)
                .HasForeignKey(e => e.randevudoktorid);

            modelBuilder.Entity<tbl_hasta>()
                .Property(e => e.hastaadsoyad)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_hasta>()
                .HasMany(e => e.tbl_randevu)
                .WithOptional(e => e.tbl_hasta)
                .HasForeignKey(e => e.randevuhastaid);

            modelBuilder.Entity<tbl_randevu>()
                .Property(e => e.randevutcno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tbl_randevu>()
                .Property(e => e.randevutel)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
