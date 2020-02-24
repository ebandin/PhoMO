using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PhoMO.Models;

namespace PhoMO.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Photo> Photos { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

    }

}
