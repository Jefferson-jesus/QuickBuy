using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Quickbuy.Dominio.Entidades;

namespace Quickbuy.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(x => x.Id);

            // Buulder utiliza o padrão flueut
            builder
                .Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(50);
            //.HasColumnType("vachar");

            builder
                .Property(x => x.Senha)
                .IsRequired()
                .HasMaxLength(400);

            builder
                .Property(x => x.SobreNome)
                .IsRequired()
                .HasMaxLength(50);

            //builder.Property(x => x.Pedidos);

            builder
                .HasMany(u => u.Pedidos)
                .WithOne(p => p.Usuario);
            
        }
    }
}
