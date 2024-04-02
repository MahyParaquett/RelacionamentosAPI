using Microsoft.EntityFrameworkCore;
using RelacionamentosAPI.Models;

namespace RelacionamentosAPI.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        //Trasforme CasaModel em tabela, colocando aqui posso escolher o nome que a tabela terá
        public DbSet<CasaModel> Casas {  get; set; }
        public DbSet<EnderecoModel> Enderecos { get; set; }
        public DbSet<MoradorModel> Moradores { get; set; }
    }
}
