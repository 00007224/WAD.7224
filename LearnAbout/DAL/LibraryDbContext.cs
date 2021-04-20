using LearnAbout.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace LearnAbout.DAL
{
    public class LibraryDbContext : DbContext

    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<Course> Courses { get; set; }

    }
}
