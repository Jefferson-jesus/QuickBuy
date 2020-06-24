using Quickbuy.Dominio.Entidades;

namespace Quickbuy.Dominio.Contratos
{
    public interface IUsuarioRepository : IBaseRepositorio<Usuario>
    {
        Usuario Obter(string email, string senha);
        Usuario Obter(string email);
    }
}
