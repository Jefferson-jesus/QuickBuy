using Microsoft.EntityFrameworkCore;
using Quickbuy.Dominio.Entidades;
using Quickbuy.Dominio.ObjetoDeValor;

namespace Quickbuy.Repositorio.Contexto
{
    public class QuickBuyContexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItemPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamentos { get; set; }

        public QuickBuyContexto(DbContextOptions options) 
            : base(options)
        {

        }
    }
}
