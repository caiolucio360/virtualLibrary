using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using VirtualLibrary.Models;

namespace VirtualLibrary.Repository.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Data Source=CAIO-PC;DataBase=VirtualLibrary;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Publisher>().HasData(
            //    new Publisher
            //    {
            //        Id = Guid.Parse("3EEF9A14-D738-49C0-91D1-3CAB845DB8C3"),
            //        Name = "Nice Books",
            //    },
            //    new Publisher
            //    {
            //        Id = Guid.Parse("C8DCAF61-9400-4907-866B-3F83F05361C4"),
            //        Name = "Grenn Books",
            //    },
            //    new Publisher
            //    {
            //        Id = Guid.Parse("2EF886B9-F41E-460B-9CF8-6181F4BD6415"),
            //        Name = "Amazing Books",
            //    }
            //);

            //modelBuilder.Entity<Author>().HasData(
            //    new Author
            //    {
            //        Id = Guid.Parse("E5774DD4-5F30-44AC-B7E8-9AB1ED49F995"),
            //        Name = "Caio",
            //        Gender = "Male",
            //        BirthDate = new DateTime(2008, 6, 1),
            //        Email = "caio@gmail.com",
            //        Number = "2625929829825"
            //    },
            //    new Author
            //    {
            //        Id = Guid.Parse("0F2A0A22-F7B6-4C71-A1BB-D20C5CAF81A2"),
            //        Name = "Fernanda",
            //        Gender = "Female",
            //        BirthDate = new DateTime(2005, 9, 1),
            //        Email = "Fernanda@gmail.com",
            //        Number = "498749841984",
            //    },
            //    new Author
            //    {
            //        Id = Guid.Parse("1E2BD0A0-1CEA-445C-BD67-D69E3878EAC6"),
            //        Name = "Gabriel",
            //        Gender = "Male",
            //        BirthDate = new DateTime(2002, 5, 15),
            //        Email = "Gabriel@gmail.com",
            //        Number = "198493232312"
            //    });

            //modelBuilder.Entity<Book>().OwnsOne(
            //    new Book
            //    {
            //        Id = Guid.Parse("589a3c0a-49ce-4571-a34a-eaaf6839f836"),
            //        Title = "Fernanda",
            //        Author = Guid.Parse("E5774DD4-5F30-44AC-B7E8-9AB1ED49F995"),
            //        Publisher = new Publisher { Name = "Nice Books", Id = Guid.Parse("3EEF9A14-D738-49C0-91D1-3CAB845DB8C3") },
            //        ReleaseDate = DateTime.Now,
            //    });
        }
    }
}
