using Microsoft.EntityFrameworkCore;
using NEXTI_API_REST.Models;

namespace NEXTI_API_REST.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Evento> Eventos { get; set; }


    }
}
