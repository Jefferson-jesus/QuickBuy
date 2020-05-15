using Quickbuy.Dominio.Contratos;
using Quickbuy.Dominio.Entidades;
using Quickbuy.Repositorio.Contexto;

namespace Quickbuy.Repositorio.Repositorios
{
    public class PedidoRepositorio : BaseRepositorio<Pedido>, IPedidoRepositorio
    {
        public PedidoRepositorio(QuickBuyContexto quickBuyContexto) 
            : base(quickBuyContexto)
        {
        }
    }
}
