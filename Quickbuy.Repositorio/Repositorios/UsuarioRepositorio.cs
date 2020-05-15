using Quickbuy.Dominio.Contratos;
using Quickbuy.Dominio.Entidades;
using Quickbuy.Repositorio.Contexto;

namespace Quickbuy.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepository
    {
        public UsuarioRepositorio(QuickBuyContexto quickBuyContexto) 
            : base(quickBuyContexto)
        {
        }
    }
}
