using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OnboardingProject.Controllers
{
    public partial class PropertyDBContext : DbContext
    {
        public virtual DbSet<PropertyDataModel> Property { get; set; }

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.\SQLExpress;Database=SchoolDB;Trusted_Connection=True;");
            }
        }
        */

        //override??
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
    }
}
