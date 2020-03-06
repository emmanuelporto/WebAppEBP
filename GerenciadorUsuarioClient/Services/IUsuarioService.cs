using System.Threading.Tasks;
using UserLibrary;

namespace GerenciadorUsuarioClient.Services
{
    public interface IUsuarioService
    {
        Task<Usuario[]> ListarUsuariosAsync();
    }
}
