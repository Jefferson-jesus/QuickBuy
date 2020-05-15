using Quickbuy.Dominio.Contratos;
using Quickbuy.Dominio.Entidades;
using Quickbuy.Repositorio.Contexto;

namespace Quickbuy.Repositorio.Repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(QuickBuyContexto quickBuyContexto) 
            : base(quickBuyContexto)
        {
        }

    }
}
