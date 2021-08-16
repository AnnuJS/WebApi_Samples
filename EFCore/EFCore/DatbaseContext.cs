using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(p =>
            {
                p.HasKey(p => p.UserId);
                p.Property(p => p.Name).IsUnicode(false).HasMaxLength(50).IsRequired();
            });
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"data source=LAPTOP-ANNU; initial catalog=EFCore8PM;persist security info=True;user id=sa;password=sqluser123;");
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
