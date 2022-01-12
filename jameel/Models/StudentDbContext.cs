using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jameel.Models
{
    public class StudentDbContext : DbContext
    {
        public DbSet<student> students { get; set; } 


        public StudentDbContext(DbContextOptions<StudentDbContext> options)
         : base(options)
        {
        }

    }
}
