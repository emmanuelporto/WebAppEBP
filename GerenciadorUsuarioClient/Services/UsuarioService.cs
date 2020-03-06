using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Threading.Tasks;
using UserLibrary;

namespace GerenciadorUsuarioClient.Services
{
    public class UsuarioService : IUsuarioService
    {
        private static readonly string UrlBase = "https://localhost:44375/";
        private static readonly string UrlListarUsuarios = $"{UrlBase}api/usuarios";
        private readonly HttpClient _httpClient;

        public async Task<Usuario[]> ListarUsuariosAsync()
        {
            Usuario[] resultado = await _httpClient.GetJsonAsync<Usuario[]>(UrlListarUsuarios);    
            return resultado;
        }
    }
}
