using Livroteria_back.Data.Map;
using Livroteria_back.Models;
using Microsoft.EntityFrameworkCore;

namespace Livroteria_back.Data
{
    public class DataContext :DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Livro>? Livros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LivroMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
