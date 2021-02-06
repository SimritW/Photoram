using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Photosphere.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Photosphere.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        // Dbsets for additional tables/entities

        public DbSet<Photo> Photos { get; set; }
    }
}
