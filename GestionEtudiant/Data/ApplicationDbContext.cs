using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using GestionEtudiant.Models;

namespace GestionEtudiant.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<GestionEtudiant.Models.Student> Student { get; set; }
        public DbSet<GestionEtudiant.Models.Role> Role { get; set; }
    }
}
