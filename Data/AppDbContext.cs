using ApiDanielEstudo.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiDanielEstudo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
