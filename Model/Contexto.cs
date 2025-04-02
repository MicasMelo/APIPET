using Microsoft.EntityFrameworkCore;

namespace APIPET.Model
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options): base(options) { }

        public DbSet<Animal> Animais { get; set; }
    }
}
