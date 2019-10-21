using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using NavigationLesson.Models;

namespace NavigationLesson.DataAccess
{
    public class LIbraryContext : DbContext
    {
        public LIbraryContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Book>Books { get; set; }
        public DbSet<Autor>Autors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=A-305-08;Database=LibraryDatabaseSharp;Trusted_connection=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("books");
            modelBuilder.Entity<Autor>()
                .HasMany(x=>x.Books)
                .WithOne(x=>x.Autor);


        }
    }
}
