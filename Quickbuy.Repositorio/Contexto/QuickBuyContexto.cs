﻿using Microsoft.EntityFrameworkCore;
using Quickbuy.Dominio.Entidades;
using Quickbuy.Dominio.ObjetoDeValor;
using Quickbuy.Repositorio.Config;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Classes de mapeamento
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());

            modelBuilder.Entity<FormaPagamento>().HasData(
                new FormaPagamento()
                {
                    Id = 1,
                    Nome = "Boleto",
                    Descricao = "Forma de pagamento Boleto"
                },
                 new FormaPagamento()
                 {
                     Id = 2,
                     Nome = "Cartão de Crédito",
                     Descricao = "Forma de pagamento Cartão de Crédito"
                 },
                 new FormaPagamento()
                 {
                     Id = 3,
                     Nome = "Depósito",
                     Descricao = "Forma de pagamento Depósito"
                 }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
