using Livroteria_back.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Livroteria_back.Data.Map
{
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Titulo).IsRequired().HasMaxLength(100);
            builder.Property(x => x.SubTitulo).HasMaxLength(100);
            builder.Property(x => x.Resumo).HasMaxLength(500);
            builder.Property(x => x.QuantPaginas).IsRequired();
            builder.Property(x => x.DataPublicacao).IsRequired();
            builder.Property(x => x.Editora).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Edicao);
            builder.Property(x => x.Imagem);
            builder.HasMany(x => x.Autores).WithOne(x => x.Livro).OnDelete(DeleteBehavior.Cascade);

        }
    }
}
