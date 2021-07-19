using Microsoft.EntityFrameworkCore;
using SnackApp.Models;

namespace SnackApp.Context
{
    // Inherit from DbContext to represent a session with the DB 
    public class AppDbContext : DbContext
    {
        // ctor
        // DbContextOptions references the class AppDbContext
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Properties to reference the tables 
        // Mapping
        public DbSet<Lanche> Lanches { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}