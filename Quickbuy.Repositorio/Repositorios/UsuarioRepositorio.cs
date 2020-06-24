using Quickbuy.Dominio.Contratos;
using Quickbuy.Dominio.Entidades;
using Quickbuy.Repositorio.Contexto;
using System.Linq;

namespace Quickbuy.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepository
    {
        public UsuarioRepositorio(QuickBuyContexto quickBuyContexto) 
            : base(quickBuyContexto)
        {
        }

        public Usuario Obter(string email, string senha)
        {
            return QuickBuyContexto.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }

        public Usuario Obter(string email)
        {
            return QuickBuyContexto.Usuarios.FirstOrDefault(u => u.Email == email);
        }
    }
}
