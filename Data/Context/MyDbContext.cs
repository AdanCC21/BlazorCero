using Entities.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options){}
        
        // Tables
        public DbSet<E_Major> Majors { get; set; }
        public DbSet<E_Course> Courses { get; set; }
    }
}
