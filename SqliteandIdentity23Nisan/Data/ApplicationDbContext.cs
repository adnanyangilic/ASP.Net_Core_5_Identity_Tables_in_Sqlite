using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SqliteandIdentity23Nisan.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqliteandIdentity23Nisan.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Employee> Employees {get; set;}
    }
}
