using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace BDestoque.Data
{
    public class BancoDados : DbContext
    {
        //Mapeamento das tabelas do banco de dados
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<MoviPro> MovimentacaoProdutos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
       

        public BancoDados()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //configuração do banco de dados
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=Estoque;Integrated Security=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //desabilita a exclusão em cascata
            foreach (var relacionamento in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relacionamento.DeleteBehavior = DeleteBehavior.Restrict;
            }
            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(BancoDados).Assembly);
        }

    }
}
