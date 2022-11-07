using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OnboardingProject.Controllers
{
    public partial class PropertyDBContext : DbContext
    {
        public virtual DbSet<PropertyDataModel> Property { get; set; }

        public PropertyDBContext(DbContextOptions<PropertyDBContext> options) : base(options) { }


        /*
        private string _conn = "";
        public PropertyDBContext(string conn)
        {
            _conn = conn;
        }
        public PropertyDBContext(DbContextOptions<PropertyDBContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_conn);
        }

        protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PropertyDataModel>(entity =>
            {
                entity.Property(e => e.Services).HasMaxLength(100).IsUnicode(true);
                entity.Property(e => e.Address).HasMaxLength(100).IsUnicode(true);
                entity.Property(e => e.Description).HasMaxLength(100).IsUnicode(true);
                entity.Property(e => e.EnglishDescription).HasMaxLength(100).IsUnicode(true);
                entity.Property(e => e.ItalianDescription).HasMaxLength(100).IsUnicode(true);
                entity.Property(e => e.PolishDescription).HasMaxLength(100).IsUnicode(true);
                entity.Property(e => e.Id).HasColumnName("Id");
                entity.Property(e => e.Surface);
            }
            );
        }
        */
    }
}
