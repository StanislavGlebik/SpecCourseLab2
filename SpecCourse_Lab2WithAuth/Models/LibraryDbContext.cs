using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SpecCourse_Lab2WithAuth.Models
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(): base("name=DefaultConnection")
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}