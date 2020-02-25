using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PhoMO.Models;
using System.Linq;
using System.Threading.Tasks;


namespace PhoMO.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Photo> Photos { get; set; }

        public DbSet<PhotoDate> Dates { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<PhotoMenu>()
        //        .HasKey(c => new { c.PhotoID, c.MenuID });
        //}
    }

}
